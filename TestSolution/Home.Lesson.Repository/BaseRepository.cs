using System.Collections.Generic;
using System.Xml;

namespace Home.Lesson.Repository
{
    public class BaseRepository<TModel> where TModel : class, new()
    {
        public BaseRepository(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; }

        public IEnumerable<TModel> AsEnumerable()
        {
            var XDoc = new XmlDocument();
            XDoc.Load(FileName);
            var xRoot = XDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot.ChildNodes)
            {
                yield return xnode.ToModel<TModel>();
            }
        }
        public void Add(TModel model)
        {
            var xdoc = new XmlDocument();
            xdoc.Load(FileName);

            var node = xdoc.ToXmlNode(model);
            xdoc.DocumentElement.AppendChild(node);
            xdoc.Save(FileName);
        }
        public void AddRange(IEnumerable<TModel> models)
        {
            var xdoc = new XmlDocument();
            xdoc.Load(FileName);

            foreach(var model in models)
            {
                var node = xdoc.ToXmlNode(model);
                xdoc.DocumentElement.AppendChild(node);
            }

            xdoc.Save(FileName);
        }
    }
}
