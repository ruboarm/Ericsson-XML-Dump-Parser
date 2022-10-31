using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "systemInformationBlock3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class systemInformationBlock3
    {
        [XmlElement(ElementName = "tEvaluation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tEvaluation { get; set; }

        [XmlElement(ElementName = "tHystNormal", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tHystNormal { get; set; }

        [XmlElement(ElementName = "nCellChangeMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nCellChangeMedium { get; set; }

        [XmlElement(ElementName = "nCellChangeHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nCellChangeHigh { get; set; }

        [XmlElement(ElementName = "qHystSfMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qHystSfMedium { get; set; }

        [XmlElement(ElementName = "qHystSfHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qHystSfHigh { get; set; }

        [XmlElement(ElementName = "sIntraSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sIntraSearch { get; set; }

        [XmlElement(ElementName = "sNonIntraSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sNonIntraSearch { get; set; }

        [XmlElement(ElementName = "sIntraSearchQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sIntraSearchQ { get; set; }

        [XmlElement(ElementName = "sIntraSearchP", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sIntraSearchP { get; set; }

        [XmlElement(ElementName = "sNonIntraSearchQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sNonIntraSearchQ { get; set; }

        [XmlElement(ElementName = "sNonIntraSearchP", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sNonIntraSearchP { get; set; }

        [XmlElement(ElementName = "threshServingLowQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshServingLowQ { get; set; }

        [XmlElement(ElementName = "sIntraSearchv920Active", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool sIntraSearchv920Active { get; set; }

        [XmlElement(ElementName = "sNonIntraSearchv920Active", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool sNonIntraSearchv920Active { get; set; }
    }
}