﻿using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "ManagedElement", Namespace = "genericNrm.xsd")]
    public class ManagedElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public ManagedElementAttributes Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public VsDataContainer VsDataContainer { get; set; }
    }
}