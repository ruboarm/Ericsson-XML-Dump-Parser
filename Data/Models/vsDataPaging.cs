using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataPaging", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataPaging
    {
        [XmlElement(ElementName = "defaultPagingCycle", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int defaultPagingCycle { get; set; }

        [XmlElement(ElementName = "pagingDiscardTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pagingDiscardTimer { get; set; }

        [XmlElement(ElementName = "nB", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nB { get; set; }

        [XmlElement(ElementName = "maxNoOfPagingRecords", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxNoOfPagingRecords { get; set; }

        [XmlElement(ElementName = "noOfDefPagCyclPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfDefPagCyclPrim { get; set; }

        [XmlElement(ElementName = "nBBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nBBr { get; set; }

        [XmlElement(ElementName = "defaultPagingCycleNbIot", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int defaultPagingCycleNbIot { get; set; }

        [XmlElement(ElementName = "nBNbIot", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nBNbIot { get; set; }

        [XmlElement(ElementName = "numRepetitionsPagingNbIot", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int numRepetitionsPagingNbIot { get; set; }

        [XmlElement(ElementName = "pagingDiscardTimerNb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pagingDiscardTimerNb { get; set; }

        [XmlElement(ElementName = "maxNoOfPagingRecordsNb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxNoOfPagingRecordsNb { get; set; }
    }
}