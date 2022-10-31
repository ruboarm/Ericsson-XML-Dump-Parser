using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "frameStartOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class frameStartOffset
    {
        [XmlElement(ElementName = "subFrameOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int subFrameOffset { get; set; }
    }
}