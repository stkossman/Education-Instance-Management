using EduInst.BL;
using EduInst.DAL.Context;
using EduInst.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EduInst.PL
{
    public partial class GroupsControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private GroupRepository _groupRepository;

        public GroupsControl()
        {
            InitializeComponent();
        }

        public GroupsControl(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            displayData();
        }

        public void displayData()
        {
            var groups = _context.Groups.Select(group => new
            {
                group.Id,
                group.Name,
                Students = string.Join(", ", group.Students.Select(s => s.FirstName + " " + s.LastName))
            })
            .ToList();

            dgvGroups.DataSource = groups;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
                _unitOfWork = new UnitOfWork(_context);
            }
        }

        private void GroupsControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm(this);
            addGroupForm.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditGroupGrom editGroupGrom = new EditGroupGrom(this);
            editGroupGrom.Show();
        }

        private int getID;

        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            var groupToDelete = _context.Groups.FirstOrDefault(g => g.Id == getID);

            if (groupToDelete != null)
            {
                _context.Groups.Remove(groupToDelete);
                _context.SaveChanges();
                displayData();
                MessageBox.Show("Group successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Group not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvGroups.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }

        private void tbSearchGroup_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbSearchGroup.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                var groups = _context.Groups.Select(group => new
                {
                    group.Name,
                    Students = string.Join(", ", group.Students.Select(s => s.FirstName + " " + s.LastName))
                })
                .ToList();

                dgvGroups.DataSource = groups;
            }
            else
            {
                var filteredGroups = _context.Groups
                    .Where(g => g.Name.ToLower().Contains(searchTerm) ||
                                g.Students.Any(s => (s.FirstName.ToLower() + " " + s.LastName.ToLower()).Contains(searchTerm)))
                    .Select(group => new
                    {
                        group.Name,
                        Students = string.Join(", ", group.Students.Select(s => s.FirstName + " " + s.LastName))
                    })
                    .ToList();

                dgvGroups.DataSource = filteredGroups;
            }
        }

    }
}

