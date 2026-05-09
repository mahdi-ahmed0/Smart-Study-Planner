using System;
using System.Collections.Generic;
using System.Text;

namespace Study_Planner.Models
{
    public enum DifficultyLevel
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }

    public enum PriorityLevel
    {
        Low = 1,
        Medium = 2,
        High = 3
    }

    public class Subject
    {
        public string Name { get; set; }

        // عدد ساعات المادة (اللي المستخدم دخلها)
        public double Hours { get; set; }

        public DifficultyLevel Difficulty { get; set; }

        public PriorityLevel Priority { get; set; }

        public DateTime ExamDate { get; set; }

        // القيم اللي هتتحسب
        public double Weight { get; set; }       // وزن المادة
    }
}