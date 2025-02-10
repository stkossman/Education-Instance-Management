using EduInst.DAL.Context;
using EduInst.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduInst.BL
{
    public class SubjectRepository : GenericRepository<Subject>
    {
        public SubjectRepository(EduInstContext context) : base(context)
        {
        }
    }
}
