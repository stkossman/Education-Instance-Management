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
    public partial class AddClassroomForm : Form
    {
        private EduInstContext _context;
        private ClassroomsControl _classroomsControl;

        public AddClassroomForm(ClassroomsControl classroomsControl)
        {
            InitializeComponent();
            _classroomsControl = classroomsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void btnAddClassCreate_Click(object sender, EventArgs e)
        {
            int capacity;
            if (!int.TryParse(txtEAddClassCapacity.Text, out capacity))
            {
                MessageBox.Show("Capacity must be an integer number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (capacity <= 0)
            {
                MessageBox.Show("Capacity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newClassroom = new Classroom
            {
                Name = txtEAddClassName.Text.Trim(),
                Capacity = capacity
            };

            _context.Classrooms.Add(newClassroom);
            _context.SaveChanges();

            _classroomsControl.displayData();

            MessageBox.Show("Classroom added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
