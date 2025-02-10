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
    public partial class AddEmployeeForm : Form
    {
        private EduInstContext _context;
        private TeacherRepository _teacherRepository;
        private EmployeesControl _employeesControl;

        public AddEmployeeForm(EmployeesControl employeesControl)
        {
            InitializeComponent();
            _employeesControl = employeesControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void btnAddTeacherCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtTeacherFirstName.Text.Trim();
            string lastName = txtTeacherLastName.Text.Trim();
            string phone = txtTeacherPhone.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in both first and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = GenUsername(firstName, lastName);

            var newUser = new User
            {
                Username = username,
                Password = phone,
                Role = "Teacher",
                DateRegister = DateTime.Now
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            var newTeacher = new Teacher
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Email = txtTeacherEmail.Text.Trim(),
                DateOfBirth = dtpTeacherBirth.Value,
                UserId = newUser.Id,
                User = newUser
            };

            _context.Teachers.Add(newTeacher);
            _context.SaveChanges();

            _employeesControl.displayData();
            MessageBox.Show("Teacher added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
