using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "manages", Namespace = "genericNrm.xsd")]
    public class Manages
    {
        [XmlText]
        public string Text { get; set; }
    }
}