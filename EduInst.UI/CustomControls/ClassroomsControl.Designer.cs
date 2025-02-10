namespace EduInst.PL
{
    partial class ClassroomsControl
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
            tbSearchClass = new TextBox();
            btnEditClass = new CustomControls.RoundButton();
            btnDelClass = new CustomControls.RoundButton();
            btnAddClass = new CustomControls.RoundButton();
            dgvClassrooms = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClassrooms).BeginInit();
            SuspendLayout();
            // 
            // tbSearchClass
            // 
            tbSearchClass.ForeColor = SystemColors.MenuText;
            tbSearchClass.Location = new Point(601, 548);
            tbSearchClass.Name = "tbSearchClass";
            tbSearchClass.PlaceholderText = "Search Class";
            tbSearchClass.Size = new Size(240, 23);
            tbSearchClass.TabIndex = 8;
            tbSearchClass.TextChanged += tbSearchClass_TextChanged;
            // 
            // btnEditClass
            // 
            btnEditClass.BackColor = Color.FromArgb(255, 192, 128);
            btnEditClass.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditClass.BorderRadius = 40;
            btnEditClass.BorderSize = 0;
            btnEditClass.FlatAppearance.BorderSize = 0;
            btnEditClass.FlatStyle = FlatStyle.Flat;
            btnEditClass.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditClass.ForeColor = Color.White;
            btnEditClass.Location = new Point(109, 538);
            btnEditClass.Name = "btnEditClass";
            btnEditClass.Size = new Size(100, 40);
            btnEditClass.TabIndex = 5;
            btnEditClass.Text = "Edit";
            btnEditClass.UseVisualStyleBackColor = false;
            btnEditClass.Click += btnEditClass_Click;
            // 
            // btnDelClass
            // 
            btnDelClass.BackColor = Color.FromArgb(255, 128, 128);
            btnDelClass.BorderColor = Color.FromArgb(94, 129, 244);
            btnDelClass.BorderRadius = 40;
            btnDelClass.BorderSize = 0;
            btnDelClass.FlatAppearance.BorderSize = 0;
            btnDelClass.FlatStyle = FlatStyle.Flat;
            btnDelClass.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelClass.ForeColor = Color.White;
            btnDelClass.Location = new Point(215, 538);
            btnDelClass.Name = "btnDelClass";
            btnDelClass.Size = new Size(100, 40);
            btnDelClass.TabIndex = 6;
            btnDelClass.Text = "Delete";
            btnDelClass.UseVisualStyleBackColor = false;
            btnDelClass.Click += btnDelClass_Click;
            // 
            // btnAddClass
            // 
            btnAddClass.BackColor = Color.FromArgb(94, 129, 244);
            btnAddClass.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddClass.BorderRadius = 40;
            btnAddClass.BorderSize = 0;
            btnAddClass.FlatAppearance.BorderSize = 0;
            btnAddClass.FlatStyle = FlatStyle.Flat;
            btnAddClass.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddClass.ForeColor = Color.White;
            btnAddClass.Location = new Point(3, 538);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(100, 40);
            btnAddClass.TabIndex = 7;
            btnAddClass.Text = "Add New";
            btnAddClass.UseVisualStyleBackColor = false;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // dgvClassrooms
            // 
            dgvClassrooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassrooms.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvClassrooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassrooms.GridColor = SystemColors.InfoText;
            dgvClassrooms.Location = new Point(3, 3);
            dgvClassrooms.Name = "dgvClassrooms";
            dgvClassrooms.Size = new Size(838, 520);
            dgvClassrooms.TabIndex = 4;
            dgvClassrooms.CellClick += dgvClassrooms_CellClick;
            // 
            // ClassroomsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbSearchClass);
            Controls.Add(btnEditClass);
            Controls.Add(btnDelClass);
            Controls.Add(btnAddClass);
            Controls.Add(dgvClassrooms);
            Name = "ClassroomsControl";
            Size = new Size(844, 593);
            ((System.ComponentModel.ISupportInitialize)dgvClassrooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearchClass;
        private CustomControls.RoundButton btnEditClass;
        private CustomControls.RoundButton btnDelClass;
        private CustomControls.RoundButton btnAddClass;
        private DataGridView dgvClassrooms;
    }
}
