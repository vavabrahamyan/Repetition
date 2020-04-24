using Home.Lesson.Repository.Models;
using Home.Lesson.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Home.Lesson.Repository
{
    class Program
    {
        static void Main(string[] Args)
        {
            //List<User> users = new List<User>();
            //XmlDocument xDoc = new XmlDocument();
            //xDoc.Load("‪TestIn26.01.xml");

            //XmlElement xRoot = xDoc.DocumentElement;

            //foreach (XmlNode xnode in xRoot)
            //{
            //    // получаем атрибут name
            //    if (xnode.Attributes.Count > 0)
            //    {
            //        XmlNode attr = xnode.Attributes.GetNamedItem("name");
            //        if (attr != null)
            //            Console.WriteLine(attr.Value);
            //    }
            //    // обходим все дочерние узлы элемента user
            //    foreach (XmlNode childnode in xnode.ChildNodes)
            //    {
            //        // если узел - company
            //        if (childnode.Name == "company")
            //        {
            //            Console.WriteLine($"Компания: {childnode.InnerText}");
            //        }
            //        // если узел age
            //        if (childnode.Name == "age")
            //        {
            //            Console.WriteLine($"Возраст: {childnode.InnerText}");
            //        }
            //    }
            //}
        }
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Company { get; set; }
        }

    }
}
