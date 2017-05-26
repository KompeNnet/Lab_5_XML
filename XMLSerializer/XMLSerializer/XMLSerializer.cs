using Lab_4.Books;
using System;
using System.IO;
using System.Xml.Serialization;


namespace Lab_4.Helpers.Serialization
{
    class XMLSerializer : ISerializer
    {
        public string Serialize(Book smth)
        {
            //TODO

            XmlSerializer serializer = new XmlSerializer(typeof(Book));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, smth);
            return writer.ToString();
        }

        public T Deserialize<T>(string smth)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
