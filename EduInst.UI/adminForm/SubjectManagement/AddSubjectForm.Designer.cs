namespace EduInst.PL
{
    partial class AddSubjectForm
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
            btnAddSubjectCreate = new CustomControls.RoundButton();
            lblAddSubject4 = new Label();
            lblAddSubject3 = new Label();
            lblAddSubject2 = new Label();
            txtSubjectName = new TextBox();
            lblAddSubject1 = new Label();
            SuspendLayout();
            // 
            // btnAddSubjectCreate
            // 
            btnAddSubjectCreate.BackColor = Color.FromArgb(255, 192, 128);
            btnAddSubjectCreate.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddSubjectCreate.BorderRadius = 40;
            btnAddSubjectCreate.BorderSize = 0;
            btnAddSubjectCreate.FlatAppearance.BorderSize = 0;
            btnAddSubjectCreate.FlatStyle = FlatStyle.Flat;
            btnAddSubjectCreate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSubjectCreate.ForeColor = Color.Black;
            btnAddSubjectCreate.Location = new Point(335, 100);
            btnAddSubjectCreate.Name = "btnAddSubjectCreate";
            btnAddSubjectCreate.Size = new Size(100, 40);
            btnAddSubjectCreate.TabIndex = 9;
            btnAddSubjectCreate.Text = "+ Create";
            btnAddSubjectCreate.UseVisualStyleBackColor = false;
            btnAddSubjectCreate.Click += btnAddSubjectCreate_Click;
            // 
            // lblAddSubject4
            // 
            lblAddSubject4.AutoSize = true;
            lblAddSubject4.BackColor = Color.Silver;
            lblAddSubject4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddSubject4.Location = new Point(388, 36);
            lblAddSubject4.Name = "lblAddSubject4";
            lblAddSubject4.Size = new Size(55, 16);
            lblAddSubject4.TabIndex = 7;
            lblAddSubject4.Text = "Optional";
            // 
            // lblAddSubject3
            // 
            lblAddSubject3.AutoSize = true;
            lblAddSubject3.BackColor = Color.FromArgb(94, 129, 244);
            lblAddSubject3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddSubject3.Location = new Point(319, 36);
            lblAddSubject3.Name = "lblAddSubject3";
            lblAddSubject3.Size = new Size(63, 16);
            lblAddSubject3.TabIndex = 8;
            lblAddSubject3.Text = "Required*";
            // 
            // lblAddSubject2
            // 
            lblAddSubject2.AutoSize = true;
            lblAddSubject2.BackColor = Color.FromArgb(94, 129, 244);
            lblAddSubject2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSubject2.Location = new Point(22, 44);
            lblAddSubject2.Margin = new Padding(0);
            lblAddSubject2.Name = "lblAddSubject2";
            lblAddSubject2.Size = new Size(95, 16);
            lblAddSubject2.TabIndex = 4;
            lblAddSubject2.Text = "Subject Name*";
            // 
            // txtSubjectName
            // 
            txtSubjectName.BorderStyle = BorderStyle.FixedSingle;
            txtSubjectName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubjectName.Location = new Point(12, 63);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.PlaceholderText = "Name of Subject";
            txtSubjectName.Size = new Size(730, 27);
            txtSubjectName.TabIndex = 6;
            // 
            // lblAddSubject1
            // 
            lblAddSubject1.AutoSize = true;
            lblAddSubject1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSubject1.Location = new Point(300, 11);
            lblAddSubject1.Margin = new Padding(0);
            lblAddSubject1.Name = "lblAddSubject1";
            lblAddSubject1.Size = new Size(177, 25);
            lblAddSubject1.TabIndex = 5;
            lblAddSubject1.Text = "Add New Subject";
            // 
            // AddSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 151);
            Controls.Add(btnAddSubjectCreate);
            Controls.Add(lblAddSubject4);
            Controls.Add(lblAddSubject3);
            Controls.Add(lblAddSubject2);
            Controls.Add(txtSubjectName);
            Controls.Add(lblAddSubject1);
            Name = "AddSubjectForm";
            Text = "Create a new Subject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnAddSubjectCreate;
        private Label lblAddSubject4;
        private Label lblAddSubject3;
        private Label lblAddSubject2;
        private TextBox txtSubjectName;
        private Label lblAddSubject1;
    }
}