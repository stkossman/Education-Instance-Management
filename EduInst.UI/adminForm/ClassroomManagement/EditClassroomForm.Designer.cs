namespace EduInst.PL
{
    partial class EditClassroomForm
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
            lblEditClassChoose = new Label();
            cmbEditClassChoose = new ComboBox();
            btnEditStudentEdit = new CustomControls.RoundButton();
            lblEditClass3 = new Label();
            lblEditClass2 = new Label();
            lblEditClass5 = new Label();
            lblEditClass4 = new Label();
            txtEditClassCapacity = new TextBox();
            txtEditClassName = new TextBox();
            lblEditClass1 = new Label();
            SuspendLayout();
            // 
            // lblEditClassChoose
            // 
            lblEditClassChoose.AutoSize = true;
            lblEditClassChoose.BackColor = Color.FromArgb(94, 129, 244);
            lblEditClassChoose.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditClassChoose.Location = new Point(20, 55);
            lblEditClassChoose.Margin = new Padding(0);
            lblEditClassChoose.Name = "lblEditClassChoose";
            lblEditClassChoose.Size = new Size(124, 16);
            lblEditClassChoose.TabIndex = 30;
            lblEditClassChoose.Text = "Choose Classroom*";
            // 
            // cmbEditClassChoose
            // 
            cmbEditClassChoose.FormattingEnabled = true;
            cmbEditClassChoose.Location = new Point(12, 74);
            cmbEditClassChoose.Name = "cmbEditClassChoose";
            cmbEditClassChoose.Size = new Size(730, 23);
            cmbEditClassChoose.TabIndex = 38;
            cmbEditClassChoose.SelectedIndexChanged += cmbEditClassChoose_SelectedIndexChanged;
            // 
            // btnEditStudentEdit
            // 
            btnEditStudentEdit.BackColor = Color.FromArgb(255, 192, 128);
            btnEditStudentEdit.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditStudentEdit.BorderRadius = 40;
            btnEditStudentEdit.BorderSize = 0;
            btnEditStudentEdit.FlatAppearance.BorderSize = 0;
            btnEditStudentEdit.FlatStyle = FlatStyle.Flat;
            btnEditStudentEdit.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditStudentEdit.ForeColor = Color.Black;
            btnEditStudentEdit.Location = new Point(335, 209);
            btnEditStudentEdit.Name = "btnEditStudentEdit";
            btnEditStudentEdit.Size = new Size(100, 40);
            btnEditStudentEdit.TabIndex = 37;
            btnEditStudentEdit.Text = "Edit";
            btnEditStudentEdit.UseVisualStyleBackColor = false;
            btnEditStudentEdit.Click += btnEditStudentEdit_Click;
            // 
            // lblEditClass3
            // 
            lblEditClass3.AutoSize = true;
            lblEditClass3.BackColor = Color.Silver;
            lblEditClass3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditClass3.Location = new Point(389, 33);
            lblEditClass3.Name = "lblEditClass3";
            lblEditClass3.Size = new Size(55, 16);
            lblEditClass3.TabIndex = 35;
            lblEditClass3.Text = "Optional";
            // 
            // lblEditClass2
            // 
            lblEditClass2.AutoSize = true;
            lblEditClass2.BackColor = Color.FromArgb(94, 129, 244);
            lblEditClass2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditClass2.Location = new Point(320, 33);
            lblEditClass2.Name = "lblEditClass2";
            lblEditClass2.Size = new Size(63, 16);
            lblEditClass2.TabIndex = 36;
            lblEditClass2.Text = "Required*";
            // 
            // lblEditClass5
            // 
            lblEditClass5.AutoSize = true;
            lblEditClass5.BackColor = Color.Silver;
            lblEditClass5.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditClass5.Location = new Point(20, 158);
            lblEditClass5.Margin = new Padding(0);
            lblEditClass5.Name = "lblEditClass5";
            lblEditClass5.Size = new Size(102, 16);
            lblEditClass5.TabIndex = 29;
            lblEditClass5.Text = "Class Capacity*";
            // 
            // lblEditClass4
            // 
            lblEditClass4.AutoSize = true;
            lblEditClass4.BackColor = Color.Silver;
            lblEditClass4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditClass4.Location = new Point(20, 109);
            lblEditClass4.Margin = new Padding(0);
            lblEditClass4.Name = "lblEditClass4";
            lblEditClass4.Size = new Size(83, 16);
            lblEditClass4.TabIndex = 31;
            lblEditClass4.Text = "Class Name*";
            // 
            // txtEditClassCapacity
            // 
            txtEditClassCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEditClassCapacity.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditClassCapacity.Location = new Point(12, 174);
            txtEditClassCapacity.Name = "txtEditClassCapacity";
            txtEditClassCapacity.PlaceholderText = "e.g. 50";
            txtEditClassCapacity.Size = new Size(730, 27);
            txtEditClassCapacity.TabIndex = 33;
            // 
            // txtEditClassName
            // 
            txtEditClassName.BorderStyle = BorderStyle.FixedSingle;
            txtEditClassName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditClassName.Location = new Point(12, 128);
            txtEditClassName.Name = "txtEditClassName";
            txtEditClassName.PlaceholderText = "e.g. P3";
            txtEditClassName.Size = new Size(730, 27);
            txtEditClassName.TabIndex = 34;
            // 
            // lblEditClass1
            // 
            lblEditClass1.AutoSize = true;
            lblEditClass1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditClass1.Location = new Point(309, 8);
            lblEditClass1.Margin = new Padding(0);
            lblEditClass1.Name = "lblEditClass1";
            lblEditClass1.Size = new Size(156, 25);
            lblEditClass1.TabIndex = 32;
            lblEditClass1.Text = "Edit Classroom";
            // 
            // EditClassroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 261);
            Controls.Add(lblEditClassChoose);
            Controls.Add(cmbEditClassChoose);
            Controls.Add(btnEditStudentEdit);
            Controls.Add(lblEditClass3);
            Controls.Add(lblEditClass2);
            Controls.Add(lblEditClass5);
            Controls.Add(lblEditClass4);
            Controls.Add(txtEditClassCapacity);
            Controls.Add(txtEditClassName);
            Controls.Add(lblEditClass1);
            Name = "EditClassroomForm";
            Text = "EditClassroomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditClassChoose;
        private ComboBox cmbEditClassChoose;
        private CustomControls.RoundButton btnEditStudentEdit;
        private Label lblEditClass3;
        private Label lblEditClass2;
        private Label lblEditClass5;
        private Label lblEditClass4;
        private TextBox txtEditClassCapacity;
        private TextBox txtEditClassName;
        private Label lblEditClass1;
    }
}