using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataQciProfilePredefined", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataQciProfilePredefined
    {
        [XmlElement(ElementName = "reservedBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? reservedBy { get; set; } // Unknown Type

        [XmlElement(ElementName = "qciACTuning", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qciACTuning { get; set; }

        [XmlElement(ElementName = "absPrioOverride", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int absPrioOverride { get; set; }

        [XmlElement(ElementName = "relativePriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int relativePriority { get; set; }

        [XmlElement(ElementName = "resourceAllocationStrategy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int resourceAllocationStrategy { get; set; }

        [XmlElement(ElementName = "measReportConfigParams", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public measReportConfigParams measReportConfigParams { get; set; }

        [XmlElement(ElementName = "rlfPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rlfPriority { get; set; }

        [XmlElement(ElementName = "rlfProfileRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string rlfProfileRef { get; set; }

        [XmlElement(ElementName = "aqmMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int aqmMode { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? userLabel { get; set; }

        [XmlElement(ElementName = "drxProfileRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string drxProfileRef { get; set; }

        [XmlElement(ElementName = "rlcSNLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rlcSNLength { get; set; }

        [XmlElement(ElementName = "counterActiveMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool counterActiveMode { get; set; }

        [XmlElement(ElementName = "dscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dscp { get; set; }

        [XmlElement(ElementName = "priority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int priority { get; set; }

        [XmlElement(ElementName = "pdb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdb { get; set; }

        [XmlElement(ElementName = "dlResourceAllocationStrategy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlResourceAllocationStrategy { get; set; }

        [XmlElement(ElementName = "srsAllocationStrategy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int srsAllocationStrategy { get; set; }

        [XmlElement(ElementName = "logicalChannelGroupRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string logicalChannelGroupRef { get; set; }

        [XmlElement(ElementName = "pdcpSNLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcpSNLength { get; set; }

        [XmlElement(ElementName = "qciSubscriptionQuanta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qciSubscriptionQuanta { get; set; }

        [XmlElement(ElementName = "dataFwdPerQciEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool dataFwdPerQciEnabled { get; set; }

        [XmlElement(ElementName = "ulMinBitRate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulMinBitRate { get; set; }

        [XmlElement(ElementName = "serviceType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int serviceType { get; set; }

        [XmlElement(ElementName = "rlcMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rlcMode { get; set; }

        [XmlElement(ElementName = "qci", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qci { get; set; }

        [XmlElement(ElementName = "schedulingAlgorithm", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int schedulingAlgorithm { get; set; }

        [XmlElement(ElementName = "resourceType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int resourceType { get; set; }

        [XmlElement(ElementName = "drxPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int drxPriority { get; set; }

        [XmlElement(ElementName = "dlMinBitRate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlMinBitRate { get; set; }

        [XmlElement(ElementName = "rohcEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool rohcEnabled { get; set; }

        [XmlElement(ElementName = "inactivityTimerOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int inactivityTimerOffset { get; set; }

        [XmlElement(ElementName = "dlMaxWaitingTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlMaxWaitingTime { get; set; }

        [XmlElement(ElementName = "ulMaxWaitingTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulMaxWaitingTime { get; set; }

        [XmlElement(ElementName = "pdbOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdbOffset { get; set; }

        [XmlElement(ElementName = "timerPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timerPriority { get; set; }

        [XmlElement(ElementName = "timerProfileRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? timerProfileRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "tReorderingUl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReorderingUl { get; set; }

        [XmlElement(ElementName = "ulMaxHARQTxQci", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulMaxHARQTxQci { get; set; }

        [XmlElement(ElementName = "lessMaxDelayThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lessMaxDelayThreshold { get; set; }

        [XmlElement(ElementName = "harqPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int harqPriority { get; set; }

        [XmlElement(ElementName = "dlMaxHARQTxQci", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlMaxHARQTxQci { get; set; }

        [XmlElement(ElementName = "tReorderingDl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReorderingDl { get; set; }
    }
}