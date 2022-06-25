using System.Xml.Serialization;

namespace SendboxAPI.Models
{
    [XmlRoot("SendBoxOfferRequest")]
    public class SendBoxOfferRequest
    {
        [XmlElement("Source")]
        public string Source { get; set; }
        [XmlElement("Destination")]
        public string Destination { get; set; }
        [XmlArray("Packages")]
        public Package[] Packages { get; set; }
       
    }
}
