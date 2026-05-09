namespace Study_Planner
{
    partial class WeeklyDisplayForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeklyDisplayForm));
            dataGridView1 = new DataGridView();
            Day = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDifficulty = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colExamDate = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Day, colName, colDifficulty, colPriority, colExamDate, Time });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(-1, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1073, 419);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Day
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            Day.DefaultCellStyle = dataGridViewCellStyle2;
            Day.HeaderText = "Day";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            Day.ReadOnly = true;
            // 
            // colName
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            colName.DefaultCellStyle = dataGridViewCellStyle3;
            colName.HeaderText = "Subject Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDifficulty
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.ForeColor = Color.White;
            colDifficulty.DefaultCellStyle = dataGridViewCellStyle4;
            colDifficulty.HeaderText = "Difficulty";
            colDifficulty.MinimumWidth = 6;
            colDifficulty.Name = "colDifficulty";
            colDifficulty.ReadOnly = true;
            colDifficulty.Resizable = DataGridViewTriState.True;
            colDifficulty.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPriority
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            colPriority.DefaultCellStyle = dataGridViewCellStyle5;
            colPriority.HeaderText = "Priority";
            colPriority.MinimumWidth = 6;
            colPriority.Name = "colPriority";
            colPriority.ReadOnly = true;
            colPriority.Resizable = DataGridViewTriState.True;
            colPriority.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colExamDate
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            colExamDate.DefaultCellStyle = dataGridViewCellStyle6;
            colExamDate.HeaderText = "Exam Date";
            colExamDate.MinimumWidth = 6;
            colExamDate.Name = "colExamDate";
            colExamDate.ReadOnly = true;
            // 
            // Time
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            Time.DefaultCellStyle = dataGridViewCellStyle7;
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(374, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 54);
            label1.TabIndex = 7;
            label1.Text = "Your Study Plan";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.up_arrow;
            pictureBox5.Location = new Point(-1, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 40;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // WeeklyDisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1075, 497);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WeeklyDisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weekly Display";
            Load += WeeklyDisplayForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox5;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDifficulty;
        private DataGridViewTextBoxColumn colPriority;
        private DataGridViewTextBoxColumn colExamDate;
        private DataGridViewTextBoxColumn Time;
    }
}