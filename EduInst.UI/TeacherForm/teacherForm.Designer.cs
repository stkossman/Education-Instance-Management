namespace EduInst.PL.TeacherForm
{
    partial class teacherForm
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
            btnDashboard = new Button();
            btnLoadData = new Button();
            btnLogOut = new Button();
            btnSchedule = new Button();
            btnStudents = new Button();
            pnlDashboard = new DashboardControl();
            pnlStudents = new StudentsControl();
            pnlGroups = new GroupsControl();
            lblUniversity = new Label();
            leftPanel = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnGroups = new Button();
            pnlSchedule = new Schedule.ScheduleControl();
            topPanel = new Panel();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(246, 247, 251);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(246, 247, 251);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 63);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(182, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseLeave += btnDashboard_MouseLeave;
            btnDashboard.MouseHover += btnDashboard_MouseHover;
            // 
            // btnLoadData
            // 
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadData.Image = Properties.Resources.loaddata;
            btnLoadData.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadData.Location = new Point(0, 576);
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
            btnLogOut.Location = new Point(0, 614);
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
            btnSchedule.Location = new Point(3, 180);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(182, 42);
            btnSchedule.TabIndex = 1;
            btnSchedule.Text = "Schedule";
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            btnSchedule.MouseLeave += btnSchedule_MouseLeave;
            btnSchedule.MouseHover += btnSchedule_MouseHover;
            // 
            // btnStudents
            // 
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Image = Properties.Resources.students;
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(3, 141);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(182, 42);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            btnStudents.MouseLeave += btnStudents_MouseLeave;
            btnStudents.MouseHover += btnStudents_MouseHover;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Location = new Point(192, 65);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(844, 593);
            pnlDashboard.TabIndex = 14;
            // 
            // pnlStudents
            // 
            pnlStudents.Location = new Point(192, 68);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(844, 593);
            pnlStudents.TabIndex = 13;
            // 
            // pnlGroups
            // 
            pnlGroups.BackColor = Color.FromArgb(246, 247, 251);
            pnlGroups.Location = new Point(192, 65);
            pnlGroups.Name = "pnlGroups";
            pnlGroups.Size = new Size(844, 593);
            pnlGroups.TabIndex = 11;
            // 
            // lblUniversity
            // 
            lblUniversity.AutoSize = true;
            lblUniversity.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUniversity.Location = new Point(634, 20);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(198, 29);
            lblUniversity.TabIndex = 1;
            lblUniversity.Text = "Ostroh Academy";
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(label1);
            leftPanel.Controls.Add(btnDashboard);
            leftPanel.Controls.Add(btnLoadData);
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(btnLogOut);
            leftPanel.Controls.Add(btnSchedule);
            leftPanel.Controls.Add(btnStudents);
            leftPanel.Controls.Add(btnGroups);
            leftPanel.Location = new Point(0, 2);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(195, 656);
            leftPanel.TabIndex = 9;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 64);
            label1.TabIndex = 2;
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
            // btnGroups
            // 
            btnGroups.FlatAppearance.BorderSize = 0;
            btnGroups.FlatAppearance.MouseDownBackColor = Color.White;
            btnGroups.FlatAppearance.MouseOverBackColor = Color.White;
            btnGroups.FlatStyle = FlatStyle.Flat;
            btnGroups.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGroups.Image = Properties.Resources.groups;
            btnGroups.ImageAlign = ContentAlignment.MiddleLeft;
            btnGroups.Location = new Point(3, 102);
            btnGroups.Name = "btnGroups";
            btnGroups.Size = new Size(182, 42);
            btnGroups.TabIndex = 1;
            btnGroups.Text = "Groups";
            btnGroups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGroups.UseVisualStyleBackColor = true;
            btnGroups.Click += btnGroups_Click;
            btnGroups.MouseLeave += btnGroups_MouseLeave;
            btnGroups.MouseHover += btnGroups_MouseHover;
            // 
            // pnlSchedule
            // 
            pnlSchedule.Location = new Point(192, 65);
            pnlSchedule.Name = "pnlSchedule";
            pnlSchedule.Size = new Size(844, 593);
            pnlSchedule.TabIndex = 16;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(lblUniversity);
            topPanel.Location = new Point(192, -1);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(844, 66);
            topPanel.TabIndex = 10;
            topPanel.Paint += topPanel_Paint;
            // 
            // teacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 661);
            Controls.Add(topPanel);
            Controls.Add(leftPanel);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlGroups);
            Controls.Add(pnlSchedule);
            Name = "teacherForm";
            Text = "teacherForm";
            Load += teacherForm_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDashboard;
        private Button btnLoadData;
        private Button btnLogOut;
        private Button btnSchedule;
        private Button btnStudents;
        private DashboardControl pnlDashboard;
        private StudentsControl pnlStudents;
        private GroupsControl pnlGroups;
        private Label lblUniversity;
        private Panel leftPanel;
        private Button btnGroups;
        private Schedule.ScheduleControl pnlSchedule;
        private PictureBox pictureBox1;
        private Panel topPanel;
        private Label label1;
    }
}