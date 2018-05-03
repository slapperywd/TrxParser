using System.Xml.Serialization;

namespace TrxParser.Models
{
    public class TestMethod
    {
        [XmlAttribute("className")]
        public string ClassName { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("codeBase")]
        public string CodeBase { get; set; }
    }
}
