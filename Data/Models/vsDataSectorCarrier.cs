using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSectorCarrier", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSectorCarrier
    {
        [XmlElement(ElementName = "noOfTxAntennas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfTxAntennas { get; set; }

        [XmlElement(ElementName = "maximumTransmissionPower", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maximumTransmissionPower { get; set; }

        [XmlElement(ElementName = "prsEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool prsEnabled { get; set; }

        [XmlElement(ElementName = "rfBranchTxRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? rfBranchTxRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "noOfRxAntennas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfRxAntennas { get; set; }

        [XmlElement(ElementName = "rfBranchRxRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? rfBranchRxRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "ulForcedTimingAdvanceCommand", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulForcedTimingAdvanceCommand { get; set; }

        [XmlElement(ElementName = "reservedBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string reservedBy { get; set; }

        [XmlElement(ElementName = "sectorFunctionRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string sectorFunctionRef { get; set; }

        [XmlElement(ElementName = "radioTransmitPerformanceMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int radioTransmitPerformanceMode { get; set; }

        [XmlElement(ElementName = "txPowerPersistentLock", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool txPowerPersistentLock { get; set; }

        [XmlElement(ElementName = "configuredMaxTxPower", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int configuredMaxTxPower { get; set; }

        [XmlElement(ElementName = "zzzTemporary2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? zzzTemporary2 { get; set; }

        [XmlElement(ElementName = "zzzTemporary1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? zzzTemporary1 { get; set; }

        [XmlElement(ElementName = "zzzTemporary4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary4 { get; set; }

        [XmlElement(ElementName = "zzzTemporary3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary3 { get; set; }

        [XmlElement(ElementName = "zzzTemporary6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary6 { get; set; }

        [XmlElement(ElementName = "zzzTemporary5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary5 { get; set; }

        [XmlElement(ElementName = "virtualComChBeamfrmWtsPhase", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> virtualComChBeamfrmWtsPhases { get; set; }

        [XmlElement(ElementName = "virtualComChBeamfrmWtsAmplitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> virtualComChBeamfrmWtsAmplitudes { get; set; }

        [XmlElement(ElementName = "microSleepTxActivation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool microSleepTxActivation { get; set; }

        [XmlElement(ElementName = "virtualSector", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool virtualSector { get; set; }

        [XmlElement(ElementName = "sectorShape", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sectorShape { get; set; }

        [XmlElement(ElementName = "digitalTilt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int digitalTilt { get; set; }
    }
}