using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduInst.DAL.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EduInstContext>
    {
        public EduInstContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EduInstContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EduInstDB;Trusted_Connection=True;");
            return new EduInstContext(optionsBuilder.Options);
        }
    }
}
