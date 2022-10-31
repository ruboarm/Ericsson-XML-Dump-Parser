using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "systemInformationBlock7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class systemInformationBlock7
    {
        [XmlElement(ElementName = "systemInformationBlock6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MyProperty { get; set; }


        <es:tReselectionGeran>2</es:tReselectionGeran>
                      <es:tReselectionGeranSfMedium>100</es:tReselectionGeranSfMedium>
                      <es:tReselectionGeranSfHigh>100</es:tReselectionGeranSfHigh>
    }
}