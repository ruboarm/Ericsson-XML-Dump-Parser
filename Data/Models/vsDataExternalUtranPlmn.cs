using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalUtranPlmn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalUtranPlmn
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "mcc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Mcc { get; set; }

        [XmlElement(ElementName = "mnc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Mnc { get; set; }

        [XmlElement(ElementName = "mncLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MncLength { get; set; }

        [XmlElement(ElementName = "aliasPlmnIdentities", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string AliasPlmnIdentities { get; set; }
    }
}
