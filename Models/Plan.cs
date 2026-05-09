using System;
using System.Collections.Generic;

namespace Study_Planner.Models
{
    // يمثل خطة (يومي أو أسبوعي)
    public class Plan
    {
        public DateTime CreatedDate { get; set; } // تاريخ إنشاء الخطة

        public DateTime StartDate { get; set; }   // بداية الجدول

        public double StudyHoursPerDay { get; set; } // ساعات اليوم

        public enum PlanType
        {
            Daily,
            Weekly
        }

        public PlanType Type { get; set; }

        // المواد بعد الحساب والتوزيع
        public List<PlannedSubject> Subjects { get; set; } = new List<PlannedSubject>();
    }
}
