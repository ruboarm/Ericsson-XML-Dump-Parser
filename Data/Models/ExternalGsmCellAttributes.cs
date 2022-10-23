using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "geranNrm.xsd")]
    public class ExternalGsmCellAttributes
    {
        [XmlElement(ElementName = "mnc", Namespace = "geranNrm.xsd")]
        public int Mnc { get; set; }

        [XmlElement(ElementName = "mcc", Namespace = "geranNrm.xsd")]
        public int Mcc { get; set; }

        [XmlElement(ElementName = "lac", Namespace = "geranNrm.xsd")]
        public int Lac { get; set; }

        [XmlElement(ElementName = "bcchFrequency", Namespace = "geranNrm.xsd")]
        public int BcchFrequency { get; set; }

        [XmlElement(ElementName = "ncc", Namespace = "geranNrm.xsd")]
        public int Ncc { get; set; }

        [XmlElement(ElementName = "bcc", Namespace = "geranNrm.xsd")]
        public int Bcc { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "geranNrm.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "cellIdentity", Namespace = "geranNrm.xsd")]
        public int CellIdentity { get; set; }
    }
}