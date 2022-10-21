using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalUtranFreq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalUtranFreq
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "arfcnValueUtranDl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ArfcnValueUtranDl { get; set; }
    }
}