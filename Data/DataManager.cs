using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Study_Planner.Models;

namespace Study_Planner.Data
{
    public class DataManager
    {
        private readonly string usersFile = "Data/users.txt";
        private readonly string dailyFile = "Data/dailyPlans.txt";
        private readonly string weeklyFile = "Data/weeklyPlans.txt";

        public DataManager()
        {
            Directory.CreateDirectory("Data");

            if (!File.Exists(usersFile)) File.Create(usersFile).Close();
            if (!File.Exists(dailyFile)) File.Create(dailyFile).Close();
            if (!File.Exists(weeklyFile)) File.Create(weeklyFile).Close();
        }

        // ================= USERS =================

        public void SaveUser(User user)
        {
            var line = $"{user.ID}|{user.Name.Trim()}|{user.Email.Trim()}|{user.Password.Trim()}";
            File.AppendAllLines(usersFile, new[] { line });
        }

        public User Login(string email, string password)
        {
            if (!File.Exists(usersFile)) return null;

            var lines = File.ReadAllLines(usersFile);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var p = line.Split('|');
                if (p.Length < 4) continue;

                if (p[2].Trim() == email.Trim() &&
                    p[3].Trim() == password.Trim())
                {
                    return new User
                    {
                        ID = int.Parse(p[0]),
                        Name = p[1],
                        Email = p[2],
                        Password = p[3]
                    };
                }
            }

            return null;
        }
        public User GetUserByIdAndEmail(int id, string email)
        {
            if (!File.Exists(usersFile)) return null;

            var lines = File.ReadAllLines(usersFile);

            foreach (var line in lines)
            {
                var p = line.Split('|');
                if (p.Length < 4) continue;

                if (int.Parse(p[0]) == id && p[2].Trim() == email.Trim())
                {
                    return new User
                    {
                        ID = int.Parse(p[0]),
                        Name = p[1],
                        Email = p[2],
                        Password = p[3]
                    };
                }
            }

            return null;
        }

        public bool UpdatePassword(int id, string name, string email, string newPassword)
        {
            if (!File.Exists(usersFile)) return false;

            var lines = File.ReadAllLines(usersFile).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                var p = lines[i].Split('|');
                if (p.Length < 4) continue;

                if (int.Parse(p[0]) == id && p[2].Trim() == email.Trim())
                {
                    lines[i] = $"{p[0]}|{p[1]}|{p[2]}|{newPassword}";
                    File.WriteAllLines(usersFile, lines);
                    return true;
                }
            }

            return false;
        }

        // ================= DAILY =================

        public void SaveDailyPlan(int userId, Plan plan)
        {
            var subjects = string.Join(";", plan.Subjects.Select(s =>
                $"{s.Name},{s.Difficulty},{s.Priority},{s.ExamDate:yyyy-MM-dd},{s.MorningHours},{s.EveningHours},{s.NightHours}"
            ));

            var line = $"{userId}|{plan.StartDate:yyyy-MM-dd}|{subjects}";
            File.AppendAllLines(dailyFile, new[] { line });
        }

        public Plan LoadLastDailyPlan(int userId)
        {
            var lines = File.ReadAllLines(dailyFile)
                .Where(l => l.StartsWith(userId + "|"))
                .ToList();

            if (lines.Count == 0) return null;

            var parts = lines.Last().Split('|');
            if (parts.Length < 3) return null;

            var plan = new Plan
            {
                StartDate = DateTime.Parse(parts[1]),
                Type = Plan.PlanType.Daily
            };

            foreach (var s in parts[2].Split(';'))
            {
                var d = s.Split(',');
                if (d.Length < 7) continue;

                plan.Subjects.Add(new PlannedSubject
                {
                    Name = d[0],
                    Difficulty = Enum.Parse<DifficultyLevel>(d[1]),
                    Priority = Enum.Parse<PriorityLevel>(d[2]),
                    ExamDate = DateTime.Parse(d[3]),
                    MorningHours = double.Parse(d[4]),
                    EveningHours = double.Parse(d[5]),
                    NightHours = double.Parse(d[6])
                });
            }

            return plan;
        }

        // ================= WEEKLY =================

        public void SaveWeeklyPlans(int userId, List<Plan> plans)
        {
            var days = string.Join("#", plans.Select(p =>
                $"{p.StartDate:yyyy-MM-dd}>{string.Join(";", p.Subjects.Select(s =>
                    $"{s.Name},{s.Difficulty},{s.Priority},{s.ExamDate:yyyy-MM-dd},{s.MorningHours},{s.EveningHours},{s.NightHours}"
                ))}"
            ));

            var line = $"{userId}|{plans[0].StartDate:yyyy-MM-dd}|{days}";
            File.AppendAllLines(weeklyFile, new[] { line });
        }

        public List<Plan> LoadWeeklyPlans(int userId)
        {
            var lines = File.ReadAllLines(weeklyFile)
                .Where(l => l.StartsWith(userId + "|"))
                .ToList();

            if (lines.Count == 0) return null;

            var parts = lines.Last().Split('|');
            if (parts.Length < 3) return null;

            var result = new List<Plan>();

            foreach (var d in parts[2].Split('#'))
            {
                var split = d.Split('>');
                if (split.Length < 2) continue;

                var plan = new Plan
                {
                    StartDate = DateTime.Parse(split[0]),
                    Type = Plan.PlanType.Weekly
                };

                foreach (var s in split[1].Split(';'))
                {
                    var data = s.Split(',');
                    if (data.Length < 7) continue;

                    plan.Subjects.Add(new PlannedSubject
                    {
                        Name = data[0],
                        Difficulty = Enum.Parse<DifficultyLevel>(data[1]),
                        Priority = Enum.Parse<PriorityLevel>(data[2]),
                        ExamDate = DateTime.Parse(data[3]),
                        MorningHours = double.Parse(data[4]),
                        EveningHours = double.Parse(data[5]),
                        NightHours = double.Parse(data[6])
                    });
                }

                result.Add(plan);
            }

            return result;
        }
    }
}