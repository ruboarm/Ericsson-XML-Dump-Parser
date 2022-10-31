using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "acBarringForMoSignalling", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class acBarringForMoSignalling : acBarringFor
    {
    }
}