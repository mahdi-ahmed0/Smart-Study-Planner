using Study_Planner.Data;
using Study_Planner.Logic;
using Study_Planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class WeeklyPlanForm : Form
    {
        private List<Subject> subjects = new List<Subject>();
        public WeeklyPlanForm()
        {
            InitializeComponent();
        }

        private void DailyPlanForm_Load(object sender, EventArgs e)
        {

        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("Enter subject name");
                return;
            }

            if (cmbDifficulty.SelectedIndex < 0 || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select difficulty and priority");
                return;
            }

            if (!double.TryParse(txtHours.Text, out double hours) || hours <= 0)
            {
                MessageBox.Show("Enter valid hours");
                return;
            }

            Subject sub = new Subject
            {
                Name = txtSubject.Text,
                Hours = hours,
                Difficulty = (DifficultyLevel)(cmbDifficulty.SelectedIndex + 1),
                Priority = (PriorityLevel)(comboBox1.SelectedIndex + 1),
                ExamDate = dtpExamDate.Value
            };

            subjects.Add(sub);

            MessageBox.Show("Subject Added ✅");

            txtSubject.Clear();
            cmbDifficulty.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (subjects.Count == 0)
            {
                MessageBox.Show("Add subjects first");
                return;
            }

            if (!double.TryParse(txtHours.Text, out double studyHours) || studyHours <= 0)
            {
                MessageBox.Show("Enter valid study hours");
                return;
            }

            DateTime startDate = dateTimePicker1.Value;

            // استدعاء اللوجيك
            WeeklyPlanner planner = new WeeklyPlanner();

            List<Plan> weekPlans = planner.GenerateWeeklyPlan(
                subjects,
                startDate,
                studyHours
            );

            if (weekPlans == null || weekPlans.Count == 0)
            {
                MessageBox.Show("Failed to generate plan");
                return;
            }

            // عرض النتيجة
            WeeklyDisplayForm display = new WeeklyDisplayForm(weekPlans);
            display.Show();

            // حفظ
            DataManager dm = new DataManager();
            dm.SaveWeeklyPlans(SessionManager.CurrentUser.ID, weekPlans);

            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete last subject?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                subjects.RemoveAt(subjects.Count - 1);
                MessageBox.Show("Last subject deleted successfully ✅");
            }
        }
    }
}
