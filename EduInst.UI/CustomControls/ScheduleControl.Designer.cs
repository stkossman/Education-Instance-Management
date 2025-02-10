namespace EduInst.PL.Schedule
{
    partial class ScheduleControl
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
            components = new System.ComponentModel.Container();
            dgvSchedule = new DataGridView();
            btnScheduleCrud = new CustomControls.RoundButton();
            dtpScheduleDate = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            lblAddTeacher2 = new Label();
            btnExportSchedule = new CustomControls.RoundButton();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(3, 49);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.Size = new Size(838, 496);
            dgvSchedule.TabIndex = 0;
            // 
            // btnScheduleCrud
            // 
            btnScheduleCrud.BackColor = Color.FromArgb(0, 0, 0);
            btnScheduleCrud.BorderColor = Color.FromArgb(94, 129, 244);
            btnScheduleCrud.BorderRadius = 40;
            btnScheduleCrud.BorderSize = 0;
            btnScheduleCrud.FlatAppearance.BorderSize = 0;
            btnScheduleCrud.FlatStyle = FlatStyle.Flat;
            btnScheduleCrud.Font = new Font("SF Pro Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScheduleCrud.ForeColor = Color.White;
            btnScheduleCrud.Location = new Point(3, 550);
            btnScheduleCrud.Name = "btnScheduleCrud";
            btnScheduleCrud.Size = new Size(838, 40);
            btnScheduleCrud.TabIndex = 2;
            btnScheduleCrud.Text = "Schedule Control";
            btnScheduleCrud.UseVisualStyleBackColor = false;
            btnScheduleCrud.Click += btnScheduleCrud_Click;
            // 
            // dtpScheduleDate
            // 
            dtpScheduleDate.Location = new Point(3, 20);
            dtpScheduleDate.Name = "dtpScheduleDate";
            dtpScheduleDate.Size = new Size(200, 23);
            dtpScheduleDate.TabIndex = 3;
            // 
            // lblAddTeacher2
            // 
            lblAddTeacher2.AutoSize = true;
            lblAddTeacher2.BackColor = Color.FromArgb(94, 129, 244);
            lblAddTeacher2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher2.Location = new Point(15, 0);
            lblAddTeacher2.Margin = new Padding(0);
            lblAddTeacher2.Name = "lblAddTeacher2";
            lblAddTeacher2.Size = new Size(62, 16);
            lblAddTeacher2.TabIndex = 16;
            lblAddTeacher2.Text = "Pick date";
            // 
            // btnExportSchedule
            // 
            btnExportSchedule.BackColor = Color.FromArgb(0, 0, 0);
            btnExportSchedule.BorderColor = Color.FromArgb(94, 129, 244);
            btnExportSchedule.BorderRadius = 40;
            btnExportSchedule.BorderSize = 0;
            btnExportSchedule.FlatAppearance.BorderSize = 0;
            btnExportSchedule.FlatStyle = FlatStyle.Flat;
            btnExportSchedule.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExportSchedule.ForeColor = Color.White;
            btnExportSchedule.Location = new Point(732, 3);
            btnExportSchedule.Name = "btnExportSchedule";
            btnExportSchedule.Size = new Size(100, 40);
            btnExportSchedule.TabIndex = 17;
            btnExportSchedule.Text = "Export";
            btnExportSchedule.UseVisualStyleBackColor = false;
            btnExportSchedule.Click += btnExportSchedule_Click;
            // 
            // ScheduleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExportSchedule);
            Controls.Add(lblAddTeacher2);
            Controls.Add(dtpScheduleDate);
            Controls.Add(btnScheduleCrud);
            Controls.Add(dgvSchedule);
            Name = "ScheduleControl";
            Size = new Size(844, 593);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSchedule;
        private CustomControls.RoundButton btnScheduleCrud;
        private DateTimePicker dtpScheduleDate;
        private BindingSource bindingSource1;
        private Label lblAddTeacher2;
        private CustomControls.RoundButton btnExportSchedule;
    }
}
