using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleAppTeste
{
    public static class Serializer
    {
        private static readonly string nameSpace = "ConsoleAppTeste";
        private static readonly XmlRootAttribute root = new XmlRootAttribute();
        public static string AsXml(Pessoa resource)
        {
            var stringWriter = new StringWriter();
            new XmlSerializer(resource.GetType(), nameSpace)
                .Serialize(stringWriter, resource);
            return stringWriter.ToString(); 
        }
    }
}
