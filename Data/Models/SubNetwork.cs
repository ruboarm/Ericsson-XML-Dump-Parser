﻿using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "SubNetwork", Namespace = "genericNrm.xsd")]
    public class SubNetwork
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public SubNetworkAttributes? Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public List<VsDataContainer>? VsDataContainers { get; set; }

        [XmlElement(ElementName = "ExternalGsmCell", Namespace = "geranNrm.xsd")]
        public List<ExternalGsmCell>? ExternalGsmCells { get; set; }

        [XmlElement(ElementName = "ExternalUtranCell", Namespace = "utranNrm.xsd")]
        public List<ExternalUtranCell>? ExternalUtranCells { get; set; }

        [XmlElement(ElementName = "ManagementNode", Namespace = "genericNrm.xsd")]
        public ManagementNode? ManagementNode { get; set; }

        [XmlElement(ElementName = "SubNetwork", Namespace = "genericNrm.xsd")]
        public List<SubNetwork>? SubNetworks { get; set; }

        [XmlElement(ElementName = "MeContext", Namespace = "genericNrm.xsd")]
        public List<MeContext>? MeContexts { get; set; }

        [XmlElement(ElementName = "ManagedElement", Namespace = "genericNrm.xsd")]
        public ManagedElement? ManagedElement { get; set; }
    }
}
