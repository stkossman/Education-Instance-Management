using EduInst.BL;
using EduInst.DAL.Context;
using EduInst.DAL.Models;
using EduInst.PL.LoginForm;
using EduInst.PL.StudentForm;
using EduInst.PL.TeacherForm;
using EduInst.UI;
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
    public partial class loginForm : Form
    {
        private EduInstContext _context;
        private UserRepository _userRepository;
        public loginForm()
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void loginBtnSingIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTxbUsername.Text) || string.IsNullOrWhiteSpace(loginTxbPassword.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Username == loginTxbUsername.Text && u.Password == loginTxbPassword.Text);

                if (user != null)
                {
                    SessionManager.LoggedInUserId = user.Id;
                    SessionManager.Role = user.Role;

                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.Role == "admin")
                    {
                        adminForm AdminForm = new adminForm();
                        AdminForm.Show();

                        this.Hide();
                    }
                    else if (user.Role == "Teacher")
                    {
                        teacherForm TeacherForm = new teacherForm();
                        TeacherForm.Show();

                        this.Hide();
                    }
                    else if (user.Role == "Student")
                    {
                        studentForm StudentForm = new studentForm();
                        StudentForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginLblForgotPass_Click(object sender, EventArgs e)
        {
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter your username", "Forgot password", "");
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    MessageBox.Show($"Your password is: {user.Password}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
