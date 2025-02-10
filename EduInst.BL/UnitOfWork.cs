using EduInst.DAL.Context;
using EduInst.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduInst.BL
{
    public class UnitOfWork : IDisposable
    {
        private readonly EduInstContext _context;
        public UnitOfWork(EduInstContext context)
        {
            _context = context;
            Groups = new GroupRepository(_context);
            Teacher = new TeacherRepository(_context);
            Student = new StudentRepository(_context);
            Subject = new SubjectRepository(_context);
            Schedule = new ScheduleRepository(_context);
            Users = new UserRepository(_context);
        }

        public GroupRepository Groups { get; private set; }
        public TeacherRepository Teacher { get; private set; }
        public StudentRepository Student { get; private set; }
        public SubjectRepository Subject { get; private set; }
        public ScheduleRepository Schedule { get; private set; }
        public UserRepository Users { get; private set; }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
