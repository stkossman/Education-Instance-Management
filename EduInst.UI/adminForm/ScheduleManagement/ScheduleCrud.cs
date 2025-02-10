using EduInst.BL;
using EduInst.DAL.Context;
using EduInst.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduInst.PL.Schedule
{
    public partial class ScheduleCrud : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ScheduleRepository _scheduleRepository;
        private EduInst.DAL.Models.Schedule _currentSchedule;
        private EduInstContext _context;

        public ScheduleCrud(EduInstContext context, EduInst.DAL.Models.Schedule schedule = null)
        {
            InitializeComponent();
            _context = context;
            _currentSchedule = schedule;
            LoadComboBoxes();

            SetupDateTimePickers();

            if (_currentSchedule != null)
            {
                LoadScheduleData();
            }
        }

        private void SetupDateTimePickers()
        {
            dtpStartTimeDate.Format = DateTimePickerFormat.Short;
            dtpStartTimeDate.ShowUpDown = false;
            dtpEndTimeDate.Format = DateTimePickerFormat.Short;
            dtpEndTimeDate.ShowUpDown = false;

            dtpStartTimeTime.Format = DateTimePickerFormat.Time;
            dtpStartTimeTime.ShowUpDown = true;
            dtpEndTimeTime.Format = DateTimePickerFormat.Time;
            dtpEndTimeTime.ShowUpDown = true;
        }

        private void LoadComboBoxes()
        {
            var teachers = _context.Teachers.Select(teacher => new
            {
                teacher.Id,
                FullName = teacher.FirstName + " " + teacher.LastName
            }).ToList();

            cmbTeacherSchedule.DataSource = teachers;
            cmbTeacherSchedule.DisplayMember = "FullName";
            cmbTeacherSchedule.ValueMember = "Id";

            cmbScheduleSubjectChoose.DataSource = _context.Subjects.ToList();
            cmbScheduleSubjectChoose.DisplayMember = "Name";
            cmbScheduleSubjectChoose.ValueMember = "Id";

            cmbScheduleGroupChoose.DataSource = _context.Groups.ToList();
            cmbScheduleGroupChoose.DisplayMember = "Name";
            cmbScheduleGroupChoose.ValueMember = "Id";

            cmbScheduleClassroomChoose.DataSource = _context.Classrooms.ToList();
            cmbScheduleClassroomChoose.DisplayMember = "Name";
            cmbScheduleClassroomChoose.ValueMember = "Id";
        }

        private void LoadScheduleData()
        {
            DateTime startDateTime = _currentSchedule.StartTime;
            DateTime endDateTime = _currentSchedule.EndTime;

            dtpStartTimeDate.Value = startDateTime.Date;
            dtpStartTimeTime.Value = DateTime.Today.Add(startDateTime.TimeOfDay);
            dtpEndTimeDate.Value = endDateTime.Date;
            dtpEndTimeTime.Value = DateTime.Today.Add(endDateTime.TimeOfDay);

            cmbTeacherSchedule.SelectedValue = _currentSchedule.TeacherId;
            cmbScheduleSubjectChoose.SelectedValue = _currentSchedule.SubjectId;
            cmbScheduleGroupChoose.SelectedValue = _currentSchedule.GroupId;
            cmbScheduleClassroomChoose.SelectedValue = _currentSchedule.ClassroomId;
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (_currentSchedule == null)
                _currentSchedule = new EduInst.DAL.Models.Schedule();

            DateTime startDateTime = dtpStartTimeDate.Value.Date + dtpStartTimeTime.Value.TimeOfDay;
            DateTime endDateTime = dtpEndTimeDate.Value.Date + dtpEndTimeTime.Value.TimeOfDay;

            _currentSchedule.StartTime = startDateTime;
            _currentSchedule.EndTime = endDateTime;

            _currentSchedule.TeacherId = (int)cmbTeacherSchedule.SelectedValue;
            _currentSchedule.SubjectId = (int)cmbScheduleSubjectChoose.SelectedValue;
            _currentSchedule.GroupId = (int)cmbScheduleGroupChoose.SelectedValue;
            _currentSchedule.ClassroomId = (int)cmbScheduleClassroomChoose.SelectedValue;

            if (_currentSchedule.Id == 0)
                _context.Schedules.Add(_currentSchedule);
            else
                _context.Schedules.Update(_currentSchedule);

            _context.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelSchedule_Click(object sender, EventArgs e)
        {
            if (_currentSchedule != null)
            {
                _context.Schedules.Remove(_currentSchedule);
                _context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelSchedule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
