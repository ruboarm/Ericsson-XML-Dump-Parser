using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataTermPointToMme", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataTermPointToMme
    {
        [XmlElement(ElementName = "mmeCodeListLTERelated", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mmeCodeListLTERelated { get; set; }

        [XmlElement(ElementName = "ipAddress2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ipAddress2 { get; set; }

        [XmlElement(ElementName = "ipv6Address1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ipv6Address1 { get; set; }

        [XmlElement(ElementName = "mmeGIListLTERelated", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mmeGIListLTERelated { get; set; }

        [XmlElement(ElementName = "ipAddress1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ipAddress1 { get; set; }

        [XmlElement(ElementName = "ipv6Address2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ipv6Address2 { get; set; }

        [XmlElement(ElementName = "mmeName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string mmeName { get; set; }

        [XmlElement(ElementName = "domainName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? domainName { get; set; }

        [XmlElement(ElementName = "relativeMmeCapacity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int relativeMmeCapacity { get; set; }

        [XmlElement(ElementName = "mmeCodeListOtherRATs", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? mmeCodeListOtherRATs { get; set; } // Unknown Type

        [XmlElement(ElementName = "servedPlmnListLTERelated", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public servedPlmnListLTERelated servedPlmnListLTERelated { get; set; }

        [XmlElement(ElementName = "servedPlmnListOtherRATs", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? servedPlmnListOtherRATs { get; set; } // Unknown Type

        [XmlElement(ElementName = "administrativeState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int administrativeState { get; set; }

        [XmlElement(ElementName = "usedIpAddress", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string usedIpAddress { get; set; }

        [XmlElement(ElementName = "dcnType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dcnType { get; set; }

        [XmlElement(ElementName = "additionalCnRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? additionalCnRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "mmeSupportNbIoT", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool mmeSupportNbIoT { get; set; }

        [XmlElement(ElementName = "mmeSupportLegacyLte", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool mmeSupportLegacyLte { get; set; }
    }
}