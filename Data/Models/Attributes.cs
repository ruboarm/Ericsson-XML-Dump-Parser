using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class Attributes
    {
        [XmlElement(ElementName = "vsDataType", Namespace = "genericNrm.xsd")]
        public string VsDataType { get; set; }

        [XmlElement(ElementName = "vsDataFormatVersion", Namespace = "genericNrm.xsd")]
        public string VsDataFormatVersion { get; set; }

        [XmlElement(ElementName = "vsDataAreas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string VsDataAreas { get; set; }

        [XmlElement(ElementName = "vsDataPlmn")]
        public VsDataPlmn VsDataPlmn { get; set; }

        [XmlElement(ElementName = "vsDataLocationArea")]
        public VsDataLocationArea VsDataLocationArea { get; set; }

        [XmlElement(ElementName = "vsDataRoutingArea")]
        public VsDataRoutingArea VsDataRoutingArea { get; set; }

        [XmlElement(ElementName = "vsDataServiceArea")]
        public VsDataServiceArea VsDataServiceArea { get; set; }

        [XmlElement(ElementName = "vsDataExternalEUtranPlmn")]
        public VsDataExternalEUtranPlmn VsDataExternalEUtranPlmn { get; set; }

        [XmlElement(ElementName = "vsDataExternalENodeBFunction")]
        public VsDataExternalENodeBFunction VsDataExternalENodeBFunction { get; set; }

        [XmlElement(ElementName = "vsDataExternalEUtranCellFDD")]
        public VsDataExternalEUtranCellFDD VsDataExternalEUtranCellFDD { get; set; }

        [XmlElement(ElementName = "vsDataExternalGsmCell")]
        public VsDataExternalGsmCell VsDataExternalGsmCell { get; set; }
    }
}
