namespace EduInst.PL
{
    partial class EmployeesControl
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
            tbSearchEmployee = new TextBox();
            btnEditEmployee = new CustomControls.RoundButton();
            btnDelEmployee = new CustomControls.RoundButton();
            btnAddEmployee = new CustomControls.RoundButton();
            dgvEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // tbSearchEmployee
            // 
            tbSearchEmployee.ForeColor = SystemColors.MenuText;
            tbSearchEmployee.Location = new Point(601, 548);
            tbSearchEmployee.Name = "tbSearchEmployee";
            tbSearchEmployee.PlaceholderText = "Search Employee";
            tbSearchEmployee.Size = new Size(240, 23);
            tbSearchEmployee.TabIndex = 13;
            tbSearchEmployee.TextChanged += tbSearchEmployee_TextChanged;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(255, 192, 128);
            btnEditEmployee.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditEmployee.BorderRadius = 40;
            btnEditEmployee.BorderSize = 0;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditEmployee.ForeColor = Color.White;
            btnEditEmployee.Location = new Point(109, 538);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(100, 40);
            btnEditEmployee.TabIndex = 10;
            btnEditEmployee.Text = "Edit";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnDelEmployee
            // 
            btnDelEmployee.BackColor = Color.FromArgb(255, 128, 128);
            btnDelEmployee.BorderColor = Color.FromArgb(94, 129, 244);
            btnDelEmployee.BorderRadius = 40;
            btnDelEmployee.BorderSize = 0;
            btnDelEmployee.FlatAppearance.BorderSize = 0;
            btnDelEmployee.FlatStyle = FlatStyle.Flat;
            btnDelEmployee.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelEmployee.ForeColor = Color.White;
            btnDelEmployee.Location = new Point(215, 538);
            btnDelEmployee.Name = "btnDelEmployee";
            btnDelEmployee.Size = new Size(100, 40);
            btnDelEmployee.TabIndex = 11;
            btnDelEmployee.Text = "Delete";
            btnDelEmployee.UseVisualStyleBackColor = false;
            btnDelEmployee.Click += btnDelEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(94, 129, 244);
            btnAddEmployee.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddEmployee.BorderRadius = 40;
            btnAddEmployee.BorderSize = 0;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(3, 538);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(100, 40);
            btnAddEmployee.TabIndex = 12;
            btnAddEmployee.Text = "Add New";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.GridColor = SystemColors.InfoText;
            dgvEmployees.Location = new Point(3, 3);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(838, 520);
            dgvEmployees.TabIndex = 9;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // EmployeesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbSearchEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnDelEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(dgvEmployees);
            Name = "EmployeesControl";
            Size = new Size(844, 593);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearchEmployee;
        private CustomControls.RoundButton btnEditEmployee;
        private CustomControls.RoundButton btnDelEmployee;
        private CustomControls.RoundButton btnAddEmployee;
        private DataGridView dgvEmployees;
    }
}
