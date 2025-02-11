using EduInst.DAL.Context;
using EduInst.PL.Schedule;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduInst.PL.StudentForm
{
    public partial class studentForm : Form
    {
        private readonly int _userId;
        private readonly string _userRole;

        private GroupsControl groupsControl;
        private SubjectsControl subjectsControl;
        private StudentsControl studentsControl;
        private EmployeesControl employeesControl;
        private DashboardControl dashboardControl;
        private ScheduleControl scheduleControl;
        private ClassroomsControl classroomsControl;

        public studentForm(int userId, string userRole)
        {
            InitializeComponent();
            _userId = userId;
            _userRole = userRole;
        }

        private Image defaultDash;
        private Image defaultLoadData;
        private Image defaultLogout;
        private Image defaultSchedule;

        private Image hoverDash;
        private Image hoverLoadData;
        private Image hoverLogout;
        private Image hoverSchedule;

        private void studentForm_Load(object sender, EventArgs e)
        {
            defaultDash = PL.Properties.Resources.dashboard;
            defaultLoadData = PL.Properties.Resources.loaddata;
            defaultLogout = PL.Properties.Resources.logout;
            defaultSchedule = PL.Properties.Resources.schedule;

            hoverDash = PL.Properties.Resources.dashboard_hover;
            hoverLoadData = PL.Properties.Resources.loaddata_hover;
            hoverLogout = PL.Properties.Resources.logout_hover;
            hoverSchedule = PL.Properties.Resources.schedule_hover;

            LoadUserData();
        }

        private void LoadUserData()
        {
            using (var _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options))
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == _userId);
                if (user != null)
                {
                    string fullName = user.Username;

                    if (_userRole == "Student")
                    {
                        var student = _context.Students.FirstOrDefault(s => s.UserId == _userId);
                        if (student != null)
                        {
                            fullName = $"{student.FirstName} {student.LastName}";
                            lblUser.Text = fullName;
                        }
                    }
                }
            }
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, panel.Height - 5, panel.Width, 5),
                Color.FromArgb(80, Color.Black),
                Color.Transparent,
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(0, panel.Height - 5, panel.Width, 5));
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlScheduleStudent.Visible = true;

            pnlScheduleStudent.InitUI();
            pnlScheduleStudent.LoadSchedule(pnlScheduleStudent.GetSelectedData());
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            pnlScheduleStudent.InitUI();
            pnlScheduleStudent.LoadSchedule(pnlScheduleStudent.GetSelectedData());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm login = new loginForm();
                login.Show();

                this.Hide();
            }
        }

        private void btnSchedule_MouseHover(object sender, EventArgs e)
        {
            btnSchedule.ForeColor = Color.FromArgb(94, 129, 244);
            btnSchedule.Image = hoverSchedule;
        }

        private void btnSchedule_MouseLeave(object sender, EventArgs e)
        {
            btnSchedule.ForeColor = Color.FromArgb(0, 0, 0);
            btnSchedule.Image = defaultSchedule;
        }

        private void btnLoadData_MouseHover(object sender, EventArgs e)
        {
            btnLoadData.ForeColor = Color.FromArgb(94, 129, 244);
            btnLoadData.Image = hoverLoadData;
        }

        private void btnLoadData_MouseLeave(object sender, EventArgs e)
        {
            btnLoadData.ForeColor = Color.FromArgb(0, 0, 0);
            btnLoadData.Image = defaultLoadData;
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.FromArgb(94, 129, 244);
            btnLogOut.Image = hoverLogout;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.FromArgb(0, 0, 0);
            btnLogOut.Image = defaultLogout;
        }
    }
}
