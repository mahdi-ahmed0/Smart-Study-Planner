
namespace Study_Planner
{
    partial class ForgotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotForm));
            btnReset = new Button();
            txtID = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            txtNewPassword = new TextBox();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(256, 538);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(103, 43);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(135, 142);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(355, 27);
            txtID.TabIndex = 0;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(135, 333);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 7;
            label3.Text = "New Password ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 247);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(135, 470);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(355, 27);
            txtConfirmPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(135, 219);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 5;
            label1.Text = "Email ";
            label1.Click += label1_Click_1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(135, 361);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(355, 27);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(135, 442);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 8;
            label4.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(135, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 6;
            label2.Text = "Student ID ";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card;
            pictureBox1.Location = new Point(73, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.padlock;
            pictureBox2.Location = new Point(73, 337);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(73, 446);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.BackColor = Color.GhostWhite;
            label8.Location = new Point(73, 500);
            label8.Name = "label8";
            label8.Size = new Size(417, 2);
            label8.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(161, 19);
            label9.Name = "label9";
            label9.Size = new Size(316, 54);
            label9.TabIndex = 17;
            label9.Text = "Reset Password";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.up_arrow;
            pictureBox5.Location = new Point(2, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.GhostWhite;
            label5.Location = new Point(73, 393);
            label5.Name = "label5";
            label5.Size = new Size(417, 2);
            label5.TabIndex = 19;
            // 
            // label6
            // 
            label6.BackColor = Color.GhostWhite;
            label6.Location = new Point(73, 174);
            label6.Name = "label6";
            label6.Size = new Size(417, 2);
            label6.TabIndex = 20;
            // 
            // label7
            // 
            label7.BackColor = Color.GhostWhite;
            label7.Location = new Point(73, 279);
            label7.Name = "label7";
            label7.Size = new Size(417, 2);
            label7.TabIndex = 21;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.email;
            pictureBox4.Location = new Point(73, 225);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // ForgotForm
            // 
            AcceptButton = btnReset;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(615, 595);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtID);
            Controls.Add(txtEmail);
            Controls.Add(txtNewPassword);
            Controls.Add(label4);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnReset);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "ForgotForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot";
            Load += ForgotForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private TextBox txtID;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private Label label1;
        private TextBox txtNewPassword;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox4;
    }
}