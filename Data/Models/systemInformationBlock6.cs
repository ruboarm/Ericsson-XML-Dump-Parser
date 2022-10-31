using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "systemInformationBlock6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class systemInformationBlock6
    {
        [XmlElement(ElementName = "systemInformationBlock6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MyProperty { get; set; }

        <es:tReselectionUtra>2</es:tReselectionUtra>
                      <es:tReselectionUtraSfMedium>100</es:tReselectionUtraSfMedium>
                      <es:tReselectionUtraSfHigh>100</es:tReselectionUtraSfHigh>
    }
}