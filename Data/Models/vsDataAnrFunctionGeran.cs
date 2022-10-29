using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataAnrFunctionGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataAnrFunctionGeran
    {
        [XmlElement(ElementName = "anrGeranMeasReportMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrGeranMeasReportMin { get; set; }

        [XmlElement(ElementName = "anrGeranMeasReportMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrGeranMeasReportMax { get; set; }

        [XmlElement(ElementName = "anrGeranMeasReportIncr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrGeranMeasReportIncr { get; set; }

        [XmlElement(ElementName = "rimIntegrationEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool rimIntegrationEnabled { get; set; }

        [XmlElement(ElementName = "anrGeranMeasReportDecr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrGeranMeasReportDecr { get; set; }

        [XmlElement(ElementName = "anrGeranRacMeasOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool anrGeranRacMeasOn { get; set; }

        [XmlElement(ElementName = "anrGeranMeasReportRacIncr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrGeranMeasReportRacIncr { get; set; }

        [XmlElement(ElementName = "anrStateGsm", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrStateGsm { get; set; }
    }
}