using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataManagedElement", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataManagedElement
    {
        [XmlElement(ElementName = "mirrorRelease", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public double MirrorRelease { get; set; }

        [XmlElement(ElementName = "siteLocation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string SiteLocation { get; set; }

        [XmlElement(ElementName = "timeZone", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string TimeZone { get; set; }
    }
}