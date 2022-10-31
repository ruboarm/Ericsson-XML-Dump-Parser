using System.Diagnostics.SymbolStore;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataEUtranCellFDD", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataEUtranCellFDD
    {
        [XmlElement(ElementName = "otdoaSuplActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool otdoaSuplActive { get; set; }

        [XmlElement(ElementName = "hoOptStatNum", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hoOptStatNum { get; set; }

        [XmlElement(ElementName = "noOfPucchSrUsers", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfPucchSrUsers { get; set; }

        [XmlElement(ElementName = "ulInterferenceManagementActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ulInterferenceManagementActive { get; set; }

        [XmlElement(ElementName = "acBarringInfoPresent", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool acBarringInfoPresent { get; set; }

        [XmlElement(ElementName = "minBestCellHoAttempts", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int minBestCellHoAttempts { get; set; }

        [XmlElement(ElementName = "cellRange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellRange { get; set; }

        [XmlElement(ElementName = "hostingDigitalUnit", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string hostingDigitalUnit { get; set; }

        [XmlElement(ElementName = "qQualMinOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qQualMinOffset { get; set; }

        [XmlElement(ElementName = "physicalLayerCellIdGroup", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int physicalLayerCellIdGroup { get; set; }

        [XmlElement(ElementName = "physicalLayerSubCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int physicalLayerSubCellId { get; set; }

        [XmlElement(ElementName = "noOfPucchCqiUsers", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfPucchCqiUsers { get; set; }

        [XmlElement(ElementName = "lbabThreshRejectRateHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabThreshRejectRateHigh { get; set; }

        [XmlElement(ElementName = "gpsTimeSFN0Seconds", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int gpsTimeSFN0Seconds { get; set; }

        [XmlElement(ElementName = "pZeroNominalPusch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pZeroNominalPusch { get; set; }

        [XmlElement(ElementName = "primaryPlmnReserved", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool primaryPlmnReserved { get; set; }

        [XmlElement(ElementName = "prsMutingPattern", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public long prsMutingPattern { get; set; }

        [XmlElement(ElementName = "highSpeedUEActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool highSpeedUEActive { get; set; }

        [XmlElement(ElementName = "bcCdma2000SysTimeType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int bcCdma2000SysTimeType { get; set; }

        [XmlElement(ElementName = "additionalFreqBandList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<object?> additionalFreqBandList { get; set; } // Unknown Type

        [XmlElement(ElementName = "latitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int latitude { get; set; }

        [XmlElement(ElementName = "longitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int longitude { get; set; }

        [XmlElement(ElementName = "altitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int altitude { get; set; }

        [XmlElement(ElementName = "crsGain", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int crsGain { get; set; }

        [XmlElement(ElementName = "dlInterferenceManagementActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool dlInterferenceManagementActive { get; set; }

        [XmlElement(ElementName = "drxActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool drxActive { get; set; }

        [XmlElement(ElementName = "lbEUtranTriggerOffloadThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbEUtranTriggerOffloadThreshold { get; set; }

        [XmlElement(ElementName = "prsPowerBoosting", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prsPowerBoosting { get; set; }

        [XmlElement(ElementName = "pdcchTargetBler", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchTargetBler { get; set; }

        [XmlElement(ElementName = "prsConfigIndexMapped", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prsConfigIndexMapped { get; set; }

        [XmlElement(ElementName = "networkSignallingValue", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int networkSignallingValue { get; set; }

        [XmlElement(ElementName = "eutranCellPolygon", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? eutranCellPolygon { get; set; } // Unknow Type

        [XmlElement(ElementName = "cfraEnable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool cfraEnable { get; set; }

        [XmlElement(ElementName = "pdschTypeBGain", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdschTypeBGain { get; set; }

        [XmlElement(ElementName = "covTriggerdBlindHoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool covTriggerdBlindHoAllowed { get; set; }

        [XmlElement(ElementName = "additionalPlmnReservedList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<bool> additionalPlmnReservedList { get; set; }

        [XmlElement(ElementName = "pZeroNominalPucch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pZeroNominalPucch { get; set; }

        [XmlElement(ElementName = "qQualMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qQualMin { get; set; }

        [XmlElement(ElementName = "qRxLevMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qRxLevMin { get; set; }

        [XmlElement(ElementName = "prsPeriod", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prsPeriod { get; set; }

        [XmlElement(ElementName = "frameStartOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public frameStartOffset frameStartOffset { get; set; }

        [XmlElement(ElementName = "cellCapMaxCellSubCap", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellCapMaxCellSubCap { get; set; }

        [XmlElement(ElementName = "lbabThreshRejectRateLow", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabThreshRejectRateLow { get; set; }

        [XmlElement(ElementName = "pciConflict", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pciConflict { get; set; }

        [XmlElement(ElementName = "advCellSupAction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int advCellSupAction { get; set; }

        [XmlElement(ElementName = "mappingInfo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public mappingInfo mappingInfo { get; set; }

        [XmlElement(ElementName = "lastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lastModification { get; set; }

        [XmlElement(ElementName = "siWindowLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siWindowLength { get; set; }

        [XmlElement(ElementName = "emergencyAreaId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> emergencyAreaIds { get; set; }

        [XmlElement(ElementName = "pucchOverdimensioning", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pucchOverdimensioning { get; set; }

        [XmlElement(ElementName = "ulFrequencyAllocationProportion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulFrequencyAllocationProportion { get; set; }

        [XmlElement(ElementName = "commonSrPeriodicity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int commonSrPeriodicity { get; set; }

        [XmlElement(ElementName = "pdcchTargetBlerPCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchTargetBlerPCell { get; set; }

        [XmlElement(ElementName = "lbUtranOffloadThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbUtranOffloadThreshold { get; set; }

        [XmlElement(ElementName = "orientMajorAxis", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int orientMajorAxis { get; set; }

        [XmlElement(ElementName = "pdcchPowerBoostMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchPowerBoostMax { get; set; }

        [XmlElement(ElementName = "ulConfigurableFrequencyStart", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulConfigurableFrequencyStart { get; set; }

        [XmlElement(ElementName = "puschMaxNrOfPrbsPerUe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int puschMaxNrOfPrbsPerUe { get; set; }

        [XmlElement(ElementName = "spectrumEmissionReqMapping", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? spectrumEmissionReqMapping { get; set; } // Unknown Type

        [XmlElement(ElementName = "uncertSemiMinor", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int uncertSemiMinor { get; set; }

        [XmlElement(ElementName = "ailgActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ailgActive { get; set; }

        [XmlElement(ElementName = "servOrPrioTriggeredIFHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int servOrPrioTriggeredIFHo { get; set; }

        [XmlElement(ElementName = "qciTableRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? qciTableRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "operationalState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int operationalState { get; set; }

        [XmlElement(ElementName = "isDlOnly", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isDlOnly { get; set; }

        [XmlElement(ElementName = "lbabIncr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabIncr { get; set; }

        [XmlElement(ElementName = "acBarringForCsfb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public acBarringForCsfb acBarringForCsfb { get; set; }

        [XmlElement(ElementName = "systemInformationBlock3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public systemInformationBlock3 systemInformationBlock3 { get; set; }

        [XmlElement(ElementName = "systemInformationBlock6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public systemInformationBlock6 systemInformationBlock6 { get; set; }

        [XmlElement(ElementName = "systemInformationBlock7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public systemInformationBlock7 systemInformationBlock7 { get; set; }

        [XmlElement(ElementName = "systemInformationBlock8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public systemInformationBlock8 systemInformationBlock8 { get; set; }

        [XmlElement(ElementName = "alpha", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int alpha { get; set; }

        [XmlElement(ElementName = "servOrPrioTriggeredErabAction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int servOrPrioTriggeredErabAction { get; set; }

        [XmlElement(ElementName = "pciConflictCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int?> pciConflictCell { get; set; } // Unknown Type

        [XmlElement(ElementName = "freqBand", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int freqBand { get; set; }

        [XmlElement(ElementName = "dlFrequencyAllocationProportion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlFrequencyAllocationProportion { get; set; }

        [XmlElement(ElementName = "noOfChannelSelectionSets", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabnoOfChannelSelectionSetsIncr { get; set; }

        [XmlElement(ElementName = "prsMutingPatternLen", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prsMutingPatternLen { get; set; }

        [XmlElement(ElementName = "qRxLevMinOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qRxLevMinOffset { get; set; }

        [XmlElement(ElementName = "activePlmnList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public ActivePlmnList activePlmnList { get; set; }

        [XmlElement(ElementName = "changeNotification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public changeNotification changeNotification { get; set; }

        [XmlElement(ElementName = "activeServiceAreaId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? activeServiceAreaId { get; set; } // Unknown Type

        [XmlElement(ElementName = "ssacBarringForMMTELVideo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public ssacBarringForMMTELVideo ssacBarringForMMTELVideo { get; set; }

        [XmlElement(ElementName = "sdmActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool sdmActive { get; set; }

        [XmlElement(ElementName = "dlConfigurableFrequencyStart", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlConfigurableFrequencyStart { get; set; }

        [XmlElement(ElementName = "tac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tac { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string userLabel { get; set; }

        [XmlElement(ElementName = "dlChannelBandwidth", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlChannelBandwidth { get; set; }

        [XmlElement(ElementName = "ulChannelBandwidth", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulChannelBandwidth { get; set; }

        [XmlElement(ElementName = "cellCapMinCellSubCap", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellCapMinCellSubCap { get; set; }

        [XmlElement(ElementName = "pdcchOuterLoopInitialAdjVolte", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchOuterLoopInitialAdjVolte { get; set; }
        
        [XmlElement(ElementName = "earfcndl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int earfcndl { get; set; }

        [XmlElement(ElementName = "earfcnul", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int earfcnul { get; set; }

        [XmlElement(ElementName = "arpPriorityLevelForSPIFHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<bool> arpPriorityLevelForSPIFHos { get; set; }

        [XmlElement(ElementName = "hoOptAdjThresholdAbs", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hoOptAdjThresholdAbs { get; set; }

        [XmlElement(ElementName = "dummyCdmaBandClass", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dummyCdmaBandClass { get; set; }

        [XmlElement(ElementName = "administrativeState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int administrativeState { get; set; }

        [XmlElement(ElementName = "advCellSupSensitivity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int advCellSupSensitivity { get; set; }

        [XmlElement(ElementName = "cellBarred", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellBarred { get; set; }

        [XmlElement(ElementName = "pdcchOuterLoopUpStepPCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchOuterLoopUpStepPCell { get; set; }

        [XmlElement(ElementName = "acBarringForMoSignalling", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public acBarringForMoSignalling acBarringForMoSignalling { get; set; }

        [XmlElement(ElementName = "uncertSemiMajor", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int uncertSemiMajor { get; set; }

        [XmlElement(ElementName = "prsTransmisScheme", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prsTransmisScheme { get; set; }

        [XmlElement(ElementName = "lbabDecr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? lbabDecr { get; set; } // Unknown Type

        [XmlElement(ElementName = "noConsecutiveSubframes", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noConsecutiveSubframes { get; set; }

        [XmlElement(ElementName = "mobCtrlAtPoorCovActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool mobCtrlAtPoorCovActive { get; set; }

        [XmlElement(ElementName = "acBarringPresence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public acBarringPresence acBarringPresence { get; set; }

        [XmlElement(ElementName = "threshServingLow", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshServingLow { get; set; }

        [XmlElement(ElementName = "gpsTimeSFN0DecimalSecond", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int gpsTimeSFN0DecimalSecond { get; set; }

        [XmlElement(ElementName = "sectorCarrierRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string sectorCarrierRef { get; set; }

        [XmlElement(ElementName = "prsConfigIndex", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? prsConfigIndex { get; set; } // Unknown Type

        [XmlElement(ElementName = "initCdma2000SysTimeType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int initCdma2000SysTimeType { get; set; }

        [XmlElement(ElementName = "confidence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int confidence { get; set; }

        [XmlElement(ElementName = "siPeriodicity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public siPeriodicity siPeriodicity { get; set; }

        [XmlElement(ElementName = "pdcchOuterLoopInitialAdjPCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchOuterLoopInitialAdjPCell { get; set; }

        [XmlElement(ElementName = "rachRootSequence", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rachRootSequence { get; set; }

        [XmlElement(ElementName = "lbEUtranCellOffloadCapacity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbEUtranCellOffloadCapacity { get; set; }

        [XmlElement(ElementName = "expectedMaxNoOfUsersInCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int expectedMaxNoOfUsersInCell { get; set; }

        [XmlElement(ElementName = "timeOfLastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime timeOfLastModification { get; set; }

        [XmlElement(ElementName = "initialBufferSizeDefault", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int initialBufferSizeDefault { get; set; }

        [XmlElement(ElementName = "lbabThreshTimeHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabThreshTimeHigh { get; set; }

        [XmlElement(ElementName = "channelSelectionSetSize", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int channelSelectionSetSize { get; set; }

        [XmlElement(ElementName = "pciDetectingCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int?> pciDetectingCell { get; set; } // Unknown Type

        [XmlElement(ElementName = "pdcchLaGinrMargin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchLaGinrMargin { get; set; }

        [XmlElement(ElementName = "lbEUtranAcceptOffloadThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbEUtranAcceptOffloadThreshold { get; set; }

        [XmlElement(ElementName = "pdcchCfiMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchCfiMode { get; set; }

        [XmlElement(ElementName = "cellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellId { get; set; }

        [XmlElement(ElementName = "zzzTemporary21", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary21 { get; set; }

        [XmlElement(ElementName = "zzzTemporary22", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary22 { get; set; }

        [XmlElement(ElementName = "zzzTemporary23", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary23 { get; set; }

        [XmlElement(ElementName = "zzzTemporary24", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary24 { get; set; }

        [XmlElement(ElementName = "acBarringForEmergency", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool acBarringForEmergency { get; set; }

        [XmlElement(ElementName = "externalCdma20001xRttCellRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? externalCdma20001xRttCellRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "pdcchOuterLoopUpStepVolte", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchOuterLoopUpStepVolte { get; set; }

        [XmlElement(ElementName = "rateShapingActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool rateShapingActive { get; set; }

        [XmlElement(ElementName = "pMaxServingCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pMaxServingCell { get; set; }

        [XmlElement(ElementName = "uncertAltitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int uncertAltitude { get; set; }

        [XmlElement(ElementName = "servOrPrioRedirectEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool servOrPrioRedirectEnabled { get; set; }

        [XmlElement(ElementName = "pdcchOuterLoopInitialAdj", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchOuterLoopInitialAdj { get; set; }

        [XmlElement(ElementName = "ssacBarringForMMTELVoice", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public ssacBarringForMMTELVoice ssacBarringForMMTELVoice { get; set; }

        [XmlElement(ElementName = "additionalSpectrumEmissionValues", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? additionalSpectrumEmissionValues { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary14", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary14 { get; set; }

        [XmlElement(ElementName = "additionalPlmnList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<additionalPlmnList> additionalPlmnList { get; set; }

        [XmlElement(ElementName = "pdcchOuterLoopUpStep", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchOuterLoopUpStep { get; set; }

        [XmlElement(ElementName = "zzzTemporary17", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool zzzTemporary17 { get; set; }

        [XmlElement(ElementName = "ulSrsEnable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ulSrsEnable { get; set; }

        [XmlElement(ElementName = "preambleInitialReceivedTargetPower", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int preambleInitialReceivedTargetPower { get; set; }

        [XmlElement(ElementName = "ailgRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? ailgRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "cioLowerLimitAdjBySon", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cioLowerLimitAdjBySon { get; set; }

        [XmlElement(ElementName = "modificationPeriodCoeff", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int modificationPeriodCoeff { get; set; }

        [XmlElement(ElementName = "lbabPeriod", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabPeriod { get; set; }

        [XmlElement(ElementName = "hoOptStatTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hoOptStatTime { get; set; }

        [XmlElement(ElementName = "otdoaCheckEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool otdoaCheckEnabled { get; set; }

        [XmlElement(ElementName = "hoOptAdjThresholdPerc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hoOptAdjThresholdPerc { get; set; }

        [XmlElement(ElementName = "eutranCellCoverage", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public eutranCellCoverage eutranCellCoverage { get; set; }

        [XmlElement(ElementName = "cioUpperLimitAdjBySon", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cioUpperLimitAdjBySon { get; set; }

        [XmlElement(ElementName = "acBarringForMoData", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public acBarringForMoData acBarringForMoData { get; set; }

        [XmlElement(ElementName = "cellSubscriptionCapacity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellSubscriptionCapacity { get; set; }

        [XmlElement(ElementName = "lbabThreshTimeLow", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabThreshTimeLow { get; set; }

        [XmlElement(ElementName = "pdcchTargetBlerVolte", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdcchTargetBlerVolte { get; set; }

        [XmlElement(ElementName = "powerLocked", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool powerLocked { get; set; }

        [XmlElement(ElementName = "csiRsConfigType8TxFDD", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csiRsConfigType8TxFDD { get; set; }

        [XmlElement(ElementName = "tTimeAlignmentTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tTimeAlignmentTimer { get; set; }

        [XmlElement(ElementName = "cellCapMinMaxWriProt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool cellCapMinMaxWriProt { get; set; }

        [XmlElement(ElementName = "primaryPlmnAlarmSuppr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool primaryPlmnAlarmSuppr { get; set; }

        [XmlElement(ElementName = "lbTpNonQualFraction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbTpNonQualFraction { get; set; }

        [XmlElement(ElementName = "additionalPlmnAlarmSupprList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<bool> additionalPlmnAlarmSupprList { get; set; }

        [XmlElement(ElementName = "includeLcgInMacUeThp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<bool> includeLcgInMacUeThps { get; set; }

        [XmlElement(ElementName = "zzzTemporary29", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary29 { get; set; }

        [XmlElement(ElementName = "idleModePrioAtReleaseRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? idleModePrioAtReleaseRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary30", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary30 { get; set; }

        [XmlElement(ElementName = "zzzTemporary31", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary31 { get; set; }

        [XmlElement(ElementName = "lbTpRankThreshMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbTpRankThreshMin { get; set; }

        [XmlElement(ElementName = "zzzTemporary32", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary32 { get; set; }

        [XmlElement(ElementName = "zzzTemporary33", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary33 { get; set; }

        [XmlElement(ElementName = "acBarringSkipForMmtelVideo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool acBarringSkipForMmtelVideo { get; set; }

        [XmlElement(ElementName = "acBarringSkipForMmtelVoice", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool acBarringSkipForMmtelVoice { get; set; }

        [XmlElement(ElementName = "acBarringSkipForSms", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool acBarringSkipForSms { get; set; }

        [XmlElement(ElementName = "cceDynUeAdmCtrlOverloadThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cceDynUeAdmCtrlOverloadThr { get; set; }

        [XmlElement(ElementName = "dlDynUeAdmCtrlOverloadThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlDynUeAdmCtrlOverloadThr { get; set; }

        [XmlElement(ElementName = "puschPwrOffset64qam", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int puschPwrOffset64qam { get; set; }

        [XmlElement(ElementName = "ulDynUeAdmCtrlRetDiffThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulDynUeAdmCtrlRetDiffThr { get; set; }

        [XmlElement(ElementName = "dynUeAdmCtrlFilterConst", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dynUeAdmCtrlFilterConst { get; set; }

        [XmlElement(ElementName = "cellDownlinkCaCapacity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellDownlinkCaCapacity { get; set; }

        [XmlElement(ElementName = "dlDynUeAdmCtrlRetDiffThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlDynUeAdmCtrlRetDiffThr { get; set; }

        [XmlElement(ElementName = "dynUeAdmCtrlEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool dynUeAdmCtrlEnabled { get; set; }

        [XmlElement(ElementName = "servOrPrioIFHoSetupBearer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool servOrPrioIFHoSetupBearer { get; set; }

        [XmlElement(ElementName = "ulDynUeAdmCtrlOverloadThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulDynUeAdmCtrlOverloadThr { get; set; }

        [XmlElement(ElementName = "networkSignallingValueCa", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int networkSignallingValueCa { get; set; }

        [XmlElement(ElementName = "cceDynUeAdmCtrlRetDiffThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cceDynUeAdmCtrlRetDiffThr { get; set; }

        [XmlElement(ElementName = "ul64qamEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ul64qamEnabled { get; set; }

        [XmlElement(ElementName = "elcEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool elcEnabled { get; set; }

        [XmlElement(ElementName = "estCellCapUsableFraction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int estCellCapUsableFraction { get; set; }

        [XmlElement(ElementName = "ulBlerTargetEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ulBlerTargetEnabled { get; set; }

        [XmlElement(ElementName = "allocThrPucchFormat1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int allocThrPucchFormat1 { get; set; }

        [XmlElement(ElementName = "maxSoftLockBackoffTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxSoftLockBackoffTime { get; set; }

        [XmlElement(ElementName = "maxSentCrsAssistCells", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxSentCrsAssistCells { get; set; }

        [XmlElement(ElementName = "deallocThrPucchFormat1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int deallocThrPucchFormat1 { get; set; }

        [XmlElement(ElementName = "dlInternalChannelBandwidth", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int dlInternalChannelBandwidth { get; set; }

        [XmlElement(ElementName = "transmissionMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int transmissionMode { get; set; }

        [XmlElement(ElementName = "ailgAutoRestartEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ailgAutoRestartEnabled { get; set; }

        [XmlElement(ElementName = "rtpTimeout", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rtpTimeout { get; set; }

        [XmlElement(ElementName = "enableUeAssistedSigReduction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool enableUeAssistedSigReduction { get; set; }

        [XmlElement(ElementName = "deallocTimerPucchFormat1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int deallocTimerPucchFormat1 { get; set; }

        [XmlElement(ElementName = "primaryPsdOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int primaryPsdOffset { get; set; }

        [XmlElement(ElementName = "clusteredPuschMprFactor", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int clusteredPuschMprFactor { get; set; }

        [XmlElement(ElementName = "allocTimerPucchFormat1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int allocTimerPucchFormat1 { get; set; }

        [XmlElement(ElementName = "dl256QamEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool dl256QamEnabled { get; set; }

        [XmlElement(ElementName = "zzzTemporary43", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary43 { get; set; }

        [XmlElement(ElementName = "zzzTemporary41", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary41 { get; set; }

        [XmlElement(ElementName = "zzzTemporary42", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary42 { get; set; }

        [XmlElement(ElementName = "ulInternalChannelBandwidth", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulInternalChannelBandwidth { get; set; }

        [XmlElement(ElementName = "enableUeAssistedAdaptiveDrx", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool enableUeAssistedAdaptiveDrx { get; set; }

        [XmlElement(ElementName = "spifhoSetupBearerAtInitialCtxtSetup", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool spifhoSetupBearerAtInitialCtxtSetup { get; set; }

        [XmlElement(ElementName = "maxNoClusteredPuschAlloc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxNoClusteredPuschAlloc { get; set; }

        [XmlElement(ElementName = "outOfCoverageSrTimerPeriodicity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int outOfCoverageSrTimerPeriodicity { get; set; }

        [XmlElement(ElementName = "ulSchedCtrlForOocUesEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ulSchedCtrlForOocUesEnabled { get; set; }

        [XmlElement(ElementName = "outOfCoverageThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int outOfCoverageThreshold { get; set; }

        [XmlElement(ElementName = "zzzTemporary50", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary50 { get; set; }

        [XmlElement(ElementName = "ttiBundlingSwitchThres", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ttiBundlingSwitchThres { get; set; }

        [XmlElement(ElementName = "pdcchCovImproveDtx", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool pdcchCovImproveDtx { get; set; }

        [XmlElement(ElementName = "lastSchedLinkAdaptEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool lastSchedLinkAdaptEnabled { get; set; }

        [XmlElement(ElementName = "prioAdditionalFreqBandList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prioAdditionalFreqBandList { get; set; }

        [XmlElement(ElementName = "ttiBundlingAfterHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ttiBundlingAfterHo { get; set; }

        [XmlElement(ElementName = "adaptiveCfiHoProhibit", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int adaptiveCfiHoProhibit { get; set; }

        [XmlElement(ElementName = "ttiBundlingAfterReest", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ttiBundlingAfterReest { get; set; }

        [XmlElement(ElementName = "srDetectHighThres", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int srDetectHighThres { get; set; }

        [XmlElement(ElementName = "ttiBundlingSwitchThresHyst", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ttiBundlingSwitchThresHyst { get; set; }

        [XmlElement(ElementName = "resourcePartitionGroupRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string resourcePartitionGroupRef { get; set; }

        [XmlElement(ElementName = "pdcchCovImproveSrb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool pdcchCovImproveSrb { get; set; }

        [XmlElement(ElementName = "srProcessingLevel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int srProcessingLevel { get; set; }

        [XmlElement(ElementName = "pdschMaxNrOfPrbsPerUe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pdschMaxNrOfPrbsPerUe { get; set; }

        [XmlElement(ElementName = "ulTrigActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ulTrigActive { get; set; }

        [XmlElement(ElementName = "ulSCellPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulSCellPriority { get; set; }

        [XmlElement(ElementName = "pdcchCovImproveQci1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool pdcchCovImproveQci1 { get; set; }

        [XmlElement(ElementName = "siValidityTimeBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int siValidityTimeBr { get; set; }

        [XmlElement(ElementName = "catm1SupportEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool catm1SupportEnabled { get; set; }

        [XmlElement(ElementName = "mappingInfoBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public mappingInfoBr mappingInfoBr { get; set; }
            
        [XmlElement(ElementName = "qQualMinRsrqCe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qQualMinRsrqCe { get; set; }

        [XmlElement(ElementName = "dynUlResourceAllocEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool dynUlResourceAllocEnabled { get; set; }

        [XmlElement(ElementName = "qRxLevMinCe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qRxLevMinCe { get; set; }

        [XmlElement(ElementName = "enableSinrUplinkClpc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool enableSinrUplinkClpc { get; set; }

        [XmlElement(ElementName = "interferenceThresholdSinrClpc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int interferenceThresholdSinrClpc { get; set; }

        [XmlElement(ElementName = "rxSinrTargetClpc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rxSinrTargetClpc { get; set; }

        [XmlElement(ElementName = "ulPsdLoadThresholdSinrClpc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulPsdLoadThresholdSinrClpc { get; set; }

        [XmlElement(ElementName = "zzzTemporary60", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary60 { get; set; }

        [XmlElement(ElementName = "zzzTemporary62", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary62 { get; set; }

        [XmlElement(ElementName = "zzzTemporary61", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary61 { get; set; }

        [XmlElement(ElementName = "zzzTemporary59", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary59 { get; set; }

        [XmlElement(ElementName = "zzzTemporary58", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary58 { get; set; }

        [XmlElement(ElementName = "zzzTemporary57", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary57 { get; set; }

        [XmlElement(ElementName = "zzzTemporary56", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary56 { get; set; }

        [XmlElement(ElementName = "zzzTemporary51", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary51 { get; set; }

        [XmlElement(ElementName = "zzzTemporary55", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary55 { get; set; }

        [XmlElement(ElementName = "zzzTemporary54", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary54 { get; set; }

        [XmlElement(ElementName = "zzzTemporary53", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary53 { get; set; }

        [XmlElement(ElementName = "zzzTemporary52", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary52 { get; set; }

        [XmlElement(ElementName = "caPrioThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int caPrioThreshold { get; set; }

        [XmlElement(ElementName = "siPeriodicityBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public siPeriodicityBr siPeriodicityBr { get; set; }

        [XmlElement(ElementName = "measBasedElcControl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool measBasedElcControl { get; set; }

        [XmlElement(ElementName = "noOfPucchFormat3PrbPairs", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfPucchFormat3PrbPairs { get; set; }

        [XmlElement(ElementName = "highestSupportedCeLevelBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int highestSupportedCeLevelBr { get; set; }

        [XmlElement(ElementName = "eDrxAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int eDrxAllowed { get; set; }

        [XmlElement(ElementName = "maxValidSubframeDlBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxValidSubframeDlBr { get; set; }

        [XmlElement(ElementName = "mixedModeRadio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mixedModeRadio { get; set; }

        [XmlElement(ElementName = "useId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? useId { get; set; } // Unknown Type

        [XmlElement(ElementName = "snExternalCdma20001xRttCellRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? snExternalCdma20001xRttCellRef { get; set; } // Unknown Type

        [XmlElement(ElementName = "pciOSSConflictingCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? pciOSSConflictingCell { get; set; } // Unknown Type

        [XmlElement(ElementName = "elcLongDrxCycle", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int elcLongDrxCycle { get; set; }

        [XmlElement(ElementName = "lessPrbUsageThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lessPrbUsageThreshold { get; set; }

        [XmlElement(ElementName = "enableServiceSpecificHARQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool enableServiceSpecificHARQ { get; set; }

        [XmlElement(ElementName = "harqOffsetDl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int harqOffsetDl { get; set; }

        [XmlElement(ElementName = "harqOffsetUl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int harqOffsetUl { get; set; }

        [XmlElement(ElementName = "tReorderingAutoConfiguration", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool tReorderingAutoConfiguration { get; set; }

        [XmlElement(ElementName = "enableDrxAwareRlcArq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool enableDrxAwareRlcArq { get; set; }

        [XmlElement(ElementName = "beamWeightSet16Tr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int beamWeightSet16Tr { get; set; }

        [XmlElement(ElementName = "dlBlerTargetEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool dlBlerTargetEnabled { get; set; }

        [XmlElement(ElementName = "interEnbUlCompUserSelSinrHys", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int interEnbUlCompUserSelSinrHys { get; set; }

        [XmlElement(ElementName = "interEnbUlCompUserSelSinrThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int interEnbUlCompUserSelSinrThr { get; set; }

        [XmlElement(ElementName = "ulTxPsdDistrThr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulTxPsdDistrThr { get; set; }

        [XmlElement(ElementName = "noOfUlImprovedUe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool noOfUlImprovedUe { get; set; }

        [XmlElement(ElementName = "zzzTemporary64", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary64 { get; set; }

        [XmlElement(ElementName = "zzzTemporary63", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary63 { get; set; }

        [XmlElement(ElementName = "zzzTemporary66", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary66 { get; set; }

        [XmlElement(ElementName = "zzzTemporary65", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int zzzTemporary65 { get; set; }

        [XmlElement(ElementName = "ulImprovedUeSchedLastEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ulImprovedUeSchedLastEnabled { get; set; }

        [XmlElement(ElementName = "tUeBlockingTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tUeBlockingTimer { get; set; }

        [XmlElement(ElementName = "bsrThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int bsrThreshold { get; set; }

        [XmlElement(ElementName = "lbabMinBarringFactor", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabMinBarringFactor { get; set; }

        [XmlElement(ElementName = "ulHarqVolteBlerTarget", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ulHarqVolteBlerTarget { get; set; }

        [XmlElement(ElementName = "lbabBarringPriorityLevel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabBarringPriorityLevel { get; set; }

        [XmlElement(ElementName = "prioHpueCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int prioHpueCapability { get; set; }

        [XmlElement(ElementName = "loadBasedBarringFactor", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int loadBasedBarringFactor { get; set; }

        [XmlElement(ElementName = "lbabMinBarringFactorPrio1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabMinBarringFactorPrio1 { get; set; }

        [XmlElement(ElementName = "lbabMinBarringFactorPrio2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbabMinBarringFactorPrio2 { get; set; }

        [XmlElement(ElementName = "noOfEnhAdptReTxCand", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int noOfEnhAdptReTxCand { get; set; }

        [XmlElement(ElementName = "beamWeightSet16TrTm9", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int beamWeightSet16TrTm9 { get; set; }

        [XmlElement(ElementName = "csiRsConfigType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csiRsConfigType { get; set; }

        [XmlElement(ElementName = "mappingInfoCe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public mappingInfoCe mappingInfoCe { get; set; }
    }
}
