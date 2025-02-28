using EduInst.DAL.Context;
using EduInst.PL;
using EduInst.PL.Schedule;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;

namespace EduInst.UI
{
    public partial class adminForm : Form
    {
        private GroupsControl groupsControl;
        private SubjectsControl subjectsControl;
        private StudentsControl studentsControl;
        private EmployeesControl employeesControl;
        private DashboardControl dashboardControl;
        private ScheduleControl scheduleControl;
        private ClassroomsControl classroomsControl;

        public adminForm()
        {
            InitializeComponent();
        }

        private Image defaultDash;
        private Image defaultGroups;
        private Image defaultSubjects;
        private Image defaultStudents;
        private Image defaultEmployees;
        private Image defaultSchedule;
        private Image defaultClassrooms;
        private Image defaultLoadData;
        private Image defaultLogout;

        private Image hoverDash;
        private Image hoverGroups;
        private Image hoverSubjects;
        private Image hoverStudents;
        private Image hoverEmployees;
        private Image hoverSchedule;
        private Image hoverClassrooms;
        private Image hoverLoadData;
        private Image hoverLogout;

        private void MainForm_Load(object sender, EventArgs e)
        {
            defaultDash = PL.Properties.Resources.dashboard;
            defaultGroups = PL.Properties.Resources.groups;
            defaultSubjects = PL.Properties.Resources.subjects;
            defaultStudents = PL.Properties.Resources.students;
            defaultEmployees = PL.Properties.Resources.employees;
            defaultSchedule = PL.Properties.Resources.schedule;
            defaultClassrooms = PL.Properties.Resources.classroom;
            defaultLoadData = PL.Properties.Resources.loaddata;
            defaultLogout = PL.Properties.Resources.logout;

            hoverDash = PL.Properties.Resources.dashboard_hover;
            hoverGroups = PL.Properties.Resources.groups_hover;
            hoverSubjects = PL.Properties.Resources.subjects_hover;
            hoverStudents = PL.Properties.Resources.students_hover;
            hoverEmployees = PL.Properties.Resources.employee_hover;
            hoverSchedule = PL.Properties.Resources.schedule_hover;
            hoverClassrooms = PL.Properties.Resources.classroom_hover;
            hoverLoadData = PL.Properties.Resources.loaddata_hover;
            hoverLogout = PL.Properties.Resources.logout_hover;
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(panel.Width - 10, 0, 10, panel.Height),
                Color.FromArgb(80, Color.Black),
                Color.Transparent,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(panel.Width - 10, 0, 10, panel.Height));
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

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.FromArgb(94, 129, 244);
            btnDashboard.Image = hoverDash;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.FromArgb(0, 0, 0);
            btnDashboard.Image = defaultDash;
        }

        private void btnGroups_MouseHover(object sender, EventArgs e)
        {
            btnGroups.ForeColor = Color.FromArgb(94, 129, 244);
            btnGroups.Image = hoverGroups;
        }

        private void btnGroups_MouseLeave(object sender, EventArgs e)
        {
            btnGroups.ForeColor = Color.FromArgb(0, 0, 0);
            btnGroups.Image = defaultGroups;
        }

        private void btnSubjects_MouseHover(object sender, EventArgs e)
        {
            btnSubjects.ForeColor = Color.FromArgb(94, 129, 244);
            btnSubjects.Image = hoverSubjects;
        }

        private void btnSubjects_MouseLeave(object sender, EventArgs e)
        {
            btnSubjects.ForeColor = Color.FromArgb(0, 0, 0);
            btnSubjects.Image = defaultSubjects;
        }

        private void btnStudents_MouseHover(object sender, EventArgs e)
        {
            btnStudents.ForeColor = Color.FromArgb(94, 129, 244);
            btnStudents.Image = hoverStudents;
        }

        private void btnStudents_MouseLeave(object sender, EventArgs e)
        {
            btnStudents.ForeColor = Color.FromArgb(0, 0, 0);
            btnStudents.Image = defaultStudents;
        }

        private void btnEmployees_MouseHover(object sender, EventArgs e)
        {
            btnEmployees.ForeColor = Color.FromArgb(94, 129, 244);
            btnEmployees.Image = hoverEmployees;
        }

        private void btnEmployees_MouseLeave(object sender, EventArgs e)
        {
            btnEmployees.ForeColor = Color.FromArgb(0, 0, 0);
            btnEmployees.Image = defaultEmployees;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            dashboardControl = new DashboardControl(context);

            pnlDashboard.Visible = true;
            pnlGroups.Visible = false;
            pnlSubjects.Visible = false;
            pnlStudents.Visible = false;
            pnlEmployees.Visible = false;
            pnlSchedule.Visible = false;
            pnlClassrooms.Visible = false;

            pnlDashboard.DisplayStudents();
            pnlDashboard.DisplayTeachers();
            pnlDashboard.DisplayGroups();
            pnlDashboard.DisplayClassrooms();
            pnlDashboard.DisplayTodaySchedule();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            pnlGroups.Visible = true;
            pnlSubjects.Visible = false;
            pnlStudents.Visible = false;
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;
            pnlSchedule.Visible = false;
            pnlClassrooms.Visible = false;

            pnlGroups.displayData();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            pnlSubjects.Visible = true;
            pnlGroups.Visible = false;
            pnlStudents.Visible = false;
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;
            pnlSchedule.Visible = false;
            pnlClassrooms.Visible = false;

            pnlSubjects.displayData();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            pnlStudents.Visible = true;
            pnlGroups.Visible = false;
            pnlSubjects.Visible = false;
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;
            pnlSchedule.Visible = false;
            pnlClassrooms.Visible = false;

            pnlStudents.displayData();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

            pnlStudents.Visible = false;
            pnlGroups.Visible = false;
            pnlSubjects.Visible = false;
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;
            pnlSchedule.Visible = false;
            pnlClassrooms.Visible = false;

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlEmployees.Visible = true;
            pnlStudents.Visible = false;
            pnlGroups.Visible = false;
            pnlSubjects.Visible = false;
            pnlDashboard.Visible = false;
            pnlSchedule.Visible = false;
            pnlClassrooms.Visible = false;

            pnlEmployees.displayData();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            pnlSchedule.Visible = true;
            pnlStudents.Visible = false;
            pnlGroups.Visible = false;
            pnlSubjects.Visible = false;
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;
            pnlClassrooms.Visible = false;

            pnlSchedule.InitUI();
            pnlSchedule.LoadSchedule();
        }

        private void btnClassrooms_Click(object sender, EventArgs e)
        {
            pnlClassrooms.Visible = true;
            pnlSchedule.Visible = false;
            pnlStudents.Visible = false;
            pnlGroups.Visible = false;
            pnlSubjects.Visible = false;
            pnlDashboard.Visible = false;
            pnlEmployees.Visible = false;

            pnlClassrooms.displayData();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            pnlDashboard.DisplayStudents();
            pnlDashboard.DisplayTeachers();
            pnlDashboard.DisplayGroups();
            pnlDashboard.DisplayClassrooms();
            pnlDashboard.DisplayTodaySchedule();

            pnlGroups.displayData();
            pnlSubjects.displayData();
            pnlStudents.displayData();
            pnlEmployees.displayData();
            pnlSchedule.InitUI();
            pnlSchedule.LoadSchedule();
            pnlClassrooms.displayData();
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

        private void btnClassrooms_MouseHover(object sender, EventArgs e)
        {
            btnClassrooms.ForeColor = Color.FromArgb(94, 129, 244);
            btnClassrooms.Image = hoverClassrooms;
        }

        private void btnClassrooms_MouseLeave(object sender, EventArgs e)
        {
            btnClassrooms.ForeColor = Color.FromArgb(0, 0, 0);
            btnClassrooms.Image = defaultClassrooms;
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
