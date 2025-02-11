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
            cmbScheduleGroup = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbScheduleTeacher = new ComboBox();
            btnReset = new CustomControls.RoundButton();
            label3 = new Label();
            cmbScheduleSubject = new ComboBox();
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
            // cmbScheduleGroup
            // 
            cmbScheduleGroup.FormattingEnabled = true;
            cmbScheduleGroup.Location = new Point(209, 20);
            cmbScheduleGroup.Name = "cmbScheduleGroup";
            cmbScheduleGroup.Size = new Size(121, 23);
            cmbScheduleGroup.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(94, 129, 244);
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 1);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 16;
            label1.Text = "Pick group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(94, 129, 244);
            label2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(347, 1);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 16;
            label2.Text = "Pick teacher";
            // 
            // cmbScheduleTeacher
            // 
            cmbScheduleTeacher.FormattingEnabled = true;
            cmbScheduleTeacher.Location = new Point(336, 20);
            cmbScheduleTeacher.Name = "cmbScheduleTeacher";
            cmbScheduleTeacher.Size = new Size(121, 23);
            cmbScheduleTeacher.TabIndex = 18;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 0, 0);
            btnReset.BorderColor = Color.FromArgb(94, 129, 244);
            btnReset.BorderRadius = 40;
            btnReset.BorderSize = 0;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(626, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 40);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(94, 129, 244);
            label3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(474, 1);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 16;
            label3.Text = "Pick subject";
            // 
            // cmbScheduleSubject
            // 
            cmbScheduleSubject.FormattingEnabled = true;
            cmbScheduleSubject.Location = new Point(463, 20);
            cmbScheduleSubject.Name = "cmbScheduleSubject";
            cmbScheduleSubject.Size = new Size(121, 23);
            cmbScheduleSubject.TabIndex = 18;
            // 
            // ScheduleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReset);
            Controls.Add(cmbScheduleSubject);
            Controls.Add(cmbScheduleTeacher);
            Controls.Add(label3);
            Controls.Add(cmbScheduleGroup);
            Controls.Add(label2);
            Controls.Add(btnExportSchedule);
            Controls.Add(label1);
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
        private ComboBox cmbScheduleGroup;
        private Label label1;
        private Label label2;
        private ComboBox cmbScheduleTeacher;
        private CustomControls.RoundButton btnReset;
        private Label label3;
        private ComboBox cmbScheduleSubject;
    }
}
