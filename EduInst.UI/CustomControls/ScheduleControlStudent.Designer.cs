namespace EduInst.PL.CustomControls
{
    partial class ScheduleControlStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAddTeacher2 = new Label();
            dtpScheduleDate = new DateTimePicker();
            dgvSchedule = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // lblAddTeacher2
            // 
            lblAddTeacher2.AutoSize = true;
            lblAddTeacher2.BackColor = Color.FromArgb(94, 129, 244);
            lblAddTeacher2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher2.Location = new Point(15, 2);
            lblAddTeacher2.Margin = new Padding(0);
            lblAddTeacher2.Name = "lblAddTeacher2";
            lblAddTeacher2.Size = new Size(62, 16);
            lblAddTeacher2.TabIndex = 19;
            lblAddTeacher2.Text = "Pick date";
            // 
            // dtpScheduleDate
            // 
            dtpScheduleDate.Location = new Point(3, 22);
            dtpScheduleDate.Name = "dtpScheduleDate";
            dtpScheduleDate.Size = new Size(200, 23);
            dtpScheduleDate.TabIndex = 18;
            // 
            // dgvSchedule
            // 
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(3, 51);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.Size = new Size(838, 539);
            dgvSchedule.TabIndex = 17;
            // 
            // StudentsControlCut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAddTeacher2);
            Controls.Add(dtpScheduleDate);
            Controls.Add(dgvSchedule);
            Name = "StudentsControlCut";
            Size = new Size(844, 593);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddTeacher2;
        private DateTimePicker dtpScheduleDate;
        private DataGridView dgvSchedule;
    }
}
