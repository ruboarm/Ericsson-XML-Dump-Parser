using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataManagedElement", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataManagedElement
    {
        [XmlElement(ElementName = "mirrorRelease", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? MirrorRelease { get; set; }

        [XmlElement(ElementName = "siteLocation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? SiteLocation { get; set; }

        [XmlElement(ElementName = "timeZone", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? TimeZone { get; set; }



        [XmlElement(ElementName = "siteRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? SiteRef { get; set; }

        [XmlElement(ElementName = "logicalName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? LogicalName { get; set; }

        [XmlElement(ElementName = "productType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? ProductType { get; set; }

        [XmlElement(ElementName = "productName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? ProductName { get; set; }

        [XmlElement(ElementName = "productNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? ProductNumber { get; set; }

        [XmlElement(ElementName = "productRevision", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? ProductRevision { get; set; }

        [XmlElement(ElementName = "dnPrefix", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? DnPrefix { get; set; }

        [XmlElement(ElementName = "sourceType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? SourceType { get; set; }

        [XmlElement(ElementName = "release", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? Release { get; set; }

        [XmlElement(ElementName = "healthCheckResult", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public HealthCheckResult? HealthCheckResult { get; set; }

        [XmlElement(ElementName = "applicationConfiguration", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? ApplicationConfiguration { get; set; }

        [XmlElement(ElementName = "site", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? Site { get; set; }
    }
}