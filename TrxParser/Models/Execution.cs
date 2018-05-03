using System.Xml.Serialization;

namespace TrxParser.Models
{
    public class Execution
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}
