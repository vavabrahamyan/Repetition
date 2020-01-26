using Home.Lesson.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Lesson.Repository
{
    public class StudentRepository: BaseRepository<Student>
    {
        public StudentRepository(string fileName) : base(fileName) { }
    }
}
