namespace EduInst.PL.adminForm.ScheduleManagement
{
    partial class ScheduleDelete
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
            btnScheduleDeleteLesson = new CustomControls.RoundButton();
            lblEditGroup4 = new Label();
            lblEditGroup3 = new Label();
            label1 = new Label();
            lblEditGroup1 = new Label();
            cmbScheduleDeleteLesson = new ComboBox();
            SuspendLayout();
            // 
            // btnScheduleDeleteLesson
            // 
            btnScheduleDeleteLesson.BackColor = Color.FromArgb(255, 192, 128);
            btnScheduleDeleteLesson.BorderColor = Color.FromArgb(94, 129, 244);
            btnScheduleDeleteLesson.BorderRadius = 40;
            btnScheduleDeleteLesson.BorderSize = 0;
            btnScheduleDeleteLesson.FlatAppearance.BorderSize = 0;
            btnScheduleDeleteLesson.FlatStyle = FlatStyle.Flat;
            btnScheduleDeleteLesson.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScheduleDeleteLesson.ForeColor = Color.Black;
            btnScheduleDeleteLesson.Location = new Point(335, 85);
            btnScheduleDeleteLesson.Name = "btnScheduleDeleteLesson";
            btnScheduleDeleteLesson.Size = new Size(100, 40);
            btnScheduleDeleteLesson.TabIndex = 15;
            btnScheduleDeleteLesson.Text = "Delete";
            btnScheduleDeleteLesson.UseVisualStyleBackColor = false;
            btnScheduleDeleteLesson.Click += btnScheduleDeleteLesson_Click;
            // 
            // lblEditGroup4
            // 
            lblEditGroup4.AutoSize = true;
            lblEditGroup4.BackColor = Color.Silver;
            lblEditGroup4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditGroup4.Location = new Point(389, 33);
            lblEditGroup4.Name = "lblEditGroup4";
            lblEditGroup4.Size = new Size(55, 16);
            lblEditGroup4.TabIndex = 13;
            lblEditGroup4.Text = "Optional";
            // 
            // lblEditGroup3
            // 
            lblEditGroup3.AutoSize = true;
            lblEditGroup3.BackColor = Color.FromArgb(94, 129, 244);
            lblEditGroup3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditGroup3.Location = new Point(320, 33);
            lblEditGroup3.Name = "lblEditGroup3";
            lblEditGroup3.Size = new Size(63, 16);
            lblEditGroup3.TabIndex = 14;
            lblEditGroup3.Text = "Required*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(94, 129, 244);
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 33);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(103, 16);
            label1.TabIndex = 10;
            label1.Text = "Choose Lesson*";
            // 
            // lblEditGroup1
            // 
            lblEditGroup1.AutoSize = true;
            lblEditGroup1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditGroup1.Location = new Point(307, 8);
            lblEditGroup1.Margin = new Padding(0);
            lblEditGroup1.Name = "lblEditGroup1";
            lblEditGroup1.Size = new Size(148, 25);
            lblEditGroup1.TabIndex = 11;
            lblEditGroup1.Text = "Delete Lesson";
            // 
            // cmbScheduleDeleteLesson
            // 
            cmbScheduleDeleteLesson.FormattingEnabled = true;
            cmbScheduleDeleteLesson.Location = new Point(12, 52);
            cmbScheduleDeleteLesson.Name = "cmbScheduleDeleteLesson";
            cmbScheduleDeleteLesson.Size = new Size(730, 23);
            cmbScheduleDeleteLesson.TabIndex = 16;
            cmbScheduleDeleteLesson.SelectedIndexChanged += cmbScheduleDeleteLesson_SelectedIndexChanged;
            // 
            // ScheduleDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 141);
            Controls.Add(cmbScheduleDeleteLesson);
            Controls.Add(btnScheduleDeleteLesson);
            Controls.Add(lblEditGroup4);
            Controls.Add(lblEditGroup3);
            Controls.Add(label1);
            Controls.Add(lblEditGroup1);
            Name = "ScheduleDelete";
            Text = "ScheduleDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnScheduleDeleteLesson;
        private Label lblEditGroup4;
        private Label lblEditGroup3;
        private Label label1;
        private Label lblEditGroup1;
        private ComboBox cmbScheduleDeleteLesson;
    }
}