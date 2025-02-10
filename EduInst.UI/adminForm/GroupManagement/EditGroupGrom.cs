using EduInst.BL;
using EduInst.DAL.Context;
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

namespace EduInst.PL
{
    public partial class EditGroupGrom : Form
    {
        private EduInstContext _context;
        private GroupRepository _groupRepository;
        private GroupsControl _groupsControl;

        public EditGroupGrom(GroupsControl groupsControl)
        {
            InitializeComponent();
            _groupsControl = groupsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void btnEditGroupEdit_Click(object sender, EventArgs e)
        {
            string oldGroupName = txtEditGroupOldName.Text.Trim();
            string newGroupName = txtEditGroupNewName.Text.Trim();

            if (string.IsNullOrEmpty(oldGroupName) || string.IsNullOrEmpty(newGroupName))
            {
                MessageBox.Show("Please fill in both the old and new group names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var groupToEdit = _context.Groups.FirstOrDefault(g => g.Name == oldGroupName);

            if (groupToEdit != null)
            {
                groupToEdit.Name = newGroupName;

                try
                {
                    _context.SaveChanges();
                    _groupsControl.displayData();
                    MessageBox.Show("Group name successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the group: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Group not found with the provided old name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
