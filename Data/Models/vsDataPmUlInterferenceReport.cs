using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataPmUlInterferenceReport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataPmUlInterferenceReport
    {
        [XmlElement(ElementName = "rfBranchRxRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string rfBranchRxRef { get; set; }

    }
}