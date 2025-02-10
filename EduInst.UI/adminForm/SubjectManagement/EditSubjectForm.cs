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
    public partial class EditSubjectForm : Form
    {
        private EduInstContext _context;
        private SubjectRepository _subjectRepository;
        private SubjectsControl _subjectsControl;

        public EditSubjectForm(SubjectsControl subjectsControl)
        {
            InitializeComponent();
            _subjectsControl = subjectsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void btnEditSubjectEdit_Click(object sender, EventArgs e)
        {
            string oldSubjectName = txtEditSubjectOldName.Text.Trim();
            string newSubjectName = txtEditSubjectNewName.Text.Trim();

            if (string.IsNullOrEmpty(oldSubjectName) || string.IsNullOrEmpty(newSubjectName))
            {
                MessageBox.Show("Please fill in both the old and new subject names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var subjectToEdit = _context.Subjects.FirstOrDefault(s => s.Name == oldSubjectName);

            if (subjectToEdit != null)
            {
                string newSubjectCode = GenSubjectCode(newSubjectName);

                subjectToEdit.Name = newSubjectName;
                subjectToEdit.Code = newSubjectCode;

                try
                {
                    _context.SaveChanges();
                    _subjectsControl.displayData();
                    MessageBox.Show("Subject name successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The subject you are trying to edit does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenSubjectCode(string subjectName)
        {
            var words = subjectName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string codePrefix = "";

            if (words.Length == 1)
            {
                codePrefix = words[0].Substring(0, 2).ToUpper();
            }
            else
            {
                codePrefix = (words[0].Substring(0, 1) + words[1].Substring(0, 1)).ToUpper();
            }

            int codeSuffix = 1;
            string fullCode = $"{codePrefix}{codeSuffix}";

            var existingCodes = _context.Subjects.Select(s => s.Code).ToList();

            while (existingCodes.Contains(fullCode))
            {
                codeSuffix++;
                fullCode = $"{codePrefix}-{codeSuffix}";
            }

            return fullCode;
        }
    }
}
