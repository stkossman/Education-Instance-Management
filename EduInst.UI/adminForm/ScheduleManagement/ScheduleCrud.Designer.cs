namespace EduInst.PL.Schedule
{
    partial class ScheduleCrud
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
            btnCancelSchedule = new CustomControls.RoundButton();
            btnDelSchedule = new CustomControls.RoundButton();
            btnSaveSchedule = new CustomControls.RoundButton();
            lblScheduleTeacherChoose = new Label();
            cmbTeacherSchedule = new ComboBox();
            cmbScheduleSubjectChoose = new ComboBox();
            label1 = new Label();
            cmbScheduleGroupChoose = new ComboBox();
            label2 = new Label();
            cmbScheduleClassroomChoose = new ComboBox();
            label3 = new Label();
            dtpStartTimeDate = new DateTimePicker();
            dtpEndTimeDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpStartTimeTime = new DateTimePicker();
            dtpEndTimeTime = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCancelSchedule
            // 
            btnCancelSchedule.BackColor = Color.FromArgb(255, 192, 128);
            btnCancelSchedule.BorderColor = Color.FromArgb(94, 129, 244);
            btnCancelSchedule.BorderRadius = 40;
            btnCancelSchedule.BorderSize = 0;
            btnCancelSchedule.FlatAppearance.BorderSize = 0;
            btnCancelSchedule.FlatStyle = FlatStyle.Flat;
            btnCancelSchedule.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelSchedule.ForeColor = Color.White;
            btnCancelSchedule.Location = new Point(635, 309);
            btnCancelSchedule.Name = "btnCancelSchedule";
            btnCancelSchedule.Size = new Size(100, 40);
            btnCancelSchedule.TabIndex = 8;
            btnCancelSchedule.Text = "Cancel";
            btnCancelSchedule.UseVisualStyleBackColor = false;
            btnCancelSchedule.Click += btnCancelSchedule_Click;
            // 
            // btnDelSchedule
            // 
            btnDelSchedule.BackColor = Color.FromArgb(255, 128, 128);
            btnDelSchedule.BorderColor = Color.FromArgb(94, 129, 244);
            btnDelSchedule.BorderRadius = 40;
            btnDelSchedule.BorderSize = 0;
            btnDelSchedule.FlatAppearance.BorderSize = 0;
            btnDelSchedule.FlatStyle = FlatStyle.Flat;
            btnDelSchedule.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelSchedule.ForeColor = Color.White;
            btnDelSchedule.Location = new Point(111, 309);
            btnDelSchedule.Name = "btnDelSchedule";
            btnDelSchedule.Size = new Size(100, 40);
            btnDelSchedule.TabIndex = 9;
            btnDelSchedule.Text = "Delete";
            btnDelSchedule.UseVisualStyleBackColor = false;
            btnDelSchedule.Click += btnDelSchedule_Click;
            // 
            // btnSaveSchedule
            // 
            btnSaveSchedule.BackColor = Color.FromArgb(94, 129, 244);
            btnSaveSchedule.BorderColor = Color.FromArgb(94, 129, 244);
            btnSaveSchedule.BorderRadius = 40;
            btnSaveSchedule.BorderSize = 0;
            btnSaveSchedule.FlatAppearance.BorderSize = 0;
            btnSaveSchedule.FlatStyle = FlatStyle.Flat;
            btnSaveSchedule.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveSchedule.ForeColor = Color.White;
            btnSaveSchedule.Location = new Point(5, 309);
            btnSaveSchedule.Name = "btnSaveSchedule";
            btnSaveSchedule.Size = new Size(100, 40);
            btnSaveSchedule.TabIndex = 10;
            btnSaveSchedule.Text = "Save";
            btnSaveSchedule.UseVisualStyleBackColor = false;
            btnSaveSchedule.Click += btnSaveSchedule_Click;
            // 
            // lblScheduleTeacherChoose
            // 
            lblScheduleTeacherChoose.AutoSize = true;
            lblScheduleTeacherChoose.BackColor = Color.FromArgb(94, 129, 244);
            lblScheduleTeacherChoose.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScheduleTeacherChoose.Location = new Point(12, 27);
            lblScheduleTeacherChoose.Margin = new Padding(0);
            lblScheduleTeacherChoose.Name = "lblScheduleTeacherChoose";
            lblScheduleTeacherChoose.Size = new Size(109, 16);
            lblScheduleTeacherChoose.TabIndex = 45;
            lblScheduleTeacherChoose.Text = "Choose Teacher*";
            // 
            // cmbTeacherSchedule
            // 
            cmbTeacherSchedule.FormattingEnabled = true;
            cmbTeacherSchedule.Location = new Point(5, 46);
            cmbTeacherSchedule.Name = "cmbTeacherSchedule";
            cmbTeacherSchedule.Size = new Size(730, 23);
            cmbTeacherSchedule.TabIndex = 46;
            // 
            // cmbScheduleSubjectChoose
            // 
            cmbScheduleSubjectChoose.FormattingEnabled = true;
            cmbScheduleSubjectChoose.Location = new Point(5, 91);
            cmbScheduleSubjectChoose.Name = "cmbScheduleSubjectChoose";
            cmbScheduleSubjectChoose.Size = new Size(730, 23);
            cmbScheduleSubjectChoose.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(94, 129, 244);
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 72);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(106, 16);
            label1.TabIndex = 45;
            label1.Text = "Choose Subject*";
            // 
            // cmbScheduleGroupChoose
            // 
            cmbScheduleGroupChoose.FormattingEnabled = true;
            cmbScheduleGroupChoose.Location = new Point(5, 136);
            cmbScheduleGroupChoose.Name = "cmbScheduleGroupChoose";
            cmbScheduleGroupChoose.Size = new Size(730, 23);
            cmbScheduleGroupChoose.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(94, 129, 244);
            label2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 117);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 45;
            label2.Text = "Choose Group*";
            // 
            // cmbScheduleClassroomChoose
            // 
            cmbScheduleClassroomChoose.FormattingEnabled = true;
            cmbScheduleClassroomChoose.Location = new Point(5, 181);
            cmbScheduleClassroomChoose.Name = "cmbScheduleClassroomChoose";
            cmbScheduleClassroomChoose.Size = new Size(730, 23);
            cmbScheduleClassroomChoose.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(94, 129, 244);
            label3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 162);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(124, 16);
            label3.TabIndex = 45;
            label3.Text = "Choose Classroom*";
            // 
            // dtpStartTimeDate
            // 
            dtpStartTimeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpStartTimeDate.Location = new Point(5, 226);
            dtpStartTimeDate.Name = "dtpStartTimeDate";
            dtpStartTimeDate.Size = new Size(360, 23);
            dtpStartTimeDate.TabIndex = 47;
            // 
            // dtpEndTimeDate
            // 
            dtpEndTimeDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpEndTimeDate.Location = new Point(5, 280);
            dtpEndTimeDate.Name = "dtpEndTimeDate";
            dtpEndTimeDate.Size = new Size(360, 23);
            dtpEndTimeDate.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(94, 129, 244);
            label4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 207);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(123, 16);
            label4.TabIndex = 45;
            label4.Text = "Choose Start Time*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(94, 129, 244);
            label5.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 261);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(115, 16);
            label5.TabIndex = 45;
            label5.Text = "Choose End Time*";
            // 
            // dtpStartTimeTime
            // 
            dtpStartTimeTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpStartTimeTime.Location = new Point(375, 226);
            dtpStartTimeTime.Name = "dtpStartTimeTime";
            dtpStartTimeTime.Size = new Size(360, 23);
            dtpStartTimeTime.TabIndex = 47;
            // 
            // dtpEndTimeTime
            // 
            dtpEndTimeTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpEndTimeTime.Location = new Point(375, 280);
            dtpEndTimeTime.Name = "dtpEndTimeTime";
            dtpEndTimeTime.Size = new Size(360, 23);
            dtpEndTimeTime.TabIndex = 47;
            // 
            // ScheduleCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 361);
            Controls.Add(dtpEndTimeTime);
            Controls.Add(dtpEndTimeDate);
            Controls.Add(dtpStartTimeTime);
            Controls.Add(dtpStartTimeDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblScheduleTeacherChoose);
            Controls.Add(cmbScheduleClassroomChoose);
            Controls.Add(cmbScheduleGroupChoose);
            Controls.Add(cmbScheduleSubjectChoose);
            Controls.Add(cmbTeacherSchedule);
            Controls.Add(btnCancelSchedule);
            Controls.Add(btnDelSchedule);
            Controls.Add(btnSaveSchedule);
            Name = "ScheduleCrud";
            Text = "Schedule Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnCancelSchedule;
        private CustomControls.RoundButton btnDelSchedule;
        private CustomControls.RoundButton btnSaveSchedule;
        private Label lblScheduleTeacherChoose;
        private ComboBox cmbTeacherSchedule;
        private ComboBox cmbScheduleSubjectChoose;
        private Label label1;
        private ComboBox cmbScheduleGroupChoose;
        private Label label2;
        private ComboBox cmbScheduleClassroomChoose;
        private Label label3;
        private DateTimePicker dtpStartTimeDate;
        private DateTimePicker dtpEndTimeDate;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpStartTimeTime;
        private DateTimePicker dtpEndTimeTime;
    }
}