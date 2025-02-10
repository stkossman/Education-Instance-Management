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
using System.Transactions;
using System.Windows.Forms;

namespace EduInst.PL
{
    public partial class StudentsControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private StudentRepository _studentRepository;

        public StudentsControl()
        {
            InitializeComponent();
        }

        public StudentsControl(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            displayData();
        }

        public void displayData()
        {
            var students = _context.Students.Select(student => new
            {
                student.Id,
                student.FirstName,
                student.LastName,
                student.DateOfBirth,
                student.Phone,
                student.Email,
                student.Group
            })
            .ToList();

            dgvStudents.DataSource = students;
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            GroupsControl groupsControl = new GroupsControl();
            AddStudentForm addStudentForm = new AddStudentForm(this, groupsControl);
            addStudentForm.Show();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudentForm editStudentForm = new EditStudentForm(this);
            editStudentForm.Show();
        }

        private int getID;

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var studentToDelete = _context.Students.Include(s => s.User).FirstOrDefault(s => s.Id == getID);

                if (studentToDelete != null)
                {
                    if (studentToDelete.User != null)
                    {
                        _context.Users.Remove(studentToDelete.User);
                        _context.SaveChanges();
                    }

                    _context.Students.Remove(studentToDelete);
                    _context.SaveChanges();

                    displayData();
                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string searchingTerm = tbSearchStudent.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchingTerm))
            {
                dgvStudents.DataSource = _context.Students.Select(student => new
                {
                    student.FirstName,
                    student.LastName,
                    student.DateOfBirth,
                    student.Phone,
                    student.Email,
                    student.Group
                }).ToList();
            }
            else
            {
                var filteredStudents = _context.Students.Where(student => student.FirstName.ToLower().Contains(searchingTerm) || student.LastName.ToLower().Contains(searchingTerm))
                    .Select(student => new
                    {
                        student.FirstName,
                        student.LastName,
                        student.DateOfBirth,
                        student.Phone,
                        student.Email,
                        student.Group
                    }).ToList();
                dgvStudents.DataSource = filteredStudents;
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvStudents.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }
    }
}
