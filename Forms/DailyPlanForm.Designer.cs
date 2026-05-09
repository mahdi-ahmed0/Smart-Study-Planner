namespace Study_Planner
{
    partial class DailyPlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlanForm));
            dtpexamdate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbDifficulty = new ComboBox();
            btnGenerate = new Button();
            btnAdd = new Button();
            txtSubjectHours = new TextBox();
            txtSubject = new TextBox();
            label5 = new Label();
            txtStudyHours = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpexamdate
            // 
            dtpexamdate.Location = new Point(117, 361);
            dtpexamdate.Name = "dtpexamdate";
            dtpexamdate.Size = new Size(250, 30);
            dtpexamdate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 18;
            label3.Text = "Difficulty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 17;
            label2.Text = "Subject Hours";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 16;
            label1.Text = "Subject Name";
            // 
            // cmbDifficulty
            // 
            cmbDifficulty.FormattingEnabled = true;
            cmbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cmbDifficulty.Location = new Point(117, 218);
            cmbDifficulty.Margin = new Padding(4, 5, 4, 5);
            cmbDifficulty.Name = "cmbDifficulty";
            cmbDifficulty.Size = new Size(188, 31);
            cmbDifficulty.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(324, 180);
            btnGenerate.Margin = new Padding(4, 5, 4, 5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(128, 33);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(324, 106);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Subject";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSubjectHours
            // 
            txtSubjectHours.Location = new Point(117, 145);
            txtSubjectHours.Margin = new Padding(4, 5, 4, 5);
            txtSubjectHours.Name = "txtSubjectHours";
            txtSubjectHours.Size = new Size(188, 30);
            txtSubjectHours.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(117, 71);
            txtSubject.Margin = new Padding(4, 5, 4, 5);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(188, 30);
            txtSubject.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 117);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 22;
            label5.Text = "Study Hours";
            // 
            // txtStudyHours
            // 
            txtStudyHours.Location = new Point(123, 144);
            txtStudyHours.Margin = new Padding(4, 5, 4, 5);
            txtStudyHours.Name = "txtStudyHours";
            txtStudyHours.Size = new Size(188, 30);
            txtStudyHours.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox1.Location = new Point(117, 291);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 31);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(123, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 30);
            dateTimePicker1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(117, 263);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 30;
            label6.Text = "Priority";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 335);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 31;
            label4.Text = "Exam Date";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.up_arrow;
            pictureBox5.Location = new Point(2, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(400, 12);
            label8.Name = "label8";
            label8.Size = new Size(219, 54);
            label8.TabIndex = 33;
            label8.Text = "Make Plan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(123, 44);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 23);
            label7.TabIndex = 34;
            label7.Text = "Date";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.open_book1;
            pictureBox3.Location = new Point(55, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alarm_clock2;
            pictureBox2.Location = new Point(61, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.speedometer1;
            pictureBox1.Location = new Point(55, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.badge;
            pictureBox6.Location = new Point(55, 268);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.deadline;
            pictureBox4.Location = new Point(56, 337);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.book;
            pictureBox7.Location = new Point(55, 121);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 51);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.calendar;
            pictureBox8.Location = new Point(62, 46);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(56, 51);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 41;
            pictureBox8.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStudyHours);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(55, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Study Settings";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSubjectHours);
            groupBox2.Controls.Add(txtSubject);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnGenerate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(dtpexamdate);
            groupBox2.Controls.Add(cmbDifficulty);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(528, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 407);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Subject Details";
            // 
            // DailyPlanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1101, 539);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(pictureBox5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DailyPlanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily Plan";
            Load += DailyPlanForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpexamdate;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbDifficulty;
        private Button btnGenerate;
        private Button btnAdd;
        private TextBox txtSubjectHours;
        private TextBox txtSubject;
        private Label label5;
        private TextBox txtStudyHours;
        private ComboBox comboBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}