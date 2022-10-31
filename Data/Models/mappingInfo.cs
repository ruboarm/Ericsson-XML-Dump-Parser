using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "mappingInfo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class mappingInfo
    {
        [XmlElement(ElementName = "mappingInfoSIB3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB3 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB4 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB5 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB6 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB7 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB8 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB10", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB10 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB11", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB11 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB12", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB12 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB13", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB13 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB15", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB15 { get; set; }

        [XmlElement(ElementName = "mappingInfoSIB16", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mappingInfoSIB16 { get; set; }
    }
}