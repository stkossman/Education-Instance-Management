using EduInst.BL;
using EduInst.DAL.Context;
using EduInst.DAL.Models;
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
    public partial class AddSubjectForm : Form
    {
        private EduInstContext _context;
        private SubjectRepository _subjectRepository;
        private SubjectsControl _subjectsControl;

        public AddSubjectForm(SubjectsControl subjectsControl)
        {
            InitializeComponent();
            _subjectsControl = subjectsControl;
            _context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
        .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;")
        .Options);
        }

        private void btnAddSubjectCreate_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();

            if (string.IsNullOrEmpty(txtSubjectName.Text))
            {
                MessageBox.Show("Please enter a subject name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string subjectCode = GenSubjectCode(subjectName);

            var newSubject = new Subject
            {
                Name = subjectName,
                Code = subjectCode
            };

            _context.Subjects.Add(newSubject);

            _context.SaveChanges();
            _subjectsControl.displayData();

            MessageBox.Show($"Subject '{subjectName}' with code '{subjectCode}' added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                codePrefix = (words[0].Substring(0, 1) + words[1].Substring(0 ,1)).ToUpper();
            }

            int codeSuffix = 1;
            string fullCode = $"{codePrefix}{codeSuffix}";

            var existingCodes = _context.Subjects.Select(s => s.Code).ToList();

            while (existingCodes.Contains(fullCode))
            {
                codeSuffix++;
                fullCode = $"{codePrefix}{codeSuffix}";
            }

            return fullCode;
        }
    }
}
