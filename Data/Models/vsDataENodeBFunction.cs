using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataENodeBFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataENodeBFunction
    {
        [XmlElement(ElementName = "stnNodes", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object StnNodes { get; set; } // Unknown Type

        [XmlElement(ElementName = "tcuNodes", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object TcuNodes { get; set; } // Unknown Type

        [XmlElement(ElementName = "nnsfMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int NnsfMode { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviation { get; set; }

        [XmlElement(ElementName = "forcedSiTunnelingActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ForcedSiTunnelingActive { get; set; }

        [XmlElement(ElementName = "pwsPersistentStorage", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PwsPersistentStorage { get; set; }

        [XmlElement(ElementName = "x2WhiteList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object X2WhiteList { get; set; } // Unknown Type

        [XmlElement(ElementName = "upIpAddressRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UpIpAddressRef { get; set; }

        [XmlElement(ElementName = "zzzTemporary9", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary9 { get; set; }

        [XmlElement(ElementName = "eNodeBPlmnId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public ENodeBPlmnId eNodeBPlmnId { get; set; }

        [XmlElement(ElementName = "zzzTemporary7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary7 { get; set; } // Unknown Type

        [XmlElement(ElementName = "dscpLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DscpLabel { get; set; }

        [XmlElement(ElementName = "zzzTemporary8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary8 { get; set; } // Unknown Type

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "rrcConnReestActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool RrcConnReestActive { get; set; }

        [XmlElement(ElementName = "zzzTemporary21", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary21 { get; set; }

        [XmlElement(ElementName = "zzzTemporary22", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary22 { get; set; }

        [XmlElement(ElementName = "x2retryTimerStart", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int X2retryTimerStart { get; set; }

        [XmlElement(ElementName = "zzzTemporary25", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary25 { get; set; }

        [XmlElement(ElementName = "zzzTemporary26", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary26 { get; set; }

        [XmlElement(ElementName = "zzzTemporary23", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary23 { get; set; }

        [XmlElement(ElementName = "zzzTemporary24", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary24 { get; set; }

        [XmlElement(ElementName = "x2SetupTwoWayRelations", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool X2SetupTwoWayRelations { get; set; }

        [XmlElement(ElementName = "licCapDistrMethod", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int licCapDistrMethoL { get; set; }

        [XmlElement(ElementName = "timeAndPhaseSynchCritical", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool TimeAndPhaseSynchCritical { get; set; }

        [XmlElement(ElementName = "ulSchedulerDynamicBWAllocationEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool UlSchedulerDynamicBWAllocationEnabled { get; set; }

        [XmlElement(ElementName = "zzzTemporary2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary2 { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary1 { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary3 { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary6 { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary10", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary10 { get; set; }

        [XmlElement(ElementName = "s1RetryTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int S1RetryTimer { get; set; }

        [XmlElement(ElementName = "zzzTemporary5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary5 { get; set; } // Unknown Type

        [XmlElement(ElementName = "zzzTemporary11", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary11 { get; set; }

        [XmlElement(ElementName = "zzzTemporary12", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary12 { get; set; }

        [XmlElement(ElementName = "zzzTemporary13", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary13 { get; set; }

        [XmlElement(ElementName = "randUpdateInterval", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RandUpdateInterval { get; set; }

        [XmlElement(ElementName = "x2IpAddrViaS1Active", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool X2IpAddrViaS1Active { get; set; }

        [XmlElement(ElementName = "zzzTemporary16", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary16 { get; set; }

        [XmlElement(ElementName = "zzzTemporary18", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary18 { get; set; }

        [XmlElement(ElementName = "maxRandc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MaxRandc { get; set; }

        [XmlElement(ElementName = "sctpRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string SctpRef { get; set; }

        [XmlElement(ElementName = "minRandc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MinRandc { get; set; }

        [XmlElement(ElementName = "s1HODirDataPathAvail", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool S1HODirDataPathAvail { get; set; }

        [XmlElement(ElementName = "mfbiSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool MfbiSupport { get; set; }

        [XmlElement(ElementName = "dnsLookupOnTai", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DnsLookupOnTai { get; set; }

        [XmlElement(ElementName = "dnsLookupTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DnsLookupTimer { get; set; }

        [XmlElement(ElementName = "x2BlackList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object x2BlackList { get; set; } // Unknown Type

        [XmlElement(ElementName = "initPreschedulingEnable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool InitPreschedulingEnable { get; set; }

        [XmlElement(ElementName = "tOutgoingHoExecCdma1xRtt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TOutgoingHoExecCdma1xRtt { get; set; }

        [XmlElement(ElementName = "csfbMeasFromIdleMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool CsfbMeasFromIdleMode { get; set; }

        [XmlElement(ElementName = "eNBId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ENBId { get; set; }

        [XmlElement(ElementName = "x2retryTimerMaxAuto", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int X2retryTimerMaxAuto { get; set; }

        [XmlElement(ElementName = "biasThpWifiMobility", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int BiasThpWifiMobility { get; set; }

        [XmlElement(ElementName = "releaseInactiveUesMpLoadLevel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ReleaseInactiveUesMpLoadLevel { get; set; }

        [XmlElement(ElementName = "dnsSelectionS1X2Ref", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object DnsSelectionS1X2Ref { get; set; } // Unknown Type

        [XmlElement(ElementName = "tS1HoCancelTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TS1HoCancelTimer { get; set; }

        [XmlElement(ElementName = "combCellSectorSelectThreshRx", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CombCellSectorSelectThreshRx { get; set; }

        [XmlElement(ElementName = "combCellSectorSelectThreshTx", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CombCellSectorSelectThreshTx { get; set; }

        [XmlElement(ElementName = "releaseInactiveUesInactTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ReleaseInactiveUesInactTime { get; set; }

        [XmlElement(ElementName = "plmnBorderNode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PlmnBorderNode { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationMbms", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationMbms { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationOtdoa", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationOtdoa { get; set; }

        [XmlElement(ElementName = "licUlBbPercentileConf", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicUlBbPercentileConf { get; set; }

        [XmlElement(ElementName = "licUlPrbPercentileConf", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicUlPrbPercentileConf { get; set; }

        [XmlElement(ElementName = "release", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string Release { get; set; }

        [XmlElement(ElementName = "licDlPrbPercentileConf", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicDlPrbPercentileConf { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationSib16", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationSib16 { get; set; }

        [XmlElement(ElementName = "timeAndPhaseSynchAlignment", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool TimeAndPhaseSynchAlignment { get; set; }

        [XmlElement(ElementName = "mtRreWithoutNeighborActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool MtRreWithoutNeighborActive { get; set; }

        [XmlElement(ElementName = "licDlBbPercentileConf", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicDlBbPercentileConf { get; set; }

        [XmlElement(ElementName = "licConnectedUsersPercentileConf", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicConnectedUsersPercentileConf { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationCdma2000", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationCdma2000 { get; set; }

        [XmlElement(ElementName = "ulMaxWaitingTimeGlobal", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int UlMaxWaitingTimeGlobal { get; set; }

        [XmlElement(ElementName = "softLockRwRWaitTimerInternal", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int SoftLockRwRWaitTimerInternal { get; set; }

        [XmlElement(ElementName = "enabledUlTrigMeas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool EnabledUlTrigMeas { get; set; }

        [XmlElement(ElementName = "dlMaxWaitingTimeGlobal", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DlMaxWaitingTimeGlobal { get; set; }

        [XmlElement(ElementName = "tddVoipDrxProfileId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TddVoipDrxProfileId { get; set; }

        [XmlElement(ElementName = "mfbiSupportPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool MfbiSupportPolicy { get; set; }

        [XmlElement(ElementName = "zzzTemporary28", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary28 { get; set; }

        [XmlElement(ElementName = "measuringEcgiWithAgActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool MeasuringEcgiWithAgActive { get; set; }

        [XmlElement(ElementName = "checkEmergencySoftLock", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool CheckEmergencySoftLock { get; set; }

        [XmlElement(ElementName = "softLockRwRWaitTimerOperator", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int SoftLockRwRWaitTimerOperator { get; set; }

        [XmlElement(ElementName = "zzzTemporary32", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary32 { get; set; }

        [XmlElement(ElementName = "zzzTemporary33", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary33 { get; set; }

        [XmlElement(ElementName = "zzzTemporary34", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary34 { get; set; }

        [XmlElement(ElementName = "tRelocOverall", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TRelocOverall { get; set; }

        [XmlElement(ElementName = "alignTtiBundWUlTrigSinr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int AlignTtiBundWUlTrigSinr { get; set; }

        [XmlElement(ElementName = "useBandPrioritiesInSCellEval", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool UseBandPrioritiesInSCellEval { get; set; }

        [XmlElement(ElementName = "prioritizeAdditionalBands", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PrioritizeAdditionalBands { get; set; }

        [XmlElement(ElementName = "caAwareMfbiIntraCellHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool CaAwareMfbiIntraCellHo { get; set; }

        [XmlElement(ElementName = "zzzTemporary40", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary40 { get; set; }

        [XmlElement(ElementName = "zzzTemporary39", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary39 { get; set; }

        [XmlElement(ElementName = "zzzTemporary35", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary35 { get; set; }

        [XmlElement(ElementName = "zzzTemporary36", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary36 { get; set; }

        [XmlElement(ElementName = "zzzTemporary37", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary37 { get; set; }

        [XmlElement(ElementName = "gtpuErrorIndicationDscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int GtpuErrorIndicationDscp { get; set; }

        [XmlElement(ElementName = "s1GtpuEchoFailureAction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int S1GtpuEchoFailureAction { get; set; }

        [XmlElement(ElementName = "s1GtpuEchoEnable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int S1GtpuEchoEnable { get; set; }

        [XmlElement(ElementName = "x2GtpuEchoDscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int X2GtpuEchoDscp { get; set; }

        [XmlElement(ElementName = "x2GtpuEchoEnable", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int X2GtpuEchoEnable { get; set; }

        [XmlElement(ElementName = "s1GtpuEchoDscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int S1GtpuEchoDscp { get; set; }

        [XmlElement(ElementName = "useBandPrioritiesInSib1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool UseBandPrioritiesInSib1 { get; set; }

        [XmlElement(ElementName = "eranVlanPortRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object EranVlanPortRef { get; set; } // Unknow Type

        [XmlElement(ElementName = "zzzTemporary51", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary51 { get; set; }

        [XmlElement(ElementName = "zzzTemporary50", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary50 { get; set; }

        [XmlElement(ElementName = "zzzTemporary54", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary54 { get; set; }

        [XmlElement(ElementName = "zzzTemporary53", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary53 { get; set; }

        [XmlElement(ElementName = "zzzTemporary52", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary52 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationIeNbCa", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationIeNbCa { get; set; }

        [XmlElement(ElementName = "sctpX2Ref", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object SctpX2Ref { get; set; } // Unknow Type

        [XmlElement(ElementName = "timePhaseMaxDeviationEdrx", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationEdrx { get; set; }

        [XmlElement(ElementName = "interEnbCaTunnelDscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int InterEnbCaTunnelDscp { get; set; }

        [XmlElement(ElementName = "zzzTemporary43", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary43 { get; set; } // Unknow Type

        [XmlElement(ElementName = "zzzTemporary41", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary41 { get; set; }

        [XmlElement(ElementName = "zzzTemporary42", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary42 { get; set; }

        [XmlElement(ElementName = "zzzTemporary49", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary49 { get; set; }

        [XmlElement(ElementName = "zzzTemporary47", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary47 { get; set; }

        [XmlElement(ElementName = "zzzTemporary48", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary48 { get; set; }

        [XmlElement(ElementName = "upX2IpAddressRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object UpX2IpAddressRef { get; set; } // Unknow Type

        [XmlElement(ElementName = "altNasBackTo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int AltNasBackTo { get; set; }

        [XmlElement(ElementName = "ipsecEpAddressRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object IpsecEpAddressRef { get; set; } // Unknow Type

        [XmlElement(ElementName = "csmMinHighHitThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CsmMinHighHitThreshold { get; set; }

        [XmlElement(ElementName = "csfbUseRegisteredLai", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool CsfbUseRegisteredLai { get; set; }

        [XmlElement(ElementName = "interEnbUlCompTunnelDscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int InterEnbUlCompTunnelDscp { get; set; }

        [XmlElement(ElementName = "extendedWaitTimeNb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ExtendedWaitTimeNb { get; set; }

        [XmlElement(ElementName = "inactivitySupervisionTimerNb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> InactivitySupervisionTimerNbs { get; set; }

        [XmlElement(ElementName = "zzzTemporary55", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary55 { get; set; }

        [XmlElement(ElementName = "maxNrOfInterEnbUlCompLbm", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MaxNrOfInterEnbUlCompLbm { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd6 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd5 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd7 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd2 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd1 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd4 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDeviationTdd3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDeviationTdd3 { get; set; }

        [XmlElement(ElementName = "timePhaseMaxDevIeNBUlComp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TimePhaseMaxDevIeNBUlComp { get; set; }

        [XmlElement(ElementName = "zzzTemporary58", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary58 { get; set; }

        [XmlElement(ElementName = "zzzTemporary57", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary57 { get; set; }

        [XmlElement(ElementName = "zzzTemporary56", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary56 { get; set; }

        [XmlElement(ElementName = "rpUpIpAddressRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object RpUpIpAddressRef { get; set; } // Unknow Type

        [XmlElement(ElementName = "intraRanIpAddressRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object IntraRanIpAddressRef { get; set; } // Unknow Type
    }
}
