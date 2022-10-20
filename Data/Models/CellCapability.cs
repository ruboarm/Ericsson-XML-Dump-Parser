using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "cellCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class CellCapability
    {
        [XmlElement(ElementName = "hsdschSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int HsdschSupport { get; set; }

        [XmlElement(ElementName = "edchSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int EdchSupport { get; set; }

        [XmlElement(ElementName = "edchTti2Support", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int EdchTti2Support { get; set; }

        [XmlElement(ElementName = "enhancedL2Support", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int EnhancedL2Support { get; set; }

        [XmlElement(ElementName = "fdpchSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int FdpchSupport { get; set; }

        [XmlElement(ElementName = "multiCarrierSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MultiCarrierSupport { get; set; }

        [XmlElement(ElementName = "cpcSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CpcSupport { get; set; }

        [XmlElement(ElementName = "qam64MimoSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Qam64MimoSupport { get; set; }
    }
}