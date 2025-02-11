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
    public partial class EditStudentForm : Form
    {
        private EduInstContext _context;
        private StudentRepository _studentRepository;
        private StudentsControl _studentsControl;
        private Student _selectedStudent;
        public EditStudentForm(StudentsControl studentsControl)
        {
            InitializeComponent();
            _studentsControl = studentsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var groups = _context.Groups.ToList();
            cmbEditStudentGroups.DataSource = groups;
            cmbEditStudentGroups.DisplayMember = "Name";
            cmbEditStudentGroups.ValueMember = "Id";

            var students = _context.Students.Select(s => new {s.Id,
                FullName = s.FirstName + " " + s.LastName
            }).ToList();

            cmbEditStudentChoose.DataSource = students;
            cmbEditStudentChoose.DisplayMember = "FullName";
            cmbEditStudentChoose.ValueMember = "Id";
        }

        private void btnEditStudentEdit_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
            {
                MessageBox.Show("Please select a student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newFirstName = txtEditStudentFirstName.Text.Trim();
            string newLastName = txtEditStudentLastName.Text.Trim();
            string newPhone = txtEditStudentPhone.Text.Trim();

            bool isNameChanged = newFirstName != _selectedStudent.FirstName || newLastName != _selectedStudent.LastName;
            bool isPhoneChanged = newPhone != _selectedStudent.Phone;

            _selectedStudent.FirstName = txtEditStudentFirstName.Text.Trim();
            _selectedStudent.LastName = txtEditStudentLastName.Text.Trim();
            _selectedStudent.Phone = txtEditStudentPhone.Text.Trim();
            _selectedStudent.Email = txtEditStudentEmail.Text.Trim();
            _selectedStudent.DateOfBirth = dtpEditStudentBirth.Value;

            int selectedGroupId = (int)cmbEditStudentGroups.SelectedValue;
            _selectedStudent.Group = _context.Groups.FirstOrDefault(g => g.Id == selectedGroupId);

            var user = _context.Users.FirstOrDefault(u => u.Id == _selectedStudent.UserId);
            if (user != null)
            {
                if (isNameChanged)
                {
                    user.Username = GenUsername(newFirstName, newLastName);
                }
                if (isPhoneChanged)
                {
                    user.Password = newPhone;
                }
            }

             _context.SaveChanges();
            _studentsControl.displayData();
            MessageBox.Show("Student edited successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenUsername(string firstName, string lastName)
        {
            string username = $"{firstName.ToLower()}.{lastName.ToLower()}";

            var existingUsernames = _context.Users.Select(u => u.Username).ToList();
            int counter = 1;

            while (existingUsernames.Contains(username))
            {
                username = $"{firstName.ToLower()}.{lastName.ToLower()}{counter}";
                counter++;
            }

            return username;
        }


        private void cmbEditStudentChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedStudentId = (int)cmbEditStudentChoose.SelectedValue;
            _selectedStudent = _context.Students.Include(s => s.Group).FirstOrDefault(s => s.Id == selectedStudentId);

            if (_selectedStudent != null)
            {
                txtEditStudentFirstName.Text = _selectedStudent.FirstName;
                txtEditStudentLastName.Text = _selectedStudent.LastName;
                txtEditStudentPhone.Text = _selectedStudent.Phone;
                txtEditStudentEmail.Text = _selectedStudent.Email;
                dtpEditStudentBirth.Value = _selectedStudent.DateOfBirth;
                cmbEditStudentGroups.SelectedValue = _selectedStudent.GroupId;
            }
        }
    }
}
