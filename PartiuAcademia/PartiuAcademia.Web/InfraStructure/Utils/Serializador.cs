using PartiuAcademia.Core.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace PartiuAcademia.Web.InfraStructure.Utils
{
    public class Serializador
    {
        public static string SerializarAutenticacaoModel(LoginViewModel AuthenticationModel)
        {
            var serializer = new XmlSerializer(typeof(LoginViewModel));
            var sw = new StringWriter();
            var xw = XmlWriter.Create(sw);
            serializer.Serialize(xw, AuthenticationModel);
            var autenticacaoModelSerializado = sw.ToString();
            return autenticacaoModelSerializado;
        }

        public static LoginViewModel DeserializarAutenticacaoModel(string AuthenticationModelSerializado)
        {
            var serializer = new XmlSerializer(typeof(LoginViewModel));
            var autenticacaoModel =
                (LoginViewModel)serializer.Deserialize(new StringReader(AuthenticationModelSerializado));
            return autenticacaoModel;
        }

    }
}