using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "operationalProductData", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class operationalProductData
    {
        [XmlElement(ElementName = "productName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ProductName { get; set; }
                      
        [XmlElement(ElementName = "productNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ProductNumber { get; set; }
                      
        [XmlElement(ElementName = "productRevision", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ProductRevision { get; set; }
                      
        [XmlElement(ElementName = "serialNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string SerialNumber { get; set; }
                      
        [XmlElement(ElementName = "productionDate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ProductionDate { get; set; }
    }
}