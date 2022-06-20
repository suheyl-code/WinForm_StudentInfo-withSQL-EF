using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo_withDatabase
{
    public class StudentDal
    {
        public List<Student> GetAll()
        {
            using (StudentInfoContext stContext = new StudentInfoContext())
            {
                return stContext.Students.ToList();
            }
        }

        public void Add(Student student)
        {
            using (StudentInfoContext stContext = new StudentInfoContext())
            {
                var entity = stContext.Entry(student);
                entity.State = EntityState.Added;
                stContext.SaveChanges();
            }
        }

        public void Update(Student student)
        {
            using (StudentInfoContext stContext = new StudentInfoContext())
            {
                var entity = stContext.Entry(student);
                entity.State = EntityState.Modified;
                stContext.SaveChanges();
            }
        }

        public void Delete(Student student)
        {
            using (StudentInfoContext stContext = new StudentInfoContext())
            {
                var entity = stContext.Entry(student);
                entity.State = EntityState.Deleted;
                stContext.SaveChanges();
            }
        }
    }
}
