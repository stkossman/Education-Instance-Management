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
    public partial class EditClassroomForm : Form
    {
        private EduInstContext _context;
        private ClassroomsControl _classroomsControl;
        private Classroom _selectedClassroom;

        public EditClassroomForm(ClassroomsControl classroomsControl)
        {
            InitializeComponent();
            _classroomsControl = classroomsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var classrooms = _context.Classrooms.Select(c => new
            {
                c.Id,
                Name = c.Name
            }).ToList();
            cmbEditClassChoose.DataSource = classrooms;
            cmbEditClassChoose.DisplayMember = "Name";
            cmbEditClassChoose.ValueMember = "Id";
        }

        private void btnEditStudentEdit_Click(object sender, EventArgs e)
        {
            if (_selectedClassroom == null)
            {
                MessageBox.Show("Please select a classroom to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectedClassroom.Name = txtEditClassName.Text.Trim();
            _selectedClassroom.Capacity = int.Parse(txtEditClassCapacity.Text.Trim());

            _context.SaveChanges();
            _classroomsControl.displayData();

            MessageBox.Show("Classroom edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbEditClassChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClassId = (int)cmbEditClassChoose.SelectedValue;
            _selectedClassroom = _context.Classrooms.FirstOrDefault(c => c.Id == selectedClassId);

            if (_selectedClassroom != null)
            {
                txtEditClassName.Text = _selectedClassroom.Name;
                txtEditClassCapacity.Text = _selectedClassroom.Capacity.ToString();
            }
        }
    }
}
