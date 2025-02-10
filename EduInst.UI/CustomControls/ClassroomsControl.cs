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
    public partial class ClassroomsControl : UserControl
    {
        private EduInstContext _context;
        private UnitOfWork _unitOfWork;
        private ClassroomsControl _classroomsRepository;

        public ClassroomsControl()
        {
            InitializeComponent();
        }

        public ClassroomsControl(EduInstContext context)
        {
            InitializeComponent();
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
       .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options);
            displayData();
        }

        public void displayData()
        {
            var classrooms = _context.Classrooms.Select(classroom => new
            {
                classroom.Id,
                classroom.Name,
                classroom.Capacity
            })
            .ToList();

            dgvClassrooms.DataSource = classrooms;
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

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClassroomForm addClassroomForm = new AddClassroomForm(this);
            addClassroomForm.Show();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            EditClassroomForm editClassroomForm = new EditClassroomForm(this);
            editClassroomForm.Show();
        }

        private int getID;

        private void btnDelClass_Click(object sender, EventArgs e)
        {
            var classToDelete = _context.Classrooms.FirstOrDefault(c => c.Id == getID);
            if (classToDelete != null)
            {
                _context.Classrooms.Remove(classToDelete);
                _context.SaveChanges();
                displayData();
                MessageBox.Show("Classroom deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Classroom not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearchClass_TextChanged(object sender, EventArgs e)
        {
            string searchingTerm = tbSearchClass.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchingTerm))
            {
                dgvClassrooms.DataSource = _context.Classrooms.Select(classroom => new
                {
                    classroom.Name,
                    classroom.Capacity
                }).ToList();
            }
            else
            {
                var filteredClassrooms = _context.Classrooms.Where(classroom => classroom.Name.ToLower().Contains(searchingTerm))
                    .Select(classroom => new
                    {
                        classroom.Name,
                        classroom.Capacity
                    }).ToList();
                dgvClassrooms.DataSource = filteredClassrooms;
            }
        }

        private void dgvClassrooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = this.dgvClassrooms.Rows[e.RowIndex];
                getID = Convert.ToInt32(dgvClassrooms.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
