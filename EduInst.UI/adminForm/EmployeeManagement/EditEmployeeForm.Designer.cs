namespace EduInst.PL
{
    partial class EditEmployeeForm
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
            lblEditTeacherChoose = new Label();
            cmbEditTeacherChoose = new ComboBox();
            lblEditTeacher8 = new Label();
            btnEditTeacherEdit = new CustomControls.RoundButton();
            lblEditTeacher3 = new Label();
            lblEditTeacher2 = new Label();
            lblEditTeacher7 = new Label();
            lblEditTeacher6 = new Label();
            lblEditTeacher5 = new Label();
            lblEditTeacher4 = new Label();
            txtEditTeacherPhone = new TextBox();
            txtEditTeacherEmail = new TextBox();
            txtEditTeacherLastName = new TextBox();
            txtEditTeacherFirstName = new TextBox();
            lblEditTeacher1 = new Label();
            dtpEditTeacherBirth = new DateTimePicker();
            SuspendLayout();
            // 
            // lblEditTeacherChoose
            // 
            lblEditTeacherChoose.AutoSize = true;
            lblEditTeacherChoose.BackColor = Color.FromArgb(94, 129, 244);
            lblEditTeacherChoose.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacherChoose.Location = new Point(20, 55);
            lblEditTeacherChoose.Margin = new Padding(0);
            lblEditTeacherChoose.Name = "lblEditTeacherChoose";
            lblEditTeacherChoose.Size = new Size(109, 16);
            lblEditTeacherChoose.TabIndex = 33;
            lblEditTeacherChoose.Text = "Choose Teacher*";
            // 
            // cmbEditTeacherChoose
            // 
            cmbEditTeacherChoose.FormattingEnabled = true;
            cmbEditTeacherChoose.Location = new Point(12, 74);
            cmbEditTeacherChoose.Name = "cmbEditTeacherChoose";
            cmbEditTeacherChoose.Size = new Size(730, 23);
            cmbEditTeacherChoose.TabIndex = 44;
            cmbEditTeacherChoose.SelectedIndexChanged += cmbEditTeacherChoose_SelectedIndexChanged;
            // 
            // lblEditTeacher8
            // 
            lblEditTeacher8.AutoSize = true;
            lblEditTeacher8.BackColor = Color.Silver;
            lblEditTeacher8.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacher8.Location = new Point(20, 286);
            lblEditTeacher8.Margin = new Padding(0);
            lblEditTeacher8.Name = "lblEditTeacher8";
            lblEditTeacher8.Size = new Size(88, 16);
            lblEditTeacher8.TabIndex = 29;
            lblEditTeacher8.Text = "Date of Birth*";
            // 
            // btnEditTeacherEdit
            // 
            btnEditTeacherEdit.BackColor = Color.FromArgb(255, 192, 128);
            btnEditTeacherEdit.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditTeacherEdit.BorderRadius = 40;
            btnEditTeacherEdit.BorderSize = 0;
            btnEditTeacherEdit.FlatAppearance.BorderSize = 0;
            btnEditTeacherEdit.FlatStyle = FlatStyle.Flat;
            btnEditTeacherEdit.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditTeacherEdit.ForeColor = Color.Black;
            btnEditTeacherEdit.Location = new Point(335, 350);
            btnEditTeacherEdit.Name = "btnEditTeacherEdit";
            btnEditTeacherEdit.Size = new Size(100, 40);
            btnEditTeacherEdit.TabIndex = 42;
            btnEditTeacherEdit.Text = "Edit";
            btnEditTeacherEdit.UseVisualStyleBackColor = false;
            btnEditTeacherEdit.Click += btnEditTeacherEdit_Click;
            // 
            // lblEditTeacher3
            // 
            lblEditTeacher3.AutoSize = true;
            lblEditTeacher3.BackColor = Color.Silver;
            lblEditTeacher3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditTeacher3.Location = new Point(389, 33);
            lblEditTeacher3.Name = "lblEditTeacher3";
            lblEditTeacher3.Size = new Size(55, 16);
            lblEditTeacher3.TabIndex = 40;
            lblEditTeacher3.Text = "Optional";
            // 
            // lblEditTeacher2
            // 
            lblEditTeacher2.AutoSize = true;
            lblEditTeacher2.BackColor = Color.FromArgb(94, 129, 244);
            lblEditTeacher2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditTeacher2.Location = new Point(320, 33);
            lblEditTeacher2.Name = "lblEditTeacher2";
            lblEditTeacher2.Size = new Size(63, 16);
            lblEditTeacher2.TabIndex = 41;
            lblEditTeacher2.Text = "Required*";
            // 
            // lblEditTeacher7
            // 
            lblEditTeacher7.AutoSize = true;
            lblEditTeacher7.BackColor = Color.Silver;
            lblEditTeacher7.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacher7.Location = new Point(20, 244);
            lblEditTeacher7.Margin = new Padding(0);
            lblEditTeacher7.Name = "lblEditTeacher7";
            lblEditTeacher7.Size = new Size(50, 16);
            lblEditTeacher7.TabIndex = 30;
            lblEditTeacher7.Text = "Phone*";
            // 
            // lblEditTeacher6
            // 
            lblEditTeacher6.AutoSize = true;
            lblEditTeacher6.BackColor = Color.Silver;
            lblEditTeacher6.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacher6.Location = new Point(20, 200);
            lblEditTeacher6.Margin = new Padding(0);
            lblEditTeacher6.Name = "lblEditTeacher6";
            lblEditTeacher6.Size = new Size(44, 16);
            lblEditTeacher6.TabIndex = 31;
            lblEditTeacher6.Text = "Email*";
            // 
            // lblEditTeacher5
            // 
            lblEditTeacher5.AutoSize = true;
            lblEditTeacher5.BackColor = Color.Silver;
            lblEditTeacher5.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacher5.Location = new Point(20, 155);
            lblEditTeacher5.Margin = new Padding(0);
            lblEditTeacher5.Name = "lblEditTeacher5";
            lblEditTeacher5.Size = new Size(76, 16);
            lblEditTeacher5.TabIndex = 32;
            lblEditTeacher5.Text = "Last Name*";
            // 
            // lblEditTeacher4
            // 
            lblEditTeacher4.AutoSize = true;
            lblEditTeacher4.BackColor = Color.Silver;
            lblEditTeacher4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacher4.Location = new Point(20, 109);
            lblEditTeacher4.Margin = new Padding(0);
            lblEditTeacher4.Name = "lblEditTeacher4";
            lblEditTeacher4.Size = new Size(77, 16);
            lblEditTeacher4.TabIndex = 34;
            lblEditTeacher4.Text = "First Name*";
            // 
            // txtEditTeacherPhone
            // 
            txtEditTeacherPhone.BorderStyle = BorderStyle.FixedSingle;
            txtEditTeacherPhone.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditTeacherPhone.Location = new Point(12, 263);
            txtEditTeacherPhone.Name = "txtEditTeacherPhone";
            txtEditTeacherPhone.PlaceholderText = "e.g. 380(ХХ)ХХХХХХХ";
            txtEditTeacherPhone.Size = new Size(730, 27);
            txtEditTeacherPhone.TabIndex = 36;
            // 
            // txtEditTeacherEmail
            // 
            txtEditTeacherEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEditTeacherEmail.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditTeacherEmail.Location = new Point(12, 219);
            txtEditTeacherEmail.Name = "txtEditTeacherEmail";
            txtEditTeacherEmail.PlaceholderText = "name@mail.com";
            txtEditTeacherEmail.Size = new Size(730, 27);
            txtEditTeacherEmail.TabIndex = 37;
            // 
            // txtEditTeacherLastName
            // 
            txtEditTeacherLastName.BorderStyle = BorderStyle.FixedSingle;
            txtEditTeacherLastName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditTeacherLastName.Location = new Point(12, 174);
            txtEditTeacherLastName.Name = "txtEditTeacherLastName";
            txtEditTeacherLastName.PlaceholderText = "e.g. Brown";
            txtEditTeacherLastName.Size = new Size(730, 27);
            txtEditTeacherLastName.TabIndex = 38;
            // 
            // txtEditTeacherFirstName
            // 
            txtEditTeacherFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtEditTeacherFirstName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditTeacherFirstName.Location = new Point(12, 128);
            txtEditTeacherFirstName.Name = "txtEditTeacherFirstName";
            txtEditTeacherFirstName.PlaceholderText = "e.g. Thomas";
            txtEditTeacherFirstName.Size = new Size(730, 27);
            txtEditTeacherFirstName.TabIndex = 39;
            // 
            // lblEditTeacher1
            // 
            lblEditTeacher1.AutoSize = true;
            lblEditTeacher1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditTeacher1.Location = new Point(318, 8);
            lblEditTeacher1.Margin = new Padding(0);
            lblEditTeacher1.Name = "lblEditTeacher1";
            lblEditTeacher1.Size = new Size(130, 25);
            lblEditTeacher1.TabIndex = 35;
            lblEditTeacher1.Text = "Edit Teacher";
            // 
            // dtpEditTeacherBirth
            // 
            dtpEditTeacherBirth.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpEditTeacherBirth.Location = new Point(12, 305);
            dtpEditTeacherBirth.Name = "dtpEditTeacherBirth";
            dtpEditTeacherBirth.Size = new Size(730, 27);
            dtpEditTeacherBirth.TabIndex = 43;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 401);
            Controls.Add(lblEditTeacherChoose);
            Controls.Add(cmbEditTeacherChoose);
            Controls.Add(lblEditTeacher8);
            Controls.Add(btnEditTeacherEdit);
            Controls.Add(lblEditTeacher3);
            Controls.Add(lblEditTeacher2);
            Controls.Add(lblEditTeacher7);
            Controls.Add(lblEditTeacher6);
            Controls.Add(lblEditTeacher5);
            Controls.Add(lblEditTeacher4);
            Controls.Add(txtEditTeacherPhone);
            Controls.Add(txtEditTeacherEmail);
            Controls.Add(txtEditTeacherLastName);
            Controls.Add(txtEditTeacherFirstName);
            Controls.Add(lblEditTeacher1);
            Controls.Add(dtpEditTeacherBirth);
            Name = "EditEmployeeForm";
            Text = "Edit Teacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEditTeacherChoose;
        private ComboBox cmbEditTeacherChoose;
        private Label lblEditTeacher8;
        private CustomControls.RoundButton btnEditTeacherEdit;
        private Label lblEditTeacher3;
        private Label lblEditTeacher2;
        private Label lblEditTeacher7;
        private Label lblEditTeacher6;
        private Label lblEditTeacher5;
        private Label lblEditTeacher4;
        private TextBox txtEditTeacherPhone;
        private TextBox txtEditTeacherEmail;
        private TextBox txtEditTeacherLastName;
        private TextBox txtEditTeacherFirstName;
        private Label lblEditTeacher1;
        private DateTimePicker dtpEditTeacherBirth;
    }
}