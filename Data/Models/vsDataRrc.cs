using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataRrc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataRrc
    {
        [XmlElement(ElementName = "t300", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t300 { get; set; }

        [XmlElement(ElementName = "t301", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t301 { get; set; }

        [XmlElement(ElementName = "t304", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t304 { get; set; }

        [XmlElement(ElementName = "t320", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t320 { get; set; }

        [XmlElement(ElementName = "t311", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t311 { get; set; }

        [XmlElement(ElementName = "tRrcConnReest", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tRrcConnReest { get; set; }

        [XmlElement(ElementName = "tWaitForRrcConnReest", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tWaitForRrcConnReest { get; set; }

        [XmlElement(ElementName = "tRrcConnectionReconfiguration", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tRrcConnectionReconfiguration { get; set; }

        [XmlElement(ElementName = "t300Br", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t300Br { get; set; }

        [XmlElement(ElementName = "t301Br", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t301Br { get; set; }

        [XmlElement(ElementName = "t300NbIot", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int t300NbIot { get; set; }
    }
}