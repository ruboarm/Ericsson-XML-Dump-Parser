using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "utranNrm.xsd")]
    public class ExternalUtranCellAttributes
    {
        [XmlElement(ElementName = "rac", Namespace = "utranNrm.xsd")]
        public int? Rac { get; set; }

        [XmlElement(ElementName = "lac", Namespace = "utranNrm.xsd")]
        public int? Lac { get; set; }

        [XmlElement(ElementName = "primaryCpichPower", Namespace = "utranNrm.xsd")]
        public int PrimaryCpichPower { get; set; }

        [XmlElement(ElementName = "primaryScramblingCode", Namespace = "utranNrm.xsd")]
        public int PrimaryScramblingCode { get; set; }

        [XmlElement(ElementName = "uarfcnDl", Namespace = "utranNrm.xsd")]
        public int UarfcnDl { get; set; }

        [XmlElement(ElementName = "uarfcnUl", Namespace = "utranNrm.xsd")]
        public int? UarfcnUl { get; set; }

        [XmlElement(ElementName = "mnc", Namespace = "utranNrm.xsd")]
        public int Mnc { get; set; }

        [XmlElement(ElementName = "mcc", Namespace = "utranNrm.xsd")]
        public int Mcc { get; set; }

        [XmlElement(ElementName = "rncId", Namespace = "utranNrm.xsd")]
        public int RncId { get; set; }

        [XmlElement(ElementName = "cId", Namespace = "utranNrm.xsd")]
        public int CId { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "utranNrm.xsd")]
        public string? UserLabel { get; set; }
    }
}