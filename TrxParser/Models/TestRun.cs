using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrxParser.Models
{
    [XmlRoot(ElementName = "TestRun", Namespace = "")]
    public class TestRun
    {
        [XmlAttribute("id")]
        public string RunId { get; set; }

        [XmlAttribute("runUser")]
        public string RunUser { get; set; }

        [XmlElement("Times")]
        public Times Times { get; set; }
    }
}
