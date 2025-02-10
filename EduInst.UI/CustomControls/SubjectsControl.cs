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
    public partial class SubjectsControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private SubjectRepository _subjectRepository;

        public SubjectsControl()
        {
            InitializeComponent();
        }

        public SubjectsControl(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            displayData();
        }

        public void displayData()
        {
            var subjects = _context.Subjects.Select(subject => new
            {
                subject.Id,
                subject.Name,
                subject.Code
            })
            .ToList();
            dgvSubjects.DataSource = subjects;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
                _unitOfWork = new UnitOfWork(_context);
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm addSubjectForm = new AddSubjectForm(this);
            addSubjectForm.Show();
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            EditSubjectForm editSubjectForm = new EditSubjectForm(this);
            editSubjectForm.Show();
        }

        private void tbSearchSubject_TextChanged(object sender, EventArgs e)
        {
            string searchingTerm = tbSearchSubject.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchingTerm))
            {
                dgvSubjects.DataSource = _context.Subjects.Select(subject => new
                {
                    subject.Name,
                    subject.Code
                }).ToList();
            }
            else
            {
                var filteredSubjects = _context.Subjects.Where(subject => subject.Name.ToLower().Contains(searchingTerm))
                    .Select(subject => new
                    {
                        subject.Name,
                        subject.Code
                    }).ToList();

                dgvSubjects.DataSource = filteredSubjects;
            }
        }

        private int getID;

        private void btnDelSubject_Click(object sender, EventArgs e)
        {
            var subjectToDelete = _context.Subjects.FirstOrDefault(g => g.Id == getID);

            if (subjectToDelete != null)
            {
                _context.Subjects.Remove(subjectToDelete);
                _context.SaveChanges();
                displayData();
                MessageBox.Show("Subject successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The subject you are trying to delete does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvSubjects.Rows[e.RowIndex];
                getID = Convert.ToInt32(dgvSubjects.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
