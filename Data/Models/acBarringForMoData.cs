using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "acBarringForMoData", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class acBarringForMoData : acBarringFor
    {
        //[XmlElement(ElementName = "acBarringFactor", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        //public int acBarringFactor { get; set; }

        //[XmlElement(ElementName = "acBarringTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        //public int acBarringTime { get; set; }

        //[XmlElement(ElementName = "acBarringForSpecialAC", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        //public List<bool> acBarringForSpecialACs { get; set; }
    }
}