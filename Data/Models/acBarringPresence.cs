using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "acBarringPresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class acBarringPresence
    {
        [XmlElement(ElementName = "acBarringForMoDataPresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringForMoDataPresence { get; set; }

        [XmlElement(ElementName = "acBarringForMoSignPresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringForMoSignPresence { get; set; }

        [XmlElement(ElementName = "acBarringForCsfbPresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringForCsfbPresence { get; set; }
        
        [XmlElement(ElementName = "acBarringForMmtelVoicePresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringForMmtelVoicePresence { get; set; }

        [XmlElement(ElementName = "acBarringForMmtelVideoPresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringForMmtelVideoPresence { get; set; }

        [XmlElement(ElementName = "acBarringPriorityCsfb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringPriorityCsfb { get; set; }

        [XmlElement(ElementName = "acBarringPriorityMoData", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringPriorityMoData { get; set; }

        [XmlElement(ElementName = "acBarringPriorityMoSignaling", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringPriorityMoSignaling { get; set; }

        [XmlElement(ElementName = "acBarringPriorityMmtelVoice", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringPriorityMmtelVoice { get; set; }

        [XmlElement(ElementName = "acBarringPriorityMmtelVideo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int acBarringPriorityMmtelVideo { get; set; }
    }
}