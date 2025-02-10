namespace EduInst.PL.StudentForm
{
    partial class studentForm
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
            topPanel = new Panel();
            lblUniversity = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLoadData = new Button();
            btnLogOut = new Button();
            btnSchedule = new Button();
            leftPanel = new Panel();
            pnlScheduleStudent = new CustomControls.ScheduleControlStudent();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblUniversity);
            topPanel.Location = new Point(192, -1);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(844, 66);
            topPanel.TabIndex = 18;
            topPanel.Paint += topPanel_Paint;
            // 
            // lblUniversity
            // 
            lblUniversity.AutoSize = true;
            lblUniversity.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUniversity.Location = new Point(634, 22);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(198, 29);
            lblUniversity.TabIndex = 1;
            lblUniversity.Text = "Ostroh Academy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, -1);
            label1.Name = "label1";
            label1.Size = new Size(84, 64);
            label1.TabIndex = 1;
            label1.Text = "Kossman's\r\nEducation\r\nInstance\r\nManagement";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_linux;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLoadData
            // 
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadData.Image = Properties.Resources.loaddata;
            btnLoadData.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadData.Location = new Point(0, 578);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(185, 42);
            btnLoadData.TabIndex = 1;
            btnLoadData.Text = "Load Data";
            btnLoadData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            btnLoadData.MouseLeave += btnLoadData_MouseLeave;
            btnLoadData.MouseHover += btnLoadData_MouseHover;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Image = Properties.Resources.logout;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 617);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(185, 42);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            btnLogOut.MouseLeave += btnLogOut_MouseLeave;
            btnLogOut.MouseHover += btnLogOut_MouseHover;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSchedule.Image = Properties.Resources.schedule;
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(0, 69);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(185, 42);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "Schedule";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            btnSchedule.MouseLeave += btnSchedule_MouseLeave;
            btnSchedule.MouseHover += btnSchedule_MouseHover;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(label1);
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(btnLoadData);
            leftPanel.Controls.Add(btnLogOut);
            leftPanel.Controls.Add(btnSchedule);
            leftPanel.Location = new Point(0, -1);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(195, 659);
            leftPanel.TabIndex = 17;
            // 
            // pnlScheduleStudent
            // 
            pnlScheduleStudent.Location = new Point(192, 65);
            pnlScheduleStudent.Name = "pnlScheduleStudent";
            pnlScheduleStudent.Size = new Size(844, 593);
            pnlScheduleStudent.TabIndex = 22;
            // 
            // studentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 661);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            Controls.Add(pnlScheduleStudent);
            Name = "studentForm";
            Text = "studentForm";
            Load += studentForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label label1;
        private Label lblUniversity;
        private PictureBox pictureBox1;
        private Button btnLoadData;
        private Button btnLogOut;
        private Button btnSchedule;
        private Panel leftPanel;
        private CustomControls.ScheduleControlStudent pnlScheduleStudent;
    }
}