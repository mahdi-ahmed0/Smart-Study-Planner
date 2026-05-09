using System;

namespace Study_Planner.Models
{
    // نسخة من المادة بعد التوزيع
    public class PlannedSubject
    {
        public string Name { get; set; }

        public double TotalHours { get; set; }

        public double DailyHours { get; set; }

        public double MorningHours { get; set; }
        public double EveningHours { get; set; }
        public double NightHours { get; set; }

        public DateTime ExamDate { get; set; }

        public double Weight { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public PriorityLevel Priority { get; set; }

        // تمثيل جاهز للعرض
        public string DisplayTime
        {
            get
            {
                // إجمالي الساعات
                double total = Math.Round(MorningHours + NightHours, 2);

                if (MorningHours > 0 && NightHours > 0)
                    return $"{total}h (M:{MorningHours:F2} / N:{NightHours:F2})";

                if (MorningHours > 0)
                    return $"{total}h (Morning)";

                if (NightHours > 0)
                    return $"{total}h (Night)";

                return "0h";
            }
        }
    }
}