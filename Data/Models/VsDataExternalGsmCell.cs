using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalGsmCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalGsmCell
    {
        [XmlElement(ElementName = "dtmSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DtmSupport { get; set; }

        [XmlElement(ElementName = "maxTxPowerUl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MaxTxPowerUl { get; set; }

        [XmlElement(ElementName = "qRxLevMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int QRxLevMin { get; set; }

        [XmlElement(ElementName = "individualOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int IndividualOffset { get; set; }

        [XmlElement(ElementName = "bandIndicator", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int BandIndicator { get; set; }

        [XmlElement(ElementName = "parentSystem", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ParentSystem { get; set; }

        [XmlElement(ElementName = "mncLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MncLength { get; set; }

        [XmlElement(ElementName = "rac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Rac { get; set; }

        [XmlElement(ElementName = "rimCapable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RimCapable { get; set; }
    }
}