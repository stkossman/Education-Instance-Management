namespace EduInst.PL
{
    partial class GroupsControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvGroups = new DataGridView();
            btnAddGroup = new CustomControls.RoundButton();
            btnDelGroup = new CustomControls.RoundButton();
            btnEditGroup = new CustomControls.RoundButton();
            tbSearchGroup = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            SuspendLayout();
            // 
            // dgvGroups
            // 
            dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroups.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGroups.BackgroundColor = Color.FromArgb(246, 247, 251);
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGroups.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGroups.GridColor = SystemColors.InfoText;
            dgvGroups.Location = new Point(3, 3);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.Size = new Size(838, 520);
            dgvGroups.TabIndex = 0;
            dgvGroups.CellClick += dgvGroups_CellClick;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = Color.FromArgb(94, 129, 244);
            btnAddGroup.BorderColor = Color.FromArgb(94, 129, 244);
            btnAddGroup.BorderRadius = 40;
            btnAddGroup.BorderSize = 0;
            btnAddGroup.FlatAppearance.BorderSize = 0;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddGroup.ForeColor = Color.White;
            btnAddGroup.Location = new Point(3, 538);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(100, 40);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.Text = "Add New";
            btnAddGroup.UseVisualStyleBackColor = false;
            btnAddGroup.Click += btnAdd_Click;
            // 
            // btnDelGroup
            // 
            btnDelGroup.BackColor = Color.FromArgb(255, 128, 128);
            btnDelGroup.BorderColor = Color.FromArgb(94, 129, 244);
            btnDelGroup.BorderRadius = 40;
            btnDelGroup.BorderSize = 0;
            btnDelGroup.FlatAppearance.BorderSize = 0;
            btnDelGroup.FlatStyle = FlatStyle.Flat;
            btnDelGroup.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelGroup.ForeColor = Color.White;
            btnDelGroup.Location = new Point(215, 538);
            btnDelGroup.Name = "btnDelGroup";
            btnDelGroup.Size = new Size(100, 40);
            btnDelGroup.TabIndex = 2;
            btnDelGroup.Text = "Delete";
            btnDelGroup.UseVisualStyleBackColor = false;
            btnDelGroup.Click += btnDelGroup_Click;
            // 
            // btnEditGroup
            // 
            btnEditGroup.BackColor = Color.FromArgb(255, 192, 128);
            btnEditGroup.BorderColor = Color.FromArgb(94, 129, 244);
            btnEditGroup.BorderRadius = 40;
            btnEditGroup.BorderSize = 0;
            btnEditGroup.FlatAppearance.BorderSize = 0;
            btnEditGroup.FlatStyle = FlatStyle.Flat;
            btnEditGroup.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditGroup.ForeColor = Color.White;
            btnEditGroup.Location = new Point(109, 538);
            btnEditGroup.Name = "btnEditGroup";
            btnEditGroup.Size = new Size(100, 40);
            btnEditGroup.TabIndex = 2;
            btnEditGroup.Text = "Edit";
            btnEditGroup.UseVisualStyleBackColor = false;
            btnEditGroup.Click += Edit_Click;
            // 
            // tbSearchGroup
            // 
            tbSearchGroup.ForeColor = SystemColors.MenuText;
            tbSearchGroup.Location = new Point(601, 548);
            tbSearchGroup.Name = "tbSearchGroup";
            tbSearchGroup.PlaceholderText = "Search Group";
            tbSearchGroup.Size = new Size(240, 23);
            tbSearchGroup.TabIndex = 3;
            tbSearchGroup.TextChanged += tbSearchGroup_TextChanged;
            // 
            // GroupsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 247, 251);
            Controls.Add(tbSearchGroup);
            Controls.Add(btnEditGroup);
            Controls.Add(btnDelGroup);
            Controls.Add(btnAddGroup);
            Controls.Add(dgvGroups);
            Name = "GroupsControl";
            Size = new Size(844, 593);
            Load += GroupsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGroups;
        private CustomControls.RoundButton btnAddGroup;
        private CustomControls.RoundButton btnDelGroup;
        private CustomControls.RoundButton btnEditGroup;
        private TextBox tbSearchGroup;
    }
}
