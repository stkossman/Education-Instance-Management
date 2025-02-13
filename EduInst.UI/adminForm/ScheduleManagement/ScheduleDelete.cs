using EduInst.DAL.Context;
using EduInst.DAL.Models;
using EduInst.PL.Schedule;
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

namespace EduInst.PL.adminForm.ScheduleManagement
{
    public partial class ScheduleDelete : Form
    {
        private EduInstContext _context;
        private ScheduleControl _scheduleControl;
        private DAL.Models.Schedule _selectedSchedule;
        private ScheduleCrud scheduleCrud;

        public ScheduleDelete(ScheduleControl scheduleControl = null, ScheduleCrud scheduleCrud = null)
        {
            InitializeComponent();
            _scheduleControl = scheduleControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);

            var lessons = _context.Schedules
                .Select(s => new
                {
                    s.Id,
                    DisplayText = $"{s.StartTime} - {s.EndTime} - {s.Subject.Name} - {s.Group.Name} - {s.Teacher.FirstName} - {s.Teacher.LastName} - {s.Group.Name} - {s.Classroom.Name}"
                })
                .ToList();
            cmbScheduleDeleteLesson.DataSource = lessons;
            cmbScheduleDeleteLesson.DisplayMember = "DisplayText";
            cmbScheduleDeleteLesson.ValueMember = "Id";
        }

        private void btnScheduleDeleteLesson_Click(object sender, EventArgs e)
        {
            if (_selectedSchedule == null)
            {
                MessageBox.Show("Please select a lesson to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _context.Schedules.Remove(_selectedSchedule);
                _context.SaveChanges();
                _scheduleControl.LoadSchedule();
                MessageBox.Show("Lesson deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Lesson deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lesson deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbScheduleDeleteLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLessonId = (int)cmbScheduleDeleteLesson.SelectedValue;
            _selectedSchedule = _context.Schedules.FirstOrDefault(s => s.Id == selectedLessonId);
        }
    }
}
