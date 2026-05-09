using System;
using System.Collections.Generic;

namespace Study_Planner.Models
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public int ID { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // كل الخطط اللي المستخدم عملها
        public List<Plan> Plans { get; set; } = new List<Plan>();
    }
}