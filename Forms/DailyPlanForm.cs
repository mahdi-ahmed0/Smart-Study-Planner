using Study_Planner.Data;
using Study_Planner.Logic;
using Study_Planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class DailyPlanForm : Form
    {
        // قائمة المواد اللي المستخدم بيضيفها
        private List<Subject> subjects = new List<Subject>();
        public DailyPlanForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DailyPlanForm_Load(object sender, EventArgs e)
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int hours;

            if (!int.TryParse(txtSubjectHours.Text, out hours))
            {
                MessageBox.Show("Enter valid hours");
                return;
            }

            Subject sub = new Subject();

            sub.Name = txtSubject.Text;
            sub.Hours = hours;
            sub.Difficulty = (DifficultyLevel)cmbDifficulty.SelectedIndex;
            sub.Priority = (PriorityLevel)comboBox1.SelectedIndex;
            sub.ExamDate = dtpexamdate.Value;

            subjects.Add(sub);

            MessageBox.Show("Subject Added Successfully");


            txtSubject.Clear();
            txtSubjectHours.Clear();
            cmbDifficulty.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // لازم يكون فيه مواد
                if (subjects.Count == 0)
                {
                    MessageBox.Show("Add subjects first");
                    return;
                }

                // قراءة عدد ساعات اليوم
                if (!double.TryParse(txtStudyHours.Text, out double studyHours))
                {
                    MessageBox.Show("Enter valid study hours");
                    return;
                }

                // إنشاء Plan (input)
                Plan plan = new Plan
                {
                    CreatedDate = DateTime.Now,
                    StartDate = dateTimePicker1.Value,
                    StudyHoursPerDay = studyHours,
                    Type = Plan.PlanType.Daily
                };

                // إرسال للـ Logic (هنا الحساب الحقيقي)
                DailyPlanner planner = new DailyPlanner();
                plan = planner.GeneratePlan(subjects, plan.StartDate, plan.StudyHoursPerDay);

                // عرض النتيجة
                DailyDisplayForm display = new DailyDisplayForm(plan);
                display.Show();

                // حفظ
                DataManager dm = new DataManager();
                dm.SaveDailyPlan(SessionManager.CurrentUser.ID, plan);

                // إخفاء الصفحة الحالية
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
