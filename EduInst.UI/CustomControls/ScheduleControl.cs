using EduInst.BL;
using EduInst.DAL.Context;
using EduInst.PL.CustomControls;
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
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Diagnostics;

namespace EduInst.PL.Schedule
{
    public partial class ScheduleControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private ScheduleRepository _scheduleRepository;

        public ScheduleControl()
        {
            InitializeComponent();
        }

        public ScheduleControl(EduInstContext context)
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
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);

            var schedules = _context.Schedules
           .Include(s => s.Teacher)
           .Include(s => s.Subject)
           .Include(s => s.Group)
           .Include(s => s.Classroom)
           .AsEnumerable()
           .Where(s => s.StartTime.Date == selectedDate.Date)
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

        private void btnScheduleCrud_Click(object sender, EventArgs e)
        {
            ScheduleCrud scheduleCrud = new ScheduleCrud(_context);
            scheduleCrud.Show();
        }

        private void btnExportSchedule_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = GetSelectedData();
            var schedules = _context.Schedules
                .Where(s => s.StartTime.Date == selectedDate.Date)
                .Include(s => s.Teacher)
                .Include(s => s.Subject)
                .Include(s => s.Group)
                .Include(s => s.Classroom)
                .ToList();

            if (!schedules.Any())
            {
                MessageBox.Show("No schedule found for the selected date.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Schedule PDF";
                saveFileDialog.FileName = $"Schedule_{selectedDate:yyyy-MM-dd}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(30);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Arial"));

                            page.Header()
                                .Text($"Class Schedule - {selectedDate:dddd, MMM dd yyyy}")
                                .SemiBold().FontSize(18).FontColor(Colors.DeepPurple.Lighten2);

                            page.Content().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(1);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Text("Time").SemiBold();
                                    header.Cell().Text("Subject").SemiBold();
                                    header.Cell().Text("Teacher").SemiBold();
                                    header.Cell().Text("Group").SemiBold();
                                    header.Cell().Text("Classroom").SemiBold();
                                });

                                foreach (var schedule in schedules)
                                {
                                    table.Cell().Text($"{schedule.StartTime:HH:mm} - {schedule.EndTime:HH:mm}");
                                    table.Cell().Text(schedule.Subject.Name);
                                    table.Cell().Text($"{schedule.Teacher.FirstName} {schedule.Teacher.LastName}");
                                    table.Cell().Text(schedule.Group.Name);
                                    table.Cell().Text(schedule.Classroom.Name);
                                }
                            });

                            page.Footer()
                                .AlignRight()
                                .Text(x => x.Span($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm}").FontSize(10).Italic());
                        });
                    }).GeneratePdf(filePath);

                    MessageBox.Show($"Schedule exported successfully!\nSaved at: {filePath}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
