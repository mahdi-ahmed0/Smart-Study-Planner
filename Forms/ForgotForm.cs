using Study_Planner.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Planner
{
    public partial class ForgotForm : Form
    {
        private DataManager dataManager = new DataManager();
        public ForgotForm()
        {
            InitializeComponent();
        }

        private void ForgotForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID");
                return;
            }
            
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // تحقق من الباسورد
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            // تحقق من المستخدم

            var user = dataManager.GetUserByIdAndEmail(id, email);

            if (user == null)
            {
                MessageBox.Show("User not found");
                return;
            }
            string name = user.Name;

            // تحديث الباسورد
            bool updated = dataManager.UpdatePassword(id, name,email, newPassword);

            if (updated) { 
            MessageBox.Show("Password updated successfully ✅");
            LoginForm login = new LoginForm();
            login.Show();
            this.Close(); }
            else
                MessageBox.Show("Error updating password ❌");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
