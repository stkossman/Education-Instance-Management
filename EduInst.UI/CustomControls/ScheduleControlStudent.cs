using EduInst.BL;
using EduInst.DAL.Context;
using EduInst.PL.LoginForm;
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

namespace EduInst.PL.CustomControls
{
    public partial class ScheduleControlStudent : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private ScheduleRepository _scheduleRepository;

        public ScheduleControlStudent()
        {
            InitializeComponent();
        }

        public ScheduleControlStudent(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            _unitOfWork = new UnitOfWork(_context);
            _scheduleRepository = new ScheduleRepository(_context);
            InitUI();
        }

        public void InitUI()
        {
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            _unitOfWork = new UnitOfWork(_context);
            _scheduleRepository = new ScheduleRepository(_context);

            dtpScheduleDate.Format = DateTimePickerFormat.Short;
            dtpScheduleDate.ValueChanged += (s, e) => LoadSchedule(dtpScheduleDate.Value);
        }

        public void LoadSchedule(DateTime selectedDate)
        {
           using var _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);

            int loggedInUserId = SessionManager.LoggedInUserId;

            var studentGroupId = _context.Students
               .Where(s => s.UserId == loggedInUserId)
               .Select(s => s.GroupId)
               .FirstOrDefault();

            if (studentGroupId == 0)
            {
                MessageBox.Show("Student group not found.");
                return;
            }

            var schedules = _context.Schedules
           .Include(s => s.Teacher)
           .Include(s => s.Subject)
           .Include(s => s.Group)
           .Include(s => s.Classroom)
           .AsEnumerable()
           .Where(s => s.StartTime.Date == selectedDate.Date && s.GroupId == studentGroupId)
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

            dgvSchedule.DataSource = schedules;
        }

        public DateTime GetSelectedData()
        {
            return dtpScheduleDate.Value;
        }
    }
}
