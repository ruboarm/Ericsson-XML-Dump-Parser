using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class Attributes
    {
        [XmlElement(ElementName = "vsDataType", Namespace = "genericNrm.xsd")]
        public string VsDataType { get; set; }

        [XmlElement(ElementName = "vsDataFormatVersion", Namespace = "genericNrm.xsd")]
        public string VsDataFormatVersion { get; set; }

        [XmlElement(ElementName = "vsDataAreas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string VsDataAreas { get; set; }

        [XmlElement(ElementName = "vsDataPlmn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public VsDataPlmn VsDataPlmn { get; set; }
    }
}
