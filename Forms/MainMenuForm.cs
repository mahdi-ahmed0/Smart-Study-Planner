using Study_Planner.Data;
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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnWeeklyOld_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)

        {
            var dm = new DataManager();

            var plan = dm.LoadLastDailyPlan(SessionManager.CurrentUser.ID);

            if (plan == null)
            {
                MessageBox.Show("No saved daily plan found");
                return;
            }

            DailyDisplayForm form = new DailyDisplayForm(plan);
            form.Show();

            this.Hide();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WeeklyPlanForm newWeeklyPage = new WeeklyPlanForm();
            newWeeklyPage.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DailyPlanForm newDailyPlan = new DailyPlanForm();
            newDailyPlan.Show();
            this.Hide();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var dm = new DataManager();

            var plans = dm.LoadWeeklyPlans(SessionManager.CurrentUser.ID);

            if (plans == null || plans.Count == 0)
            {
                MessageBox.Show("No saved weekly plan found");
                return;
            }

            WeeklyDisplayForm form = new WeeklyDisplayForm(plans);
            form.Show();

            this.Hide();
        }
    }
}
    
