using Study_Planner.Models;
using System;
using System.Collections.Generic;
using static Study_Planner.Models.Plan;

namespace Study_Planner.Logic
{
    public class WeeklyPlanner : PlannerBase
    {
        public List<Plan> GenerateWeeklyPlan(List<Subject> subjects, DateTime startDate, double studyHours)
        {
            List<Plan> week = new List<Plan>();

            // نعمل 7 أيام من تاريخ البداية
            for (int i = 0; i < 7; i++)
            {
                DateTime day = startDate.AddDays(i);

                DailyPlanner daily = new DailyPlanner();
                var plan = daily.GeneratePlan(subjects, day, studyHours);

                plan.Type = PlanType.Weekly;

                week.Add(plan);
            }

            return week;
        }
    }
}