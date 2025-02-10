using EduInst.DAL.Context;
using EduInst.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduInst.BL
{
    public class TeacherRepository : GenericRepository<Teacher>
    {
        public TeacherRepository(EduInstContext context) : base(context)
        {
        }
    }
}
