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
        public VsDataPlmn? VsDataPlmn { get; set; }

        [XmlElement(ElementName = "vsDataLocationArea")]
        public VsDataLocationArea? VsDataLocationArea { get; set; }

        [XmlElement(ElementName = "vsDataRoutingArea")]
        public VsDataRoutingArea? VsDataRoutingArea { get; set; }

        [XmlElement(ElementName = "vsDataServiceArea")]
        public VsDataServiceArea? VsDataServiceArea { get; set; }

        [XmlElement(ElementName = "vsDataExternalEUtranPlmn")]
        public VsDataExternalEUtranPlmn? VsDataExternalEUtranPlmn { get; set; }

        [XmlElement(ElementName = "vsDataExternalENodeBFunction")]
        public VsDataExternalENodeBFunction? VsDataExternalENodeBFunction { get; set; }

        [XmlElement(ElementName = "vsDataExternalEUtranCellFDD")]
        public VsDataExternalEUtranCellFDD? VsDataExternalEUtranCellFDD { get; set; }

        [XmlElement(ElementName = "vsDataExternalGsmCell")]
        public VsDataExternalGsmCell? VsDataExternalGsmCell { get; set; }

        [XmlElement(ElementName = "vsDataExternalGsmPlmn")]
        public VsDataExternalGsmPlmn? VsDataExternalGsmPlmn { get; set; }

        [XmlElement(ElementName = "vsDataExternalUtranCell")]
        public VsDataExternalUtranCell? VsDataExternalUtranCell { get; set; }

        [XmlElement(ElementName = "vsDataExternalUtranPlmn")]
        public VsDataExternalUtranPlmn? VsDataExternalUtranPlmn { get; set; }

        [XmlElement(ElementName = "vsDataFreqManagement")]
        public VsDataFreqManagement? VsDataFreqManagement { get; set; }

        [XmlElement(ElementName = "vsDataEUtranFrequency")]
        public VsDataEUtranFrequency? VsDataEUtranFrequency { get; set; }

        [XmlElement(ElementName = "vsDataExternalEutranFrequency")]
        public VsDataExternalEutranFrequency? VsDataExternalEutranFrequency { get; set; }

        [XmlElement(ElementName = "vsDataExternalUtranFreq")]
        public VsDataExternalUtranFreq? VsDataExternalUtranFreq { get; set; }

        [XmlElement(ElementName = "vsDataSite", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public VsDataSite? VsDataSite { get; set; }

        [XmlElement(ElementName = "vsDataMeContext", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataMeContext? vsDataMeContext { get; set; }

        [XmlElement(ElementName = "vsDataManagedElement", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataManagedElement vsDataManagedElement { get; set; }
    }
}
