using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class ManagedElementAttributes
    {
        [XmlElement(ElementName = "locationName", Namespace = "genericNrm.xsd")]
        public string? LocationName { get; set; }
        
        [XmlIgnore]
        public int? UserDefinedState { get; set; }

        [XmlElement(ElementName = "userDefinedState", Namespace = "genericNrm.xsd")]
        public string UserDefinedStateAsText
        {
            get { return (UserDefinedState.HasValue) ? UserDefinedState.ToString() : null; }
            set { UserDefinedState = !string.IsNullOrEmpty(value) ? int.Parse(value) : default(int?); }
        }

        [XmlElement(ElementName = "vendorName", Namespace = "genericNrm.xsd")]
        public string? VendorName { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "genericNrm.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "managedElementType", Namespace = "genericNrm.xsd")]
        public string ManagedElementType { get; set; }

        [XmlElement(ElementName = "swVersion", Namespace = "genericNrm.xsd")]
        public string SwVersion { get; set; }

        [XmlElement(ElementName = "managedBy", Namespace = "genericNrm.xsd")]
        public string ManagedBy { get; set; }

        [XmlElement(ElementName = "dnPrefix", Namespace = "genericNrm.xsd")]
        public string? DnPrefix { get; set; }

        [XmlElement(ElementName = "sourceType", Namespace = "genericNrm.xsd")]
        public string? SourceType { get; set; }

        [XmlElement(ElementName = "release", Namespace = "genericNrm.xsd")]
        public string? Release { get; set; }

        [XmlElement(ElementName = "siteRef", Namespace = "genericNrm.xsd")]
        public string? SiteRef { get; set; }
    }
}