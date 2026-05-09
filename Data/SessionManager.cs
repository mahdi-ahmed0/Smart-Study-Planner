using System;
using System.Collections.Generic;
using System.Text;

namespace Study_Planner.Data
{
    public static class SessionManager
    {
        //  المستخدم اللي عمل Login
        public static Models.User CurrentUser { get; set; }
    }
}
