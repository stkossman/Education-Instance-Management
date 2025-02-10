namespace EduInst.PL
{
    partial class AddStudentForm
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
            btnAddStudentCreate = new CustomControls.RoundButton();
            lblAddGroup4 = new Label();
            lblAddGroup3 = new Label();
            lblAddGroup2 = new Label();
            txtStudentFirstName = new TextBox();
            lblAddGroup1 = new Label();
            txtStudentLastName = new TextBox();
            label1 = new Label();
            txtStudentEmail = new TextBox();
            label2 = new Label();
            txtStudentPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dtpStudentBirth = new DateTimePicker();
            label5 = new Label();
            cmbStudentGroups = new ComboBox();
            SuspendLayout();
            // 
            // btnAddStudentCreate
            // 
            btnAddStudentCreate.BackColor = Color.FromArgb(255, 192, 128);
            btnAddStudentCreate.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddStudentCreate.BorderRadius = 40;
            btnAddStudentCreate.BorderSize = 0;
            btnAddStudentCreate.FlatAppearance.BorderSize = 0;
            btnAddStudentCreate.FlatStyle = FlatStyle.Flat;
            btnAddStudentCreate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStudentCreate.ForeColor = Color.Black;
            btnAddStudentCreate.Location = new Point(335, 325);
            btnAddStudentCreate.Name = "btnAddStudentCreate";
            btnAddStudentCreate.Size = new Size(100, 40);
            btnAddStudentCreate.TabIndex = 9;
            btnAddStudentCreate.Text = "+ Create";
            btnAddStudentCreate.UseVisualStyleBackColor = false;
            btnAddStudentCreate.Click += btnAddStudentCreate_Click;
            // 
            // lblAddGroup4
            // 
            lblAddGroup4.AutoSize = true;
            lblAddGroup4.BackColor = Color.Silver;
            lblAddGroup4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddGroup4.Location = new Point(386, 34);
            lblAddGroup4.Name = "lblAddGroup4";
            lblAddGroup4.Size = new Size(55, 16);
            lblAddGroup4.TabIndex = 7;
            lblAddGroup4.Text = "Optional";
            // 
            // lblAddGroup3
            // 
            lblAddGroup3.AutoSize = true;
            lblAddGroup3.BackColor = Color.FromArgb(94, 129, 244);
            lblAddGroup3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddGroup3.Location = new Point(317, 34);
            lblAddGroup3.Name = "lblAddGroup3";
            lblAddGroup3.Size = new Size(63, 16);
            lblAddGroup3.TabIndex = 8;
            lblAddGroup3.Text = "Required*";
            // 
            // lblAddGroup2
            // 
            lblAddGroup2.AutoSize = true;
            lblAddGroup2.BackColor = Color.FromArgb(94, 129, 244);
            lblAddGroup2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGroup2.Location = new Point(18, 42);
            lblAddGroup2.Margin = new Padding(0);
            lblAddGroup2.Name = "lblAddGroup2";
            lblAddGroup2.Size = new Size(77, 16);
            lblAddGroup2.TabIndex = 4;
            lblAddGroup2.Text = "First Name*";
            // 
            // txtStudentFirstName
            // 
            txtStudentFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentFirstName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentFirstName.Location = new Point(10, 61);
            txtStudentFirstName.Name = "txtStudentFirstName";
            txtStudentFirstName.PlaceholderText = "e.g. Thomas";
            txtStudentFirstName.Size = new Size(730, 27);
            txtStudentFirstName.TabIndex = 6;
            // 
            // lblAddGroup1
            // 
            lblAddGroup1.AutoSize = true;
            lblAddGroup1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGroup1.Location = new Point(293, 9);
            lblAddGroup1.Margin = new Padding(0);
            lblAddGroup1.Name = "lblAddGroup1";
            lblAddGroup1.Size = new Size(180, 25);
            lblAddGroup1.TabIndex = 5;
            lblAddGroup1.Text = "Add New Student";
            // 
            // txtStudentLastName
            // 
            txtStudentLastName.BorderStyle = BorderStyle.FixedSingle;
            txtStudentLastName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentLastName.Location = new Point(10, 107);
            txtStudentLastName.Name = "txtStudentLastName";
            txtStudentLastName.PlaceholderText = "e.g. Brown";
            txtStudentLastName.Size = new Size(730, 27);
            txtStudentLastName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(94, 129, 244);
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 88);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(76, 16);
            label1.TabIndex = 4;
            label1.Text = "Last Name*";
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.BorderStyle = BorderStyle.FixedSingle;
            txtStudentEmail.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentEmail.Location = new Point(10, 152);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.PlaceholderText = "name@mail.com";
            txtStudentEmail.Size = new Size(730, 27);
            txtStudentEmail.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(94, 129, 244);
            label2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 133);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 4;
            label2.Text = "Email*";
            // 
            // txtStudentPhone
            // 
            txtStudentPhone.BorderStyle = BorderStyle.FixedSingle;
            txtStudentPhone.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentPhone.Location = new Point(10, 196);
            txtStudentPhone.Name = "txtStudentPhone";
            txtStudentPhone.PlaceholderText = "e.g. 380(ХХ)ХХХХХХХ";
            txtStudentPhone.Size = new Size(730, 27);
            txtStudentPhone.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(94, 129, 244);
            label3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 177);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 4;
            label3.Text = "Phone*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(94, 129, 244);
            label4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 219);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(88, 16);
            label4.TabIndex = 4;
            label4.Text = "Date of Birth*";
            // 
            // dtpStudentBirth
            // 
            dtpStudentBirth.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpStudentBirth.Location = new Point(10, 238);
            dtpStudentBirth.Name = "dtpStudentBirth";
            dtpStudentBirth.Size = new Size(730, 27);
            dtpStudentBirth.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(94, 129, 244);
            label5.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 264);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(49, 16);
            label5.TabIndex = 4;
            label5.Text = "Group*";
            // 
            // cmbStudentGroups
            // 
            cmbStudentGroups.FormattingEnabled = true;
            cmbStudentGroups.Location = new Point(10, 283);
            cmbStudentGroups.Name = "cmbStudentGroups";
            cmbStudentGroups.Size = new Size(730, 23);
            cmbStudentGroups.TabIndex = 11;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 381);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAddStudentCreate);
            Controls.Add(lblAddGroup4);
            Controls.Add(lblAddGroup3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAddGroup2);
            Controls.Add(txtStudentPhone);
            Controls.Add(txtStudentEmail);
            Controls.Add(txtStudentLastName);
            Controls.Add(txtStudentFirstName);
            Controls.Add(lblAddGroup1);
            Controls.Add(dtpStudentBirth);
            Controls.Add(cmbStudentGroups);
            Name = "AddStudentForm";
            Text = "Add new Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnAddStudentCreate;
        private Label lblAddGroup4;
        private Label lblAddGroup3;
        private Label lblAddGroup2;
        private TextBox txtStudentFirstName;
        private Label lblAddGroup1;
        private TextBox txtStudentLastName;
        private Label label1;
        private TextBox txtStudentEmail;
        private Label label2;
        private TextBox txtStudentPhone;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpStudentBirth;
        private Label label5;
        private ComboBox cmbStudentGroups;
    }
}