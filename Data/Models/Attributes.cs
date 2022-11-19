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
        public string? VsDataAreas { get; set; }

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

        [XmlElement(ElementName = "vsDataEquipment", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataEquipment? vsDataEquipment { get; set; }

        [XmlElement(ElementName = "vsDataSubrack", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataSubrack? vsDataSubrack { get; set; }

        [XmlElement(ElementName = "vsDataSlot", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataSlot? vsDataSlot { get; set; }

        [XmlElement(ElementName = "vsDataPlugInUnit", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataPlugInUnit? vsDataPlugInUnit { get; set; }

        [XmlElement(ElementName = "vsDataEthernetSwitchModule", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataEthernetSwitchModule? vsDataEthernetSwitchModule { get; set; }

        [XmlElement(ElementName = "vsDataInteractiveMessaging", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? vsDataInteractiveMessaging { get; set; } // Unknown type

        [XmlElement(ElementName = "vsDataIpSystem", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataIpSystem? vsDataIpSystem { get; set; }

        [XmlElement(ElementName = "vsDataDnsClient", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataDnsClient? vsDataDnsClient { get; set; }

        [XmlElement(ElementName = "vsDataMrfpFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataMrfpFunction? vsDataMrfpFunction { get; set; }

        [XmlElement(ElementName = "vsDataBfcp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataBfcp? vsDataBfcp { get; set; }

        [XmlElement(ElementName = "vsDataBfcpApplication", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<vsDataBfcpApplication>? vsDataBfcpApplications { get; set; }

        [XmlElement(ElementName = "vsDataMsProcessing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataMsProcessing? vsDataMsProcessing { get; set; }

        [XmlElement(ElementName = "vsDataEvsService", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? vsDataEvsService { get; set; } // Unknown type

        [XmlElement(ElementName = "vsDataPcmService", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataPcmService? vsDataPcmService { get; set; }

        [XmlElement(ElementName = "vsDataSwManagement", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataSwManagement? vsDataSwManagement { get; set; }

        [XmlElement(ElementName = "vsDataConfigurationVersion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataConfigurationVersion? vsDataConfigurationVersion { get; set; }

        [XmlElement(ElementName = "vsDataSwAllocation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataSwAllocation? vsDataSwAllocation { get; set; }

        [XmlElement(ElementName = "vsDataSystemFunctions", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataSystemFunctions? vsDataSystemFunctions { get; set; }

        [XmlElement(ElementName = "vsDataLicensing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataLicensing? vsDataLicensing { get; set; }

        [XmlElement(ElementName = "vsDataSecurity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataSecurity? vsDataSecurity { get; set; }

        [XmlElement(ElementName = "vsDataRealTimeSecLog", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataRealTimeSecLog? vsDataRealTimeSecLog { get; set; }

        [XmlElement(ElementName = "vsDataENodeBFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataENodeBFunction? vsDataENodeBFunction { get; set; }

        [XmlElement(ElementName = "vsDataAdmissionControl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataAdmissionControl? vsDataAdmissionControl { get; set; }

        [XmlElement(ElementName = "vsDataAnrFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataAnrFunction? vsDataAnrFunction { get; set; }

        [XmlElement(ElementName = "vsDataAnrFunctionEUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataAnrFunctionEUtran? vsDataAnrFunctionEUtran { get; set; }

        [XmlElement(ElementName = "vsDataAnrFunctionGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataAnrFunctionGeran? vsDataAnrFunctionGeran { get; set; }

        [XmlElement(ElementName = "vsDataAnrFunctionUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataAnrFunctionUtran? vsDataAnrFunctionUtran { get; set; }

        [XmlElement(ElementName = "vsDataDrxProfile", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataDrxProfile? vsDataDrxProfile { get; set; }

        [XmlElement(ElementName = "vsDataEUtraNetwork", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataEUtraNetwork? vsDataEUtraNetwork { get; set; }

        [XmlElement(ElementName = "vsDataEUtranCellFDD", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataEUtranCellFDD? vsDataEUtranCellFDD { get; set; }

        [XmlElement(ElementName = "vsDataEUtranFreqRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataEUtranFreqRelation? vsDataEUtranFreqRelation { get; set; }

        [XmlElement(ElementName = "vsDataEUtranCellRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataEUtranCellRelation? vsDataEUtranCellRelation { get; set; }

        [XmlElement(ElementName = "vsDataMimoSleepFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataMimoSleepFunction? vsDataMimoSleepFunction { get; set; }

        [XmlElement(ElementName = "vsDataUeMeasControl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataUeMeasControl? vsDataUeMeasControl { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigA1Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigA1Prim? vsDataReportConfigA1Prim { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigA1Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigA1Sec? vsDataReportConfigA1Sec { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigA4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigA4? vsDataReportConfigA4 { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigA5? vsDataReportConfigA5 { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigA5Anr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigA5Anr? vsDataReportConfigA5Anr { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigA5UlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigA5UlTrig? vsDataReportConfigA5UlTrig { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB1Geran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB1Geran? vsDataReportConfigB1Geran { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB1Utra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB1Utra? vsDataReportConfigB1Utra { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB2Cdma20001xRtt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB2Cdma20001xRtt? vsDataReportConfigB2Cdma20001xRtt { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB2Cdma2000", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB2Cdma2000? vsDataReportConfigB2Cdma2000 { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB2Geran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB2Geran? vsDataReportConfigB2Geran { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB2GeranUlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB2GeranUlTrig? vsDataReportConfigB2GeranUlTrig { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB2Utra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB2Utra? vsDataReportConfigB2Utra { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigB2UtraUlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigB2UtraUlTrig? vsDataReportConfigB2UtraUlTrig { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigCsfbCdma2000", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigCsfbCdma2000? vsDataReportConfigCsfbCdma2000 { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigCsfbGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigCsfbGeran? vsDataReportConfigCsfbGeran { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigCsfbUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigCsfbUtra? vsDataReportConfigCsfbUtra { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigCsg", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigCsg? vsDataReportConfigCsg { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraBadCovPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraBadCovPrim? vsDataReportConfigEUtraBadCovPrim { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraBadCovSec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraBadCovSec? vsDataReportConfigEUtraBadCovSec { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraBestCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraBestCell? vsDataReportConfigEUtraBestCell { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraBestCellAnr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraBestCellAnr? vsDataReportConfigEUtraBestCellAnr { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraIFA3UlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraIFA3UlTrig? vsDataReportConfigEUtraIFA3UlTrig { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraIFBestCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraIFBestCell? vsDataReportConfigEUtraIFBestCell { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigEUtraInterFreqLb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigEUtraInterFreqLb? vsDataReportConfigEUtraInterFreqLb { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigInterRatLb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigInterRatLb? vsDataReportConfigInterRatLb { get; set; }

        [XmlElement(ElementName = "vsDataReportConfigSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataReportConfigSearch? vsDataReportConfigSearch { get; set; }

        [XmlElement(ElementName = "vsDataUtranFreqRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataUtranFreqRelation? vsDataUtranFreqRelation { get; set; }

        [XmlElement(ElementName = "vsDataUtranCellRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public vsDataUtranCellRelation? vsDataUtranCellRelation { get; set; }
        
    }
}
