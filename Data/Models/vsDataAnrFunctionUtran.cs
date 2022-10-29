using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataAnrFunctionUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataAnrFunctionUtran
    {
        [XmlElement(ElementName = "anrUtranMeasReportAcIncr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUtranMeasReportAcIncr { get; set; }

        [XmlElement(ElementName = "anrUtranAcMeasOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool anrUtranAcMeasOn { get; set; }

        [XmlElement(ElementName = "hoAllowedUtranPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool hoAllowedUtranPolicy { get; set; }

        [XmlElement(ElementName = "rimIntegrationEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool rimIntegrationEnabled { get; set; }

        [XmlElement(ElementName = "anrUtranMeasReportIncr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUtranMeasReportIncr { get; set; }

        [XmlElement(ElementName = "srvccPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int srvccPolicy { get; set; }

        [XmlElement(ElementName = "anrUtranMeasReportMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUtranMeasReportMax { get; set; }

        [XmlElement(ElementName = "anrUtranMeasReportMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUtranMeasReportMin { get; set; }

        [XmlElement(ElementName = "cellAddEcNoThresholdUtranDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellAddEcNoThresholdUtranDelta { get; set; }

        [XmlElement(ElementName = "anrStateUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrStateUtran { get; set; }

        [XmlElement(ElementName = "anrUtranMeasReportDecr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUtranMeasReportDecr { get; set; }

        [XmlElement(ElementName = "cellAddRscpThresholdUtranDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellAddRscpThresholdUtranDelta { get; set; }
    }
}