namespace EduInst.PL
{
    partial class AddClassroomForm
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
            btnAddClassCreate = new CustomControls.RoundButton();
            lblAddClass3 = new Label();
            lblAddClass2 = new Label();
            lblAddClass4 = new Label();
            lblEAddClass5 = new Label();
            txtEAddClassName = new TextBox();
            txtEAddClassCapacity = new TextBox();
            lblEAddClass1 = new Label();
            SuspendLayout();
            // 
            // btnAddClassCreate
            // 
            btnAddClassCreate.BackColor = Color.FromArgb(255, 192, 128);
            btnAddClassCreate.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddClassCreate.BorderRadius = 40;
            btnAddClassCreate.BorderSize = 0;
            btnAddClassCreate.FlatAppearance.BorderSize = 0;
            btnAddClassCreate.FlatStyle = FlatStyle.Flat;
            btnAddClassCreate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddClassCreate.ForeColor = Color.Black;
            btnAddClassCreate.Location = new Point(335, 149);
            btnAddClassCreate.Name = "btnAddClassCreate";
            btnAddClassCreate.Size = new Size(100, 40);
            btnAddClassCreate.TabIndex = 17;
            btnAddClassCreate.Text = "+ Create";
            btnAddClassCreate.UseVisualStyleBackColor = false;
            btnAddClassCreate.Click += btnAddClassCreate_Click;
            // 
            // lblAddClass3
            // 
            lblAddClass3.AutoSize = true;
            lblAddClass3.BackColor = Color.Silver;
            lblAddClass3.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddClass3.Location = new Point(389, 33);
            lblAddClass3.Name = "lblAddClass3";
            lblAddClass3.Size = new Size(55, 16);
            lblAddClass3.TabIndex = 15;
            lblAddClass3.Text = "Optional";
            // 
            // lblAddClass2
            // 
            lblAddClass2.AutoSize = true;
            lblAddClass2.BackColor = Color.FromArgb(94, 129, 244);
            lblAddClass2.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAddClass2.Location = new Point(320, 33);
            lblAddClass2.Name = "lblAddClass2";
            lblAddClass2.Size = new Size(63, 16);
            lblAddClass2.TabIndex = 16;
            lblAddClass2.Text = "Required*";
            // 
            // lblAddClass4
            // 
            lblAddClass4.AutoSize = true;
            lblAddClass4.BackColor = Color.FromArgb(94, 129, 244);
            lblAddClass4.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddClass4.Location = new Point(20, 33);
            lblAddClass4.Margin = new Padding(0);
            lblAddClass4.Name = "lblAddClass4";
            lblAddClass4.Size = new Size(107, 16);
            lblAddClass4.TabIndex = 10;
            lblAddClass4.Text = "Classroom Name";
            // 
            // lblEAddClass5
            // 
            lblEAddClass5.AutoSize = true;
            lblEAddClass5.BackColor = Color.FromArgb(94, 129, 244);
            lblEAddClass5.Font = new Font("SF Pro Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEAddClass5.Location = new Point(20, 93);
            lblEAddClass5.Margin = new Padding(0);
            lblEAddClass5.Name = "lblEAddClass5";
            lblEAddClass5.Size = new Size(126, 16);
            lblEAddClass5.TabIndex = 11;
            lblEAddClass5.Text = "Classroom Capacity";
            // 
            // txtEAddClassName
            // 
            txtEAddClassName.BorderStyle = BorderStyle.FixedSingle;
            txtEAddClassName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEAddClassName.Location = new Point(12, 52);
            txtEAddClassName.Name = "txtEAddClassName";
            txtEAddClassName.PlaceholderText = "Name of Classroom";
            txtEAddClassName.Size = new Size(730, 27);
            txtEAddClassName.TabIndex = 13;
            // 
            // txtEAddClassCapacity
            // 
            txtEAddClassCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEAddClassCapacity.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEAddClassCapacity.Location = new Point(12, 112);
            txtEAddClassCapacity.Name = "txtEAddClassCapacity";
            txtEAddClassCapacity.PlaceholderText = "Capacity of Classroom";
            txtEAddClassCapacity.Size = new Size(730, 27);
            txtEAddClassCapacity.TabIndex = 14;
            // 
            // lblEAddClass1
            // 
            lblEAddClass1.AutoSize = true;
            lblEAddClass1.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEAddClass1.Location = new Point(305, 8);
            lblEAddClass1.Margin = new Padding(0);
            lblEAddClass1.Name = "lblEAddClass1";
            lblEAddClass1.Size = new Size(159, 25);
            lblEAddClass1.TabIndex = 12;
            lblEAddClass1.Text = "Add Classroom";
            // 
            // AddClassroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 196);
            Controls.Add(btnAddClassCreate);
            Controls.Add(lblAddClass3);
            Controls.Add(lblAddClass2);
            Controls.Add(lblAddClass4);
            Controls.Add(lblEAddClass5);
            Controls.Add(txtEAddClassName);
            Controls.Add(txtEAddClassCapacity);
            Controls.Add(lblEAddClass1);
            Name = "AddClassroomForm";
            Text = "AddClassroomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RoundButton btnAddClassCreate;
        private Label lblAddClass3;
        private Label lblAddClass2;
        private Label lblAddClass4;
        private Label lblEAddClass5;
        private TextBox txtEAddClassName;
        private TextBox txtEAddClassCapacity;
        private Label lblEAddClass1;
    }
}