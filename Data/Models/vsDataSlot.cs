using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSlot", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSlot
    {
        [XmlElement(ElementName = "slotNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int SlotNumber { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "activeSwAllocation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ActiveSwAllocation { get; set; }
    }
}