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
    public partial class EmployeesControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private TeacherRepository _teacherRepository;

        public EmployeesControl()
        {
            InitializeComponent();
        }

        public EmployeesControl(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            displayData();
        }

        public void displayData()
        {
            var teachers = _context.Teachers.Select(teacher => new
            {
                teacher.Id,
                teacher.FirstName,
                teacher.LastName,
                teacher.DateOfBirth,
                teacher.Phone,
                teacher.Email,
            })
        .ToList();
            dgvEmployees.DataSource = teachers;
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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(this);
            addEmployeeForm.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(this);
            editEmployeeForm.Show();
        }

        private int getID;

        private void btnDelEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var teacherToDelete = _context.Teachers.Include(s => s.User).FirstOrDefault(s => s.Id == getID);

                if (teacherToDelete != null)
                {
                    if (teacherToDelete.User != null)
                    {
                        _context.Users.Remove(teacherToDelete.User);
                        _context.SaveChanges();
                    }

                    _context.Teachers.Remove(teacherToDelete);
                    _context.SaveChanges();

                    displayData();
                    MessageBox.Show("Teacher deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a Teacher to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Teacher deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            string searchingTerm = tbSearchEmployee.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchingTerm))
            {
                dgvEmployees.DataSource = _context.Teachers.Select(student => new
                {
                    student.FirstName,
                    student.LastName,
                    student.DateOfBirth,
                    student.Phone,
                    student.Email,
                }).ToList();
            }
            else
            {
                var filteredTeachers = _context.Teachers.Where(student => student.FirstName.ToLower().Contains(searchingTerm) || student.LastName.ToLower().Contains(searchingTerm))
                    .Select(student => new
                    {
                        student.FirstName,
                        student.LastName,
                        student.DateOfBirth,
                        student.Phone,
                        student.Email,
                    }).ToList();
                dgvEmployees.DataSource = filteredTeachers;
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvEmployees.Rows[e.RowIndex];
                getID = Convert.ToInt32(row.Cells["Id"].Value);
            }
        }
    }
}