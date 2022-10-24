using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSubrack", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSubrack
    {
        [XmlElement(ElementName = "subrackPosition", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string SubrackPosition { get; set; }

        [XmlElement(ElementName = "cabinetPosition", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string CabinetPosition { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "numberOfSlots", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int NumberOfSlots { get; set; }

        [XmlElement(ElementName = "subrackType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int SubrackType { get; set; }

        [XmlElement(ElementName = "switchModule", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string SwitchModule { get; set; }

        [XmlElement(ElementName = "subrackProdTypeRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string SubrackProdTypeRef { get; set; }

        [XmlElement(ElementName = "subrackNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int SubrackNumber { get; set; }

        [XmlElement(ElementName = "operationalProductData", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public operationalProductData operationalProductData { get; set; }
    }
}