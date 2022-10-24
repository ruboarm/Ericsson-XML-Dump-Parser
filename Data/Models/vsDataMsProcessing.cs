using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataMsProcessing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataMsProcessing
    {
        [XmlElement(ElementName = "codingLaw", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CodingLaw { get; set; }

        [XmlElement(ElementName = "powerSaveModeEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PowerSaveModeEnabled { get; set; }
    }
}