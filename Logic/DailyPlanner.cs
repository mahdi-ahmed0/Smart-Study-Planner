using Study_Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static Study_Planner.Models.Plan;

namespace Study_Planner.Logic
{
    public class DailyPlanner : PlannerBase
    {
        public Plan GeneratePlan(List<Subject> subjects, DateTime planDate, double studyHours)
        {
            if (subjects == null || subjects.Count == 0)
                throw new Exception("لا يوجد مواد");

            if (studyHours <= 0)
                throw new Exception("عدد الساعات غير صحيح");

            // حساب مجموع الأوزان
            double totalWeight = subjects.Sum(s => CalculateWeight(s, planDate));

            // إنشاء الخطة
            Plan plan = new Plan
            {
                CreatedDate = DateTime.Now,
                StartDate = planDate,
                StudyHoursPerDay = studyHours,
                Type = PlanType.Daily
            };

            // تحويل كل مادة إلى PlannedSubject
            foreach (var s in subjects)
            {
                double hours = CalculateWeight(s, planDate) / totalWeight * studyHours;

                //  منع القيم الصغيرة جدًا (اللي بتبقى 0 بعد التقريب)
                if (hours < 0.1)
                    hours = 0.1;

                var planned = new PlannedSubject
                {
                    Name = s.Name,
                    Difficulty = s.Difficulty,
                    Priority = s.Priority,
                    ExamDate = s.ExamDate
                };

                // حساب الساعات
                planned.DailyHours = Math.Round(hours, 2);

                // reset
                planned.MorningHours = 0;
                planned.NightHours = 0;

                // توزيع
                if (planned.DailyHours <= 2)
                {
                    planned.MorningHours = planned.DailyHours;
                }
                else
                {
                    planned.MorningHours = Math.Round(planned.DailyHours * 0.5, 2);
                    planned.NightHours = Math.Round(planned.DailyHours - planned.MorningHours, 2);
                }

                plan.Subjects.Add(planned);
            }

            return plan;
        }
    }
}