using Study_Planner.Logic;
using Study_Planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class WeeklyDisplayForm : Form
    {
        // قائمة الأيام (كل يوم = Plan)
        private List<Plan> _weekPlans;

        public WeeklyDisplayForm(List<Plan> plans)
        {
            InitializeComponent();
            _weekPlans = plans;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainMenuForm Menu = new MainMenuForm();
            Menu.Show();
            this.Close();

        }
        private void WeeklyDisplayForm_Load_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double totalHours = 0;
            double totalMorning = 0;
            double totalNight = 0;
            int totalSubjects = 0;

            foreach (var plan in _weekPlans)
            {
                double dailyTotal = 0; // مجموع اليوم الواحد

                foreach (var s in plan.Subjects)
                {
                    double daily = s.MorningHours + s.NightHours;

                    // عرض البيانات في الجدول
                    dataGridView1.Rows.Add(
                        plan.StartDate.ToString("dddd, dd MMM"),
                        s.Name,
                        s.Difficulty,
                        s.Priority,
                        s.ExamDate.ToShortDateString(),
                        $"{daily:F2}h (M:{s.MorningHours:F2} / N:{s.NightHours:F2})"
                    );

                    dailyTotal += daily;

                    totalMorning += s.MorningHours;
                    totalNight += s.NightHours;
                    totalSubjects++;
                }

                // إجمالي اليوم يتضاف مرة واحدة بس
                totalHours += dailyTotal;
            }
        }



        private void rtbSummary_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

