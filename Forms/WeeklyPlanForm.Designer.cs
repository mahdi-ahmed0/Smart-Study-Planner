
namespace Study_Planner
{
    partial class WeeklyPlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklyPlanForm));
            txtSubject = new TextBox();
            txtHours = new TextBox();
            btnAdd = new Button();
            btnGenerate = new Button();
            cmbDifficulty = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            dtpExamDate = new DateTimePicker();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            pictureBox8 = new PictureBox();
            label12 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label13 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(94, 80);
            txtSubject.Margin = new Padding(4, 5, 4, 5);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(257, 30);
            txtSubject.TabIndex = 0;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(121, 167);
            txtHours.Margin = new Padding(4, 5, 4, 5);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(257, 30);
            txtHours.TabIndex = 1;
            txtHours.TextChanged += txtHours_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(371, 117);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Subject";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(371, 193);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(128, 32);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(94, 150);
            cmbDifficulty.Margin = new Padding(4, 5, 4, 5);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(257, 31);
            cmbDifficulty.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 5;
            label1.Text = "Subject Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 6;
            label2.Text = "Study Hours";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 7;
            label3.Text = "Difficulty";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.speedometer1;
            pictureBox1.Location = new Point(32, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alarm_clock2;
            pictureBox2.Location = new Point(59, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.open_book1;
            pictureBox3.Location = new Point(32, 56);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.GhostWhite;
            label7.Location = new Point(32, 112);
            label7.Name = "label7";
            label7.Size = new Size(319, 2);
            label7.TabIndex = 22;
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.GhostWhite;
            label4.Location = new Point(32, 180);
            label4.Name = "label4";
            label4.Size = new Size(319, 2);
            label4.TabIndex = 23;
            // 
            // label5
            // 
            label5.BackColor = Color.GhostWhite;
            label5.Location = new Point(59, 197);
            label5.Name = "label5";
            label5.Size = new Size(319, 2);
            label5.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(403, 12);
            label6.Name = "label6";
            label6.Size = new Size(219, 54);
            label6.TabIndex = 25;
            label6.Text = "Make Plan";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.up_arrow;
            pictureBox5.Location = new Point(2, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // dtpExamDate
            // 
            dtpExamDate.Location = new Point(94, 304);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(257, 30);
            dtpExamDate.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(94, 278);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 23);
            label9.TabIndex = 29;
            label9.Text = "ExamDate";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.deadline;
            pictureBox4.Location = new Point(33, 278);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.BackColor = Color.GhostWhite;
            label8.Location = new Point(33, 334);
            label8.Name = "label8";
            label8.Size = new Size(319, 2);
            label8.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox1.Location = new Point(94, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 31);
            comboBox1.TabIndex = 2;
            // 
            // label10
            // 
            label10.BackColor = Color.GhostWhite;
            label10.Location = new Point(33, 257);
            label10.Name = "label10";
            label10.Size = new Size(319, 2);
            label10.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(94, 200);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(73, 23);
            label11.TabIndex = 34;
            label11.Text = "Priority";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.badge;
            pictureBox6.Location = new Point(33, 203);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(371, 265);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(128, 32);
            button1.TabIndex = 5;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.calendar;
            pictureBox8.Location = new Point(59, 70);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(56, 51);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 46;
            pictureBox8.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(120, 68);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(50, 23);
            label12.TabIndex = 44;
            label12.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 30);
            dateTimePicker1.TabIndex = 0;
            // 
            // label13
            // 
            label13.BackColor = Color.GhostWhite;
            label13.Location = new Point(59, 124);
            label13.Name = "label13";
            label13.Size = new Size(319, 2);
            label13.TabIndex = 47;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHours);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(34, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Study Settings";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbDifficulty);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(btnGenerate);
            groupBox2.Controls.Add(dtpExamDate);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtSubject);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(534, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 354);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Subject Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // WeeklyPlanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1180, 458);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox5);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "WeeklyPlanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weekly Plan";
            Load += DailyPlanForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox5;
        private DateTimePicker dtpExamDate;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label8;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox6;
        private Button button1;
        private PictureBox pictureBox8;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private Label label13;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}