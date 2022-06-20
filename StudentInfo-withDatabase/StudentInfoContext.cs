using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo_withDatabase
{
    public class StudentInfoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
