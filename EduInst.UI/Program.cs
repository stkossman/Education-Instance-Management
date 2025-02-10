using EduInst.DAL.Context;
using EduInst.PL;
using EduInst.PL.StudentForm;
using EduInst.PL.TeacherForm;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;

namespace EduInst.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            QuestPDF.Settings.License = LicenseType.Community;
            using (var context = new EduInstContext(new DbContextOptionsBuilder<EduInstContext>()
    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;TrustServerCertificate=True;").Options))
            Application.Run(new loginForm());
        }
    }
}