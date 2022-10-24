using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataPlugInUnit", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataPlugInUnit
    {
        [XmlElement(ElementName = "administrativeState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int AdministrativeState { get; set; }

        [XmlElement(ElementName = "allowedSeqRestarts", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int AllowedSeqRestarts { get; set; }

        [XmlElement(ElementName = "piuGroupNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PiuGroupNumber { get; set; }

        [XmlElement(ElementName = "piuType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string PiuType { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "positionRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string PositionRef { get; set; }
    }
}