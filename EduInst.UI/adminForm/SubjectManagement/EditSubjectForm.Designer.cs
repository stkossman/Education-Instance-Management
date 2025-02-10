namespace EduInst.PL
{
    partial class EditSubjectForm
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
            btnEditSubjectEdit = new CustomControls.RoundButton();
            lblEditSubject4 = new Label();
            lblEditSubject3 = new Label();
            label1 = new Label();
            lblEditSubject2 = new Label();
            txtEditSubjectOldName = new TextBox();
            txtEditSubjectNewName = new TextBox();
            lblEditSubject1 = new Label();
            SuspendLayout();
            // 
            // btnEditSubjectEdit
            // 
            btnEditSubjectEdit.BackColor = Color.FromArgb(255, 192, 128);
            btnEditSubjectEdit.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditSubjectEdit.BorderRadius = 40;
            btnEditSubjectEdit.BorderSize = 0;
            btnEditSubjectEdit.FlatAppearance.BorderSize = 0;
            btnEditSubjectEdit.FlatStyle = FlatStyle.Flat;
            btnEditSubjectEdit.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditSubjectEdit.ForeColor = Color.Black;
            btnEditSubjectEdit.Location = new Point(335, 149);
            btnEditSubjectEdit.Name = "btnEditSubjectEdit";
            btnEditSubjectEdit.Size = new Size(100, 40);
            btnEditSubjectEdit.TabIndex = 17;
            btnEditSubjectEdit.Text = "Edit";
            btnEditSubjectEdit.UseVisualStyleBackColor = false;
            btnEditSubjectEdit.Click += btnEditSubjectEdit_Click;
            // 
            // lblEditSubject4
            // 
            lblEditSubject4.AutoSize = true;
            lblEditSubject4.BackColor = Color.Silver;
            lblEditSubject4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditSubject4.Location = new Point(389, 33);
            lblEditSubject4.Name = "lblEditSubject4";
            lblEditSubject4.Size = new Size(55, 16);
            lblEditSubject4.TabIndex = 15;
            lblEditSubject4.Text = "Optional";
            // 
            // lblEditSubject3
            // 
            lblEditSubject3.AutoSize = true;
            lblEditSubject3.BackColor = Color.FromArgb(94, 129, 244);
            lblEditSubject3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditSubject3.Location = new Point(320, 33);
            lblEditSubject3.Name = "lblEditSubject3";
            lblEditSubject3.Size = new Size(63, 16);
            lblEditSubject3.TabIndex = 16;
            lblEditSubject3.Text = "Required*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(94, 129, 244);
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 33);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 10;
            label1.Text = "Subject Name*";
            // 
            // lblEditSubject2
            // 
            lblEditSubject2.AutoSize = true;
            lblEditSubject2.BackColor = Color.FromArgb(94, 129, 244);
            lblEditSubject2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditSubject2.Location = new Point(20, 93);
            lblEditSubject2.Margin = new Padding(0);
            lblEditSubject2.Name = "lblEditSubject2";
            lblEditSubject2.Size = new Size(124, 16);
            lblEditSubject2.TabIndex = 11;
            lblEditSubject2.Text = "New Subject Name*";
            // 
            // txtEditSubjectOldName
            // 
            txtEditSubjectOldName.BorderStyle = BorderStyle.FixedSingle;
            txtEditSubjectOldName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditSubjectOldName.Location = new Point(12, 52);
            txtEditSubjectOldName.Name = "txtEditSubjectOldName";
            txtEditSubjectOldName.PlaceholderText = "Name of Subject";
            txtEditSubjectOldName.Size = new Size(730, 27);
            txtEditSubjectOldName.TabIndex = 13;
            // 
            // txtEditSubjectNewName
            // 
            txtEditSubjectNewName.BorderStyle = BorderStyle.FixedSingle;
            txtEditSubjectNewName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditSubjectNewName.Location = new Point(12, 112);
            txtEditSubjectNewName.Name = "txtEditSubjectNewName";
            txtEditSubjectNewName.PlaceholderText = "New Name of Subject";
            txtEditSubjectNewName.Size = new Size(730, 27);
            txtEditSubjectNewName.TabIndex = 14;
            // 
            // lblEditSubject1
            // 
            lblEditSubject1.AutoSize = true;
            lblEditSubject1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditSubject1.Location = new Point(320, 8);
            lblEditSubject1.Margin = new Padding(0);
            lblEditSubject1.Name = "lblEditSubject1";
            lblEditSubject1.Size = new Size(126, 25);
            lblEditSubject1.TabIndex = 12;
            lblEditSubject1.Text = "Edit Subject";
            // 
            // EditSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 196);
            Controls.Add(btnEditSubjectEdit);
            Controls.Add(lblEditSubject4);
            Controls.Add(lblEditSubject3);
            Controls.Add(label1);
            Controls.Add(lblEditSubject2);
            Controls.Add(txtEditSubjectOldName);
            Controls.Add(txtEditSubjectNewName);
            Controls.Add(lblEditSubject1);
            Name = "EditSubjectForm";
            Text = "EditSubjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnEditSubjectEdit;
        private Label lblEditSubject4;
        private Label lblEditSubject3;
        private Label label1;
        private Label lblEditSubject2;
        private TextBox txtEditSubjectOldName;
        private TextBox txtEditSubjectNewName;
        private Label lblEditSubject1;
    }
}