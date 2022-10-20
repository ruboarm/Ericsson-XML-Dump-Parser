using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalUtranCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalUtranCell
    {
        [XmlElement(ElementName = "individualOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int IndividualOffset { get; set; }

        [XmlElement(ElementName = "maxTxPowerUl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MaxTxPowerUl { get; set; }

        [XmlElement(ElementName = "qQualMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int QQualMin { get; set; }

        [XmlElement(ElementName = "qRxLevMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int QRxLevMin { get; set; }

        [XmlElement(ElementName = "agpsEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int AgpsEnabled { get; set; }

        [XmlElement(ElementName = "cellCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public CellCapability CellCapability { get; set; }

        [XmlElement(ElementName = "transmissionScheme", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TransmissionScheme { get; set; }

        [XmlElement(ElementName = "parentSystem", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ParentSystem { get; set; }

        [XmlElement(ElementName = "mncLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MncLength { get; set; }

        [XmlElement(ElementName = "hsAqmCongCtrlSpiSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> HsAqmCongCtrlSpiSupport { get; set; }

        [XmlElement(ElementName = "hsAqmCongCtrlSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int HsAqmCongCtrlSupport { get; set; }

        [XmlElement(ElementName = "srvccCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int SrvccCapability { get; set; }

        [XmlElement(ElementName = "reportingRange1a", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ReportingRange1a { get; set; }

        [XmlElement(ElementName = "reportingRange1b", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ReportingRange1b { get; set; }

        [XmlElement(ElementName = "timeToTrigger1a", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimeToTrigger1a { get; set; }

        [XmlElement(ElementName = "timeToTrigger1b", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimeToTrigger1b { get; set; }

        [XmlElement(ElementName = "rimCapable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RimCapable { get; set; }

        [XmlElement(ElementName = "lbUtranCellOffloadCapacity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LbUtranCellOffloadCapacity { get; set; }
    }
}