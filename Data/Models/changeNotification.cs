using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "changeNotification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class changeNotification
    {
        [XmlElement(ElementName = "changeNotificationSIB1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB1 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB2 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB3 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB4 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB5 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB6 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB7 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB8 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB13", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB13 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB15", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB15 { get; set; }

        [XmlElement(ElementName = "changeNotificationSIB16", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool changeNotificationSIB16 { get; set; }
    }
}