using System;
using System.Collections.Generic;
using System.Linq;
using Study_Planner.Models;

namespace Study_Planner.Logic
{
    // Base Class فيه كل الحسابات المشتركة
    public abstract class PlannerBase
    {
        // حساب وزن المادة
        protected double CalculateWeight(Subject subject, DateTime planDate)
        {
            // فرق الأيام بين اليوم وتاريخ الامتحان
            int daysLeft = (subject.ExamDate - planDate).Days;

            if (daysLeft <= 0)
                daysLeft = 1; // حماية من القسمة على صفر

            // الوزن = (الساعات * الصعوبة * الأهمية) / قرب الامتحان
            double weight = (subject.Hours *
                            (int)subject.Difficulty *
                            (int)subject.Priority) / daysLeft;

            return weight;
        }

        // توزيع ساعات اليوم على (صباح - مساء - ليل)
        protected void SplitDay(double hours, out double morning, out double evening, out double night)
        {
            morning = hours * 0.4;
            evening = hours * 0.35;
            night = hours * 0.25;
        }

        // إنشاء PlannedSubject من Subject
        protected PlannedSubject ConvertToPlanned(Subject subject, double totalWeight, double studyHours, DateTime planDate)
        {
            double weight = CalculateWeight(subject, planDate);

            // نسبة المادة من إجمالي الوزن
            double ratio = weight / totalWeight;

            // عدد الساعات المخصصة ليها في اليوم
            double dailyHours = ratio * studyHours;

            // تقسيم اليوم
            SplitDay(dailyHours, out double m, out double e, out double n);

            return new PlannedSubject
            {
                Name = subject.Name,
                TotalHours = subject.Hours,
                DailyHours = dailyHours,
                MorningHours = m,
                EveningHours = e,
                NightHours = n,
                ExamDate = subject.ExamDate,
                Difficulty = subject.Difficulty,
                Priority = subject.Priority,
                Weight = weight
            };
        }
    }
}