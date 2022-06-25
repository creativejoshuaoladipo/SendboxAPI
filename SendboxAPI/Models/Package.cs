using System.Xml.Serialization;

namespace SendboxAPI.Models
{
    public class Package
    {
        [XmlElement("Height")]
        public decimal Height { get; set; }
        [XmlElement("Width")]
        public decimal Width { get; set; }
        [XmlElement("Depth")]
        public decimal Depth { get; set; }
    }
}
