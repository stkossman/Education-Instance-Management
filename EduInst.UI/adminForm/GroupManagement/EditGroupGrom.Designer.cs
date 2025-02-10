namespace EduInst.PL
{
    partial class EditGroupGrom
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
            btnEditGroupEdit = new CustomControls.RoundButton();
            lblEditGroup4 = new Label();
            lblEditGroup3 = new Label();
            lblEditGroup2 = new Label();
            txtEditGroupNewName = new TextBox();
            lblEditGroup1 = new Label();
            txtEditGroupOldName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEditGroupEdit
            // 
            btnEditGroupEdit.BackColor = Color.FromArgb(255, 192, 128);
            btnEditGroupEdit.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditGroupEdit.BorderRadius = 40;
            btnEditGroupEdit.BorderSize = 0;
            btnEditGroupEdit.FlatAppearance.BorderSize = 0;
            btnEditGroupEdit.FlatStyle = FlatStyle.Flat;
            btnEditGroupEdit.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditGroupEdit.ForeColor = Color.Black;
            btnEditGroupEdit.Location = new Point(335, 150);
            btnEditGroupEdit.Name = "btnEditGroupEdit";
            btnEditGroupEdit.Size = new Size(100, 40);
            btnEditGroupEdit.TabIndex = 9;
            btnEditGroupEdit.Text = "Edit";
            btnEditGroupEdit.UseVisualStyleBackColor = false;
            btnEditGroupEdit.Click += btnEditGroupEdit_Click;
            // 
            // lblEditGroup4
            // 
            lblEditGroup4.AutoSize = true;
            lblEditGroup4.BackColor = Color.Silver;
            lblEditGroup4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditGroup4.Location = new Point(389, 34);
            lblEditGroup4.Name = "lblEditGroup4";
            lblEditGroup4.Size = new Size(55, 16);
            lblEditGroup4.TabIndex = 7;
            lblEditGroup4.Text = "Optional";
            // 
            // lblEditGroup3
            // 
            lblEditGroup3.AutoSize = true;
            lblEditGroup3.BackColor = Color.FromArgb(94, 129, 244);
            lblEditGroup3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEditGroup3.Location = new Point(320, 34);
            lblEditGroup3.Name = "lblEditGroup3";
            lblEditGroup3.Size = new Size(63, 16);
            lblEditGroup3.TabIndex = 8;
            lblEditGroup3.Text = "Required*";
            // 
            // lblEditGroup2
            // 
            lblEditGroup2.AutoSize = true;
            lblEditGroup2.BackColor = Color.FromArgb(94, 129, 244);
            lblEditGroup2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditGroup2.Location = new Point(20, 94);
            lblEditGroup2.Margin = new Padding(0);
            lblEditGroup2.Name = "lblEditGroup2";
            lblEditGroup2.Size = new Size(115, 16);
            lblEditGroup2.TabIndex = 4;
            lblEditGroup2.Text = "New Group Name*";
            // 
            // txtEditGroupNewName
            // 
            txtEditGroupNewName.BorderStyle = BorderStyle.FixedSingle;
            txtEditGroupNewName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditGroupNewName.Location = new Point(12, 113);
            txtEditGroupNewName.Name = "txtEditGroupNewName";
            txtEditGroupNewName.PlaceholderText = "New Name of Group";
            txtEditGroupNewName.Size = new Size(730, 27);
            txtEditGroupNewName.TabIndex = 6;
            // 
            // lblEditGroup1
            // 
            lblEditGroup1.AutoSize = true;
            lblEditGroup1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditGroup1.Location = new Point(329, 9);
            lblEditGroup1.Margin = new Padding(0);
            lblEditGroup1.Name = "lblEditGroup1";
            lblEditGroup1.Size = new Size(112, 25);
            lblEditGroup1.TabIndex = 5;
            lblEditGroup1.Text = "Edit Group";
            // 
            // txtEditGroupOldName
            // 
            txtEditGroupOldName.BorderStyle = BorderStyle.FixedSingle;
            txtEditGroupOldName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditGroupOldName.Location = new Point(12, 53);
            txtEditGroupOldName.Name = "txtEditGroupOldName";
            txtEditGroupOldName.PlaceholderText = "Name of Group";
            txtEditGroupOldName.Size = new Size(730, 27);
            txtEditGroupOldName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(94, 129, 244);
            label1.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 34);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 4;
            label1.Text = "Group Name*";
            // 
            // EditGroupGrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 196);
            Controls.Add(btnEditGroupEdit);
            Controls.Add(lblEditGroup4);
            Controls.Add(lblEditGroup3);
            Controls.Add(label1);
            Controls.Add(lblEditGroup2);
            Controls.Add(txtEditGroupOldName);
            Controls.Add(txtEditGroupNewName);
            Controls.Add(lblEditGroup1);
            Name = "EditGroupGrom";
            Text = "EditGroupGrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnEditGroupEdit;
        private Label lblEditGroup4;
        private Label lblEditGroup3;
        private Label lblEditGroup2;
        private TextBox txtEditGroupNewName;
        private Label lblEditGroup1;
        private TextBox txtEditGroupOldName;
        private Label label1;
    }
}