using Home.Lesson.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Lesson.Repository
{
    public class TeacherRepository:BaseRepository<Teacher>
    {
        public TeacherRepository(string fileName) : base(fileName) { }
    }
}
