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
    public partial class EditEmployeeForm : Form
    {
        private EduInstContext _context;
        private TeacherRepository _teacherRepository;
        private EmployeesControl _employeesControl;
        private Teacher _selectedTeacher;

        public EditEmployeeForm(EmployeesControl employeesControl)
        {
            InitializeComponent();
            _employeesControl = employeesControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var teachers = _context.Teachers.Select(teacher => new
            {
                teacher.Id,
                FullName = teacher.FirstName + " " + teacher.LastName
            }).ToList();

            cmbEditTeacherChoose.DataSource = teachers;
            cmbEditTeacherChoose.DisplayMember = "FullName";
            cmbEditTeacherChoose.ValueMember = "Id";
        }

        private void btnEditTeacherEdit_Click(object sender, EventArgs e)
        {
            if (_selectedTeacher == null)
            {
                MessageBox.Show("Please select a teacher to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newFirstName = txtEditTeacherFirstName.Text.Trim();
            string newLastName = txtEditTeacherLastName.Text.Trim();
            string newPhone = txtEditTeacherPhone.Text.Trim();

            bool isNameChanged = newFirstName != _selectedTeacher.FirstName || newLastName != _selectedTeacher.LastName;
            bool isPhoneChanged = newPhone != _selectedTeacher.Phone;

            _selectedTeacher.FirstName = txtEditTeacherFirstName.Text.Trim();
            _selectedTeacher.LastName = txtEditTeacherLastName.Text.Trim();
            _selectedTeacher.Phone = txtEditTeacherPhone.Text.Trim();
            _selectedTeacher.Email = txtEditTeacherEmail.Text.Trim();
            _selectedTeacher.DateOfBirth = dtpEditTeacherBirth.Value;

            var user = _context.Users.FirstOrDefault(u => u.Id == _selectedTeacher.UserId);

            if (user != null)
            {
                if (isNameChanged)
                {
                    user.Username = $"{_selectedTeacher.FirstName.ToLower()}.{_selectedTeacher.LastName.ToLower()}";
                }
                if (isPhoneChanged)
                {
                    user.Password = _selectedTeacher.Phone;
                }
            }

            _context.SaveChanges();
            _employeesControl.displayData();

            MessageBox.Show("Teacher edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbEditTeacherChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTeacherId = (int)cmbEditTeacherChoose.SelectedValue;
            _selectedTeacher = _context.Teachers.FirstOrDefault(t => t.Id == selectedTeacherId);

            txtEditTeacherFirstName.Text = _selectedTeacher.FirstName;
            txtEditTeacherLastName.Text = _selectedTeacher.LastName;
            txtEditTeacherPhone.Text = _selectedTeacher.Phone;
            txtEditTeacherEmail.Text = _selectedTeacher.Email;
            dtpEditTeacherBirth.Value = _selectedTeacher.DateOfBirth;
        }
    }
}
