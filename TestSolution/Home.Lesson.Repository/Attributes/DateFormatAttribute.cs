using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Lesson.Repository.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DateFormatAttribute : Attribute
    {
        public DateFormatAttribute() : this("dd/MM/yyyy") { }

        public DateFormatAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
