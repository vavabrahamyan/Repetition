using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Lesson.Repository.Models
{
    public class Dog
    {
        public Dog()
        {

        }
        public Dog(string name, string kind)
        {
            Name = name;
            Kind = kind;
        }

        public string Name { get; set; }
        public string Kind { get; set; }
        public override string ToString()
        {
            return $"This {Kind}s name is {Name}";
        }
    }
}
