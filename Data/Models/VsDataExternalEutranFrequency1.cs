using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalEutranFrequency", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalEutranFrequency
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "earfcnDl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int EarfcnDl { get; set; }

        [XmlElement(ElementName = "plmnIdentity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public PlmnIdentity PlmnIdentity { get; set; }
    }
}