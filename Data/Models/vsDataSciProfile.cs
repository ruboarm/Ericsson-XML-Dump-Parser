using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSciProfile", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSciProfile
    {
        [XmlElement(ElementName = "srsAllocationStrategy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int srsAllocationStrategy { get; set; }

        [XmlElement(ElementName = "absPrioOverride", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int absPrioOverride { get; set; }

        [XmlElement(ElementName = "logicalChannelGroupRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string logicalChannelGroupRef { get; set; }

        [XmlElement(ElementName = "ulMaxWaitingTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulMaxWaitingTime { get; set; }

        [XmlElement(ElementName = "dlRelativePriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlRelativePriority { get; set; }

        [XmlElement(ElementName = "ulMinBitRate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulMinBitRate { get; set; }

        [XmlElement(ElementName = "reservedBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object reservedBy { get; set; } // Unknown Type

        [XmlElement(ElementName = "schedulingAlgorithm", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int schedulingAlgorithm { get; set; }

        [XmlElement(ElementName = "dlMinBitRate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlMinBitRate { get; set; }

        [XmlElement(ElementName = "priority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int priority { get; set; }

        [XmlElement(ElementName = "sci", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sci { get; set; }

        [XmlElement(ElementName = "ulResourceAllocationStrategy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulResourceAllocationStrategy { get; set; }

        [XmlElement(ElementName = "pdb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdb { get; set; }

        [XmlElement(ElementName = "ulRelativePriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulRelativePriority { get; set; }

        [XmlElement(ElementName = "dlMaxWaitingTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlMaxWaitingTime { get; set; }

        [XmlElement(ElementName = "dlResourceAllocationStrategy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlResourceAllocationStrategy { get; set; }

        [XmlElement(ElementName = "lessMaxDelayThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lessMaxDelayThreshold { get; set; }
    }
}