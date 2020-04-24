using Home.Lesson.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Lesson.Repository.Repository
{
    public class DogRepository:BaseRepository<Dog>
    {
        public DogRepository(string fileName): base(fileName)
        {

        }
    }
}
