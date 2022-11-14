using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigCsg", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigCsg
    {
        [XmlElement(ElementName = "hysteresisA5AltCsg", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA5AltCsg { get; set; }

        [XmlElement(ElementName = "a5Thr1RsrpAltCsgOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Thr1RsrpAltCsgOffset { get; set; }

        [XmlElement(ElementName = "a5Thr2RsrpAltCsgOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Thr2RsrpAltCsgOffset { get; set; }

        [XmlElement(ElementName = "timeToTriggerA5AltCsg", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA5AltCsg { get; set; }
    }
}