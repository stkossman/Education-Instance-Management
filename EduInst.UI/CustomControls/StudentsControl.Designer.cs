namespace EduInst.PL
{
    partial class StudentsControl
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
            tbSearchStudent = new TextBox();
            btnEditStudent = new CustomControls.RoundButton();
            btnDelStudent = new CustomControls.RoundButton();
            btnAddStudent = new CustomControls.RoundButton();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // tbSearchStudent
            // 
            tbSearchStudent.ForeColor = SystemColors.MenuText;
            tbSearchStudent.Location = new Point(601, 548);
            tbSearchStudent.Name = "tbSearchStudent";
            tbSearchStudent.PlaceholderText = "Search Student";
            tbSearchStudent.Size = new Size(240, 23);
            tbSearchStudent.TabIndex = 8;
            tbSearchStudent.TextChanged += tbSearchStudent_TextChanged;
            // 
            // btnEditStudent
            // 
            btnEditStudent.BackColor = Color.FromArgb(255, 192, 128);
            btnEditStudent.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditStudent.BorderRadius = 40;
            btnEditStudent.BorderSize = 0;
            btnEditStudent.FlatAppearance.BorderSize = 0;
            btnEditStudent.FlatStyle = FlatStyle.Flat;
            btnEditStudent.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditStudent.ForeColor = Color.White;
            btnEditStudent.Location = new Point(109, 538);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(100, 40);
            btnEditStudent.TabIndex = 5;
            btnEditStudent.Text = "Edit";
            btnEditStudent.UseVisualStyleBackColor = false;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // btnDelStudent
            // 
            btnDelStudent.BackColor = Color.FromArgb(255, 128, 128);
            btnDelStudent.BorderColor = Color.FromArgb(94, 129, 244);
            btnDelStudent.BorderRadius = 40;
            btnDelStudent.BorderSize = 0;
            btnDelStudent.FlatAppearance.BorderSize = 0;
            btnDelStudent.FlatStyle = FlatStyle.Flat;
            btnDelStudent.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelStudent.ForeColor = Color.White;
            btnDelStudent.Location = new Point(215, 538);
            btnDelStudent.Name = "btnDelStudent";
            btnDelStudent.Size = new Size(100, 40);
            btnDelStudent.TabIndex = 6;
            btnDelStudent.Text = "Delete";
            btnDelStudent.UseVisualStyleBackColor = false;
            btnDelStudent.Click += btnDelStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(94, 129, 244);
            btnAddStudent.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddStudent.BorderRadius = 40;
            btnAddStudent.BorderSize = 0;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(3, 538);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(100, 40);
            btnAddStudent.TabIndex = 7;
            btnAddStudent.Text = "Add New";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.GridColor = SystemColors.InfoText;
            dgvStudents.Location = new Point(3, 3);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(838, 520);
            dgvStudents.TabIndex = 4;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // StudentsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbSearchStudent);
            Controls.Add(btnEditStudent);
            Controls.Add(btnDelStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dgvStudents);
            Name = "StudentsControl";
            Size = new Size(844, 593);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearchStudent;
        private CustomControls.RoundButton btnEditStudent;
        private CustomControls.RoundButton btnDelStudent;
        private CustomControls.RoundButton btnAddStudent;
        private DataGridView dgvStudents;
    }
}
