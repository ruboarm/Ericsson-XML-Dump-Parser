using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataEUtranFrequency", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataEUtranFrequency
    {
        [XmlElement(ElementName = "arfcnValueEUtranDl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ArfcnValueEUtranDl { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "excludeAdditionalFreqBandList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ExcludeAdditionalFreqBandList { get; set; }
    }
}
