namespace EduInst.UI
{
    partial class adminForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            leftPanel = new Panel();
            btnDashboard = new Button();
            btnClassrooms = new Button();
            btnLoadData = new Button();
            btnLogOut = new Button();
            btnSchedule = new Button();
            btnEmployees = new Button();
            btnStudents = new Button();
            btnSubjects = new Button();
            btnGroups = new Button();
            topPanel = new Panel();
            label1 = new Label();
            lblUniversity = new Label();
            pictureBox1 = new PictureBox();
            pnlGroups = new PL.GroupsControl();
            pnlSubjects = new PL.SubjectsControl();
            pnlStudents = new PL.StudentsControl();
            pnlDashboard = new PL.DashboardControl();
            pnlEmployees = new PL.EmployeesControl();
            pnlSchedule = new PL.Schedule.ScheduleControl();
            pnlClassrooms = new PL.ClassroomsControl();
            leftPanel.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.White;
            leftPanel.Controls.Add(btnDashboard);
            leftPanel.Controls.Add(btnClassrooms);
            leftPanel.Controls.Add(btnLoadData);
            leftPanel.Controls.Add(btnLogOut);
            leftPanel.Controls.Add(btnSchedule);
            leftPanel.Controls.Add(btnEmployees);
            leftPanel.Controls.Add(btnStudents);
            leftPanel.Controls.Add(btnSubjects);
            leftPanel.Controls.Add(btnGroups);
            leftPanel.Location = new Point(0, 67);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(195, 593);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(246, 247, 251);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(246, 247, 251);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Image = PL.Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(185, 42);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseLeave += btnDashboard_MouseLeave;
            btnDashboard.MouseHover += btnDashboard_MouseHover;
            // 
            // btnClassrooms
            // 
            btnClassrooms.FlatAppearance.BorderSize = 0;
            btnClassrooms.FlatStyle = FlatStyle.Flat;
            btnClassrooms.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClassrooms.Image = PL.Properties.Resources.classroom;
            btnClassrooms.ImageAlign = ContentAlignment.MiddleLeft;
            btnClassrooms.Location = new Point(0, 235);
            btnClassrooms.Name = "btnClassrooms";
            btnClassrooms.Size = new Size(185, 42);
            btnClassrooms.TabIndex = 1;
            btnClassrooms.Text = "Classrooms";
            btnClassrooms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClassrooms.UseVisualStyleBackColor = true;
            btnClassrooms.Click += btnClassrooms_Click;
            btnClassrooms.MouseLeave += btnClassrooms_MouseLeave;
            btnClassrooms.MouseHover += btnClassrooms_MouseHover;
            // 
            // btnLoadData
            // 
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadData.Image = PL.Properties.Resources.loaddata;
            btnLoadData.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadData.Location = new Point(0, 503);
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
            btnLogOut.Image = PL.Properties.Resources.logout;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 551);
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
            btnSchedule.Image = PL.Properties.Resources.schedule;
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(0, 196);
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
            // btnEmployees
            // 
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployees.Image = PL.Properties.Resources.employees;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 157);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(185, 42);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Teachers";
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            btnEmployees.MouseLeave += btnEmployees_MouseLeave;
            btnEmployees.MouseHover += btnEmployees_MouseHover;
            // 
            // btnStudents
            // 
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Image = PL.Properties.Resources.students;
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(0, 120);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(185, 42);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            btnStudents.MouseLeave += btnStudents_MouseLeave;
            btnStudents.MouseHover += btnStudents_MouseHover;
            // 
            // btnSubjects
            // 
            btnSubjects.FlatAppearance.BorderSize = 0;
            btnSubjects.FlatStyle = FlatStyle.Flat;
            btnSubjects.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubjects.Image = PL.Properties.Resources.subjects;
            btnSubjects.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubjects.Location = new Point(0, 81);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(185, 42);
            btnSubjects.TabIndex = 1;
            btnSubjects.Text = "Subjects";
            btnSubjects.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            btnSubjects.MouseLeave += btnSubjects_MouseLeave;
            btnSubjects.MouseHover += btnSubjects_MouseHover;
            // 
            // btnGroups
            // 
            btnGroups.FlatAppearance.BorderSize = 0;
            btnGroups.FlatAppearance.MouseDownBackColor = Color.White;
            btnGroups.FlatAppearance.MouseOverBackColor = Color.White;
            btnGroups.FlatStyle = FlatStyle.Flat;
            btnGroups.Font = new Font("SF Pro Display", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGroups.Image = PL.Properties.Resources.groups;
            btnGroups.ImageAlign = ContentAlignment.MiddleLeft;
            btnGroups.Location = new Point(0, 42);
            btnGroups.Name = "btnGroups";
            btnGroups.Size = new Size(185, 42);
            btnGroups.TabIndex = 1;
            btnGroups.Text = "Groups";
            btnGroups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGroups.UseVisualStyleBackColor = true;
            btnGroups.Click += btnGroups_Click;
            btnGroups.MouseLeave += btnGroups_MouseLeave;
            btnGroups.MouseHover += btnGroups_MouseHover;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(lblUniversity);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Location = new Point(0, 1);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1036, 66);
            topPanel.TabIndex = 1;
            topPanel.Paint += topPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 3);
            label1.Name = "label1";
            label1.Size = new Size(149, 57);
            label1.TabIndex = 1;
            label1.Text = "Kossman's\r\nEducation Instance\r\nManagement\r\n";
            // 
            // lblUniversity
            // 
            lblUniversity.AutoSize = true;
            lblUniversity.Font = new Font("SF Pro Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUniversity.Location = new Point(826, 20);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(198, 29);
            lblUniversity.TabIndex = 1;
            lblUniversity.Text = "Ostroh Academy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PL.Properties.Resources.logo_linux;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlGroups
            // 
            pnlGroups.BackColor = Color.FromArgb(246, 247, 251);
            pnlGroups.Location = new Point(192, 67);
            pnlGroups.Name = "pnlGroups";
            pnlGroups.Size = new Size(844, 593);
            pnlGroups.TabIndex = 2;
            // 
            // pnlSubjects
            // 
            pnlSubjects.Location = new Point(192, 70);
            pnlSubjects.Name = "pnlSubjects";
            pnlSubjects.Size = new Size(844, 593);
            pnlSubjects.TabIndex = 3;
            // 
            // pnlStudents
            // 
            pnlStudents.Location = new Point(192, 70);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(844, 593);
            pnlStudents.TabIndex = 4;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Location = new Point(192, 67);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(844, 593);
            pnlDashboard.TabIndex = 5;
            // 
            // pnlEmployees
            // 
            pnlEmployees.Location = new Point(192, 67);
            pnlEmployees.Name = "pnlEmployees";
            pnlEmployees.Size = new Size(844, 593);
            pnlEmployees.TabIndex = 6;
            // 
            // pnlSchedule
            // 
            pnlSchedule.Location = new Point(192, 67);
            pnlSchedule.Name = "pnlSchedule";
            pnlSchedule.Size = new Size(844, 593);
            pnlSchedule.TabIndex = 7;
            // 
            // pnlClassrooms
            // 
            pnlClassrooms.Location = new Point(192, 67);
            pnlClassrooms.Name = "pnlClassrooms";
            pnlClassrooms.Size = new Size(844, 593);
            pnlClassrooms.TabIndex = 8;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            ClientSize = new Size(1036, 661);
            Controls.Add(leftPanel);
            Controls.Add(topPanel);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlSubjects);
            Controls.Add(pnlGroups);
            Controls.Add(pnlEmployees);
            Controls.Add(pnlSchedule);
            Controls.Add(pnlClassrooms);
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Form";
            Load += MainForm_Load;
            leftPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel topPanel;
        private Button btnGroups;
        private Button btnDashboard;
        private Button btnSubjects;
        private Button btnEmployees;
        private Button btnStudents;
        private Button btnSchedule;
        private PL.GroupsControl pnlGroups;
        private PL.SubjectsControl pnlSubjects;
        private PL.StudentsControl pnlStudents;
        private PictureBox pictureBox1;
        private PL.DashboardControl pnlDashboard;
        private PL.EmployeesControl pnlEmployees;
        private PL.Schedule.ScheduleControl pnlSchedule;
        private Button btnClassrooms;
        private PL.ClassroomsControl pnlClassrooms;
        private Button btnLogOut;
        private Label label1;
        private Label lblUniversity;
        private Button btnLoadData;
    }
}
