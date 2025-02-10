namespace EduInst.PL
{
    partial class SubjectsControl
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
            tbSearchSubject = new TextBox();
            btnEditSubject = new CustomControls.RoundButton();
            btnDelSubject = new CustomControls.RoundButton();
            btnAddSubject = new CustomControls.RoundButton();
            dgvSubjects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // tbSearchSubject
            // 
            tbSearchSubject.ForeColor = SystemColors.MenuText;
            tbSearchSubject.Location = new Point(601, 545);
            tbSearchSubject.Name = "tbSearchSubject";
            tbSearchSubject.PlaceholderText = "Search Subject";
            tbSearchSubject.Size = new Size(240, 23);
            tbSearchSubject.TabIndex = 8;
            tbSearchSubject.TextChanged += tbSearchSubject_TextChanged;
            // 
            // btnEditSubject
            // 
            btnEditSubject.BackColor = Color.FromArgb(255, 192, 128);
            btnEditSubject.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditSubject.BorderRadius = 40;
            btnEditSubject.BorderSize = 0;
            btnEditSubject.FlatAppearance.BorderSize = 0;
            btnEditSubject.FlatStyle = FlatStyle.Flat;
            btnEditSubject.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditSubject.ForeColor = Color.White;
            btnEditSubject.Location = new Point(109, 535);
            btnEditSubject.Name = "btnEditSubject";
            btnEditSubject.Size = new Size(100, 40);
            btnEditSubject.TabIndex = 5;
            btnEditSubject.Text = "Edit";
            btnEditSubject.UseVisualStyleBackColor = false;
            btnEditSubject.Click += btnEditSubject_Click;
            // 
            // btnDelSubject
            // 
            btnDelSubject.BackColor = Color.FromArgb(255, 128, 128);
            btnDelSubject.BorderColor = Color.FromArgb(94, 129, 244);
            btnDelSubject.BorderRadius = 40;
            btnDelSubject.BorderSize = 0;
            btnDelSubject.FlatAppearance.BorderSize = 0;
            btnDelSubject.FlatStyle = FlatStyle.Flat;
            btnDelSubject.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelSubject.ForeColor = Color.White;
            btnDelSubject.Location = new Point(215, 535);
            btnDelSubject.Name = "btnDelSubject";
            btnDelSubject.Size = new Size(100, 40);
            btnDelSubject.TabIndex = 6;
            btnDelSubject.Text = "Delete";
            btnDelSubject.UseVisualStyleBackColor = false;
            btnDelSubject.Click += btnDelSubject_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.BackColor = Color.FromArgb(94, 129, 244);
            btnAddSubject.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddSubject.BorderRadius = 40;
            btnAddSubject.BorderSize = 0;
            btnAddSubject.FlatAppearance.BorderSize = 0;
            btnAddSubject.FlatStyle = FlatStyle.Flat;
            btnAddSubject.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSubject.ForeColor = Color.White;
            btnAddSubject.Location = new Point(3, 535);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(100, 40);
            btnAddSubject.TabIndex = 7;
            btnAddSubject.Text = "Add New";
            btnAddSubject.UseVisualStyleBackColor = false;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.GridColor = SystemColors.InfoText;
            dgvSubjects.Location = new Point(3, 0);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(838, 520);
            dgvSubjects.TabIndex = 4;
            dgvSubjects.CellClick += dgvSubjects_CellClick;
            // 
            // SubjectsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbSearchSubject);
            Controls.Add(btnEditSubject);
            Controls.Add(btnDelSubject);
            Controls.Add(btnAddSubject);
            Controls.Add(dgvSubjects);
            Name = "SubjectsControl";
            Size = new Size(844, 593);
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearchSubject;
        private CustomControls.RoundButton btnEditSubject;
        private CustomControls.RoundButton btnDelSubject;
        private CustomControls.RoundButton btnAddSubject;
        private DataGridView dgvSubjects;
    }
}
