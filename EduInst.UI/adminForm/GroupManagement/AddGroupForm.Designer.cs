namespace EduInst.PL
{
    partial class AddGroupForm
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
            lblAddGroup1 = new Label();
            txtGroupName = new TextBox();
            lblAddGroup2 = new Label();
            lblAddGroup3 = new Label();
            lblAddGroup4 = new Label();
            btnAddGroupCreate = new CustomControls.RoundButton();
            SuspendLayout();
            // 
            // lblAddGroup1
            // 
            lblAddGroup1.AutoSize = true;
            lblAddGroup1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGroup1.Location = new Point(304, 10);
            lblAddGroup1.Margin = new Padding(0);
            lblAddGroup1.Name = "lblAddGroup1";
            lblAddGroup1.Size = new Size(163, 25);
            lblAddGroup1.TabIndex = 0;
            lblAddGroup1.Text = "Add New Group";
            // 
            // txtGroupName
            // 
            txtGroupName.BorderStyle = BorderStyle.FixedSingle;
            txtGroupName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGroupName.Location = new Point(12, 62);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.PlaceholderText = "Name of Group";
            txtGroupName.Size = new Size(730, 27);
            txtGroupName.TabIndex = 1;
            // 
            // lblAddGroup2
            // 
            lblAddGroup2.AutoSize = true;
            lblAddGroup2.BackColor = Color.FromArgb(94, 129, 244);
            lblAddGroup2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddGroup2.Location = new Point(22, 43);
            lblAddGroup2.Margin = new Padding(0);
            lblAddGroup2.Name = "lblAddGroup2";
            lblAddGroup2.Size = new Size(86, 16);
            lblAddGroup2.TabIndex = 0;
            lblAddGroup2.Text = "Group Name*";
            // 
            // lblAddGroup3
            // 
            lblAddGroup3.AutoSize = true;
            lblAddGroup3.BackColor = Color.FromArgb(94, 129, 244);
            lblAddGroup3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddGroup3.Location = new Point(319, 35);
            lblAddGroup3.Name = "lblAddGroup3";
            lblAddGroup3.Size = new Size(63, 16);
            lblAddGroup3.TabIndex = 2;
            lblAddGroup3.Text = "Required*";
            // 
            // lblAddGroup4
            // 
            lblAddGroup4.AutoSize = true;
            lblAddGroup4.BackColor = Color.Silver;
            lblAddGroup4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddGroup4.Location = new Point(388, 35);
            lblAddGroup4.Name = "lblAddGroup4";
            lblAddGroup4.Size = new Size(55, 16);
            lblAddGroup4.TabIndex = 2;
            lblAddGroup4.Text = "Optional";
            // 
            // btnAddGroupCreate
            // 
            btnAddGroupCreate.BackColor = Color.FromArgb(255, 192, 128);
            btnAddGroupCreate.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddGroupCreate.BorderRadius = 40;
            btnAddGroupCreate.BorderSize = 0;
            btnAddGroupCreate.FlatAppearance.BorderSize = 0;
            btnAddGroupCreate.FlatStyle = FlatStyle.Flat;
            btnAddGroupCreate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddGroupCreate.ForeColor = Color.Black;
            btnAddGroupCreate.Location = new Point(335, 99);
            btnAddGroupCreate.Name = "btnAddGroupCreate";
            btnAddGroupCreate.Size = new Size(100, 40);
            btnAddGroupCreate.TabIndex = 3;
            btnAddGroupCreate.Text = "+ Create";
            btnAddGroupCreate.UseVisualStyleBackColor = false;
            btnAddGroupCreate.Click += btnAddGroupCreate_Click;
            // 
            // AddGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(754, 151);
            Controls.Add(btnAddGroupCreate);
            Controls.Add(lblAddGroup4);
            Controls.Add(lblAddGroup3);
            Controls.Add(lblAddGroup2);
            Controls.Add(txtGroupName);
            Controls.Add(lblAddGroup1);
            Name = "AddGroupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddGroupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddGroup1;
        private TextBox txtGroupName;
        private Label lblAddGroup2;
        private Label lblAddGroup3;
        private Label lblAddGroup4;
        private CustomControls.RoundButton btnAddGroupCreate;
    }
}