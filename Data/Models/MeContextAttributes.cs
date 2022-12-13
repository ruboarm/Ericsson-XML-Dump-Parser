using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class MeContextAttributes
    {
        [XmlElement(ElementName = "dnPrefix", Namespace = "genericNrm.xsd")]
        public string? DnPrefix { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "genericNrm.xsd")]
        public string UserLabel { get; set; }
        
        [XmlElement(ElementName = "ipAddress", Namespace = "genericNrm.xsd")]
        public string IpAddress { get; set; }

        [XmlElement(ElementName = "segmentName", Namespace = "genericNrm.xsd")]
        public string SegmentName { get; set; }
            
        [XmlElement(ElementName = "mimSwitchPolicy", Namespace = "genericNrm.xsd")]
        public int MimSwitchPolicy { get; set; }

        [XmlElement(ElementName = "neMIMversion", Namespace = "genericNrm.xsd")]
        public string NeMIMversion { get; set; }

        [XmlElement(ElementName = "compatibilityOfMIMs", Namespace = "genericNrm.xsd")]
        public bool CompatibilityOfMIMs { get; set; }

        [XmlElement(ElementName = "connectionStatus", Namespace = "genericNrm.xsd")]
        public int ConnectionStatus { get; set; }

        [XmlElement(ElementName = "mirrorMIBsynchStatus", Namespace = "genericNrm.xsd")]
        public int MirrorMIBsynchStatus { get; set; }

        [XmlElement(ElementName = "mirrorMIBupdateStatus", Namespace = "genericNrm.xsd")]
        public int MirrorMIBupdateStatus { get; set; }

        [XmlElement(ElementName = "generationCounter", Namespace = "genericNrm.xsd")]
        public int GenerationCounter { get; set; }

        [XmlElement(ElementName = "neMIMName", Namespace = "genericNrm.xsd")]
        public string NeMIMName { get; set; }

        [XmlElement(ElementName = "neType", Namespace = "genericNrm.xsd")]
        public int NeType { get; set; }

        [XmlElement(ElementName = "neCreationComplete", Namespace = "genericNrm.xsd")]
        public bool NeCreationComplete { get; set; }

        [XmlElement(ElementName = "restartWarning", Namespace = "genericNrm.xsd")]
        public bool RestartWarning { get; set; }

        [XmlElement(ElementName = "rollbackMirrorMIBname", Namespace = "genericNrm.xsd")]
        public string? RollbackMirrorMIBname { get; set; }

        [XmlElement(ElementName = "neSecurityStatus", Namespace = "genericNrm.xsd")]
        public string NeSecurityStatus { get; set; }

        [XmlElement(ElementName = "bcrLastChange", Namespace = "genericNrm.xsd")]
        public long BcrLastChange { get; set; }

        [XmlElement(ElementName = "bctLastChange", Namespace = "genericNrm.xsd")]
        public long BctLastChange { get; set; }

        [XmlElement(ElementName = "telisLastChange", Namespace = "genericNrm.xsd")]
        public int TelisLastChange { get; set; }

        [XmlElement(ElementName = "lostSynchronisation", Namespace = "genericNrm.xsd")]
        public string LostSynchronisation { get; set; }

        [XmlIgnore]
        public DateTime? NodeStartTime { get; set; }

        [XmlElement(ElementName = "nodeStartTime", Namespace = "genericNrm.xsd")]
        public string NodeStartTimeAsText
        {
            get { return (NodeStartTime.HasValue) ? NodeStartTime.ToString() : null; }
            set { NodeStartTime = !string.IsNullOrEmpty(value) ? DateTime.Parse(value) : default(DateTime?); }
        }

        [XmlElement(ElementName = "pendingRestart", Namespace = "genericNrm.xsd")]
        public bool PendingRestart { get; set; }
    }
}
