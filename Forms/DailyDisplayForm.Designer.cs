
namespace Study_Planner
{
    partial class DailyDisplayForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyDisplayForm));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            StartDate = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDifficulty = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colExamDate = new DataGridViewTextBoxColumn();
            TimeSlot = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(412, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 54);
            label1.TabIndex = 1;
            label1.Text = "Your Study Plan";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(128, 128, 255);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StartDate, colName, colDifficulty, colPriority, colExamDate, TimeSlot });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1145, 392);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.up_arrow4;
            pictureBox2.Location = new Point(0, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBoxBack_Click;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Date";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            StartDate.Resizable = DataGridViewTriState.False;
            // 
            // colName
            // 
            colName.HeaderText = "Subject Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Resizable = DataGridViewTriState.False;
            // 
            // colDifficulty
            // 
            colDifficulty.HeaderText = "Difficulty";
            colDifficulty.MinimumWidth = 6;
            colDifficulty.Name = "colDifficulty";
            colDifficulty.ReadOnly = true;
            colDifficulty.Resizable = DataGridViewTriState.False;
            colDifficulty.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPriority
            // 
            colPriority.HeaderText = "Priority";
            colPriority.MinimumWidth = 6;
            colPriority.Name = "colPriority";
            colPriority.ReadOnly = true;
            colPriority.Resizable = DataGridViewTriState.False;
            colPriority.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colExamDate
            // 
            colExamDate.HeaderText = "Exam Date";
            colExamDate.MinimumWidth = 6;
            colExamDate.Name = "colExamDate";
            colExamDate.ReadOnly = true;
            colExamDate.Resizable = DataGridViewTriState.False;
            // 
            // TimeSlot
            // 
            TimeSlot.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeSlot.HeaderText = "Time";
            TimeSlot.MinimumWidth = 6;
            TimeSlot.Name = "TimeSlot";
            TimeSlot.ReadOnly = true;
            // 
            // DailyDisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1147, 463);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "DailyDisplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily Display";
            Load += DisplayForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDifficulty;
        private DataGridViewTextBoxColumn colPriority;
        private DataGridViewTextBoxColumn colExamDate;
        private DataGridViewTextBoxColumn TimeSlot;
    }
}