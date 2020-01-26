using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Lesson.Repository.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class IgnoreAttribute : Attribute { }
}
