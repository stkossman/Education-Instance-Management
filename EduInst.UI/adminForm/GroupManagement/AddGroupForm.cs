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

namespace EduInst.PL
{
    public partial class AddGroupForm : Form
    {
        private EduInstContext _context;
        private GroupRepository _groupRepository;
        private GroupsControl _groupsControl;

        public AddGroupForm(GroupsControl groupsControl)
        {
            InitializeComponent();
            _groupsControl = groupsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void btnAddGroupCreate_Click(object sender, EventArgs e)
        {
            var newGroup = new Group
            {
                Name = txtGroupName.Text.Trim()
            };

            _context.Groups.Add(newGroup);
            _context.SaveChanges();

            _groupsControl.displayData();

            MessageBox.Show("Group added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
