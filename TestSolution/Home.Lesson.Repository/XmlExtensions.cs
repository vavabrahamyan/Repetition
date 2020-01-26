using Home.Lesson.Repository.Attributes;
using System;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace Home.Lesson.Repository
{
    public static class XmlExtensions
    {
        public static bool IsIgnored(this PropertyInfo pi)
        {
            return pi.GetCustomAttribute<IgnoreAttribute>() != null;
        }
        public static T ToModel<T>(this XmlNode xnode) where T : new()
        {
            Type sourceType = typeof(T);
            if (xnode.Name.ToUpper() != sourceType.Name.ToUpper())
                throw new Exception("Invalid Class Name...");

            var source = new T();
            var members = sourceType
                .GetProperties()
                .Where(pi => !pi.IsIgnored())
                .ToDictionary(p => p.Name.ToUpper(), p => p);

            foreach (XmlNode xchild in xnode.ChildNodes)
            {
                if (members.TryGetValue(xchild.Name.ToUpper(), out var member))
                {
                    if (member.GetCustomAttribute<DateFormatAttribute>() != null)
                    {
                        if (DateTime.TryParse(xchild.InnerText, out DateTime date))
                            member.SetValue(source, date);
                    }
                    else
                    {
                        member.SetValue(source, xchild.InnerText);
                    }
                }
            }
            return source;
        }
        public static XmlNode ToXmlNode<TModel>(this XmlDocument xdoc, TModel model)
        {
            Type type = model.GetType();

            var node = xdoc.CreateNode(XmlNodeType.Element, type.Name.ToLower(), null);

            var members = type
                .GetProperties()
                .Where(pi => !pi.IsIgnored());

            foreach(var member in members)
            {
                XmlNode nodeMember = xdoc.CreateElement(member.Name);
                var value = member.GetValue(model);

                var format = member.GetCustomAttribute<DateFormatAttribute>();
                if (format != null)
                {
                    if (DateTime.TryParse(value.ToString(), out DateTime date))
                    {
                        nodeMember.InnerText = date.ToString(format.Value);
                    }
                }
                else
                    nodeMember.InnerText = value?.ToString();

                node.AppendChild(nodeMember);
            }

            return node;
        }
    }
}
