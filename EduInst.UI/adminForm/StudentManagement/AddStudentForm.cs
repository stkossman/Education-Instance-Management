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
    public partial class AddStudentForm : Form
    {
        private EduInstContext _context;
        private StudentRepository _studentRepository;
        private StudentsControl _studentsControl;
        private UnitOfWork _unitOfWork;
        public AddStudentForm(StudentsControl studentsControl, GroupsControl groupsControl)
        {
            InitializeComponent();
            _studentsControl = studentsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var groups = _context.Groups.ToList();
            cmbStudentGroups.DataSource = groups;
            cmbStudentGroups.DisplayMember = "Name";
            cmbStudentGroups.ValueMember = "Id";
        }

        private void btnAddStudentCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtStudentFirstName.Text.Trim();
            string lastName = txtStudentLastName.Text.Trim();
            string phone = txtStudentPhone.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in both first and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = GenUsername(firstName, lastName);

            var selectedGroupId = (int)cmbStudentGroups.SelectedValue;
            var selectedGroup = _context.Groups.FirstOrDefault(g => g.Id == selectedGroupId);

            if (selectedGroup == null)
            {
                MessageBox.Show("Please select a valid group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var newUser = new User
            {
                Username = username,
                Password = phone,
                Role = "Student",
                DateRegister = DateTime.Now
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();


            var newStudent = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dtpStudentBirth.Value,
                Phone = phone,
                Email = txtStudentEmail.Text.Trim(),
                Group = selectedGroup,
                UserId = newUser.Id,
                User = newUser
            };


            _context.Students.Add(newStudent);
            _context.SaveChanges();

            _studentsControl.displayData();
            MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
