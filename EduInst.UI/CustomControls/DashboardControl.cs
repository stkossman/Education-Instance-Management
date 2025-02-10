using EduInst.BL;
using EduInst.DAL.Context;
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
    public partial class DashboardControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;

        public DashboardControl()
        {
            InitializeComponent();
        }

        public DashboardControl(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
            DisplayStudents();
            DisplayTeachers();
            DisplayGroups();
            DisplayClassrooms();
            DisplayTodaySchedule();
        }

        public void DisplayStudents()
        {
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var students = _context.Students.Count();
            lblTotalStudents.Text = students.ToString();
        }

        public void DisplayTeachers()
        {
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var teachers = _context.Teachers.Count();
            lblTotalEmployees.Text = teachers.ToString();
        }

        public void DisplayClassrooms()
        {
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var classrooms = _context.Classrooms.Count();
            lblTotalClassrooms.Text = classrooms.ToString();
        }

        public void DisplayGroups()
        {
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var groups = _context.Groups.Count();
            lblTotalGroups.Text = groups.ToString();
        }

        public void DisplayTodaySchedule()
        {
            DateTime today = DateTime.Today;

            var todaySchedule = _context.Schedules
                .Include(s => s.Teacher)
                .Include(s => s.Subject)
                .Include(s => s.Group)
                .Include(s => s.Classroom)
                .Where(s => s.StartTime.Date == today)
                .Select(s => new
                {
                    Start = s.StartTime.ToShortTimeString(),
                    End = s.EndTime.ToShortTimeString(),
                    Teacher = s.Teacher.FirstName + " " + s.Teacher.LastName,
                    Subject = s.Subject.Name,
                    Group = s.Group.Name,
                    Classroom = s.Classroom.Name
                })
                .ToList();

            dgvTodaySchedule.DataSource = todaySchedule;
        }
    }
}
