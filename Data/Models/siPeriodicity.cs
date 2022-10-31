using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "siPeriodicity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class siPeriodicity
    {
        [XmlElement(ElementName = "siPeriodicitySI1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI1 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI2 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI3 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI4 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI5 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI6 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI7 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI8 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI9", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI9 { get; set; }

        [XmlElement(ElementName = "siPeriodicitySI10", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siPeriodicitySI10 { get; set; }
    }
}