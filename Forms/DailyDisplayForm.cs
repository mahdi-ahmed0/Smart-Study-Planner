using Study_Planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class DailyDisplayForm : Form
    {
        // نخزن الخطة كاملة
        private Plan _plan;

        // Constructor يستقبل Plan
        public DailyDisplayForm(Plan plan)
        {
            InitializeComponent();
            _plan = plan;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            // مسح أي بيانات قديمة
            dataGridView1.Rows.Clear();

            // عرض كل مادة
            foreach (var s in _plan.Subjects)
            {
                double total = s.MorningHours + s.NightHours;

                dataGridView1.Rows.Add(
                    _plan.StartDate.ToString("dddd, dd MMM"),
                    s.Name,
                    s.Difficulty.ToString(),
                    s.Priority.ToString(),
                    s.ExamDate.ToShortDateString(),
                    $"{total:F2}h (M:{s.MorningHours:F2} / N:{s.NightHours:F2})"
                );
            }
        }

        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            MainMenuForm backToMenu = new MainMenuForm();
            backToMenu.Show();
            this.Close();
        }
    }
}
