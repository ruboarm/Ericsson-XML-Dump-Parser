using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataLoadBalancingFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataLoadBalancingFunction
    {
        [XmlElement(ElementName = "lbCaThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCaThreshold { get; set; }

        [XmlElement(ElementName = "lbCeiling", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCeiling { get; set; }

        [XmlElement(ElementName = "lbCauseCodeS1TargetAcceptsOffload", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCauseCodeS1TargetAcceptsOffload { get; set; }

        [XmlElement(ElementName = "lbDiffCaOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbDiffCaOffset { get; set; }

        [XmlElement(ElementName = "lbCauseCodeX2SourceTriggersOffload", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCauseCodeX2SourceTriggersOffload { get; set; }

        [XmlElement(ElementName = "lbUtranOffloadBackoffTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbUtranOffloadBackoffTime { get; set; }

        [XmlElement(ElementName = "lbMeasScalingLimit", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbMeasScalingLimit { get; set; }

        [XmlElement(ElementName = "lbHitRateUtranMeasUeThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateUtranMeasUeThreshold { get; set; }

        [XmlElement(ElementName = "lbHitRateUtranAddThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateUtranAddThreshold { get; set; }

        [XmlElement(ElementName = "lbEUtranOffloadBackoffTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbEUtranOffloadBackoffTime { get; set; }

        [XmlElement(ElementName = "lbCauseCodeX2TargetAcceptsOffload", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCauseCodeX2TargetAcceptsOffload { get; set; }

        [XmlElement(ElementName = "lbThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbThreshold { get; set; }

        [XmlElement(ElementName = "lbHitRateEUtranMeasUeThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateEUtranMeasUeThreshold { get; set; }

        [XmlElement(ElementName = "lbCauseCodeS1SourceTriggersOffload", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCauseCodeS1SourceTriggersOffload { get; set; }

        [XmlElement(ElementName = "lbHitRateEUtranAddThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateEUtranAddThreshold { get; set; }

        [XmlElement(ElementName = "lbHitRateUtranRemoveThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateUtranRemoveThreshold { get; set; }

        [XmlElement(ElementName = "txPwrForOverlaidCellDetect", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int txPwrForOverlaidCellDetect { get; set; }

        [XmlElement(ElementName = "lbCaCapHysteresis", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCaCapHysteresis { get; set; }

        [XmlElement(ElementName = "lbRateOffsetCoefficient", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbRateOffsetCoefficient { get; set; }

        [XmlElement(ElementName = "lbThrelbHitRateUtranMeasUeIntensityshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateUtranMeasUeIntensity { get; set; }

        [XmlElement(ElementName = "lbRateOffsetLoadThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbRateOffsetLoadThreshold { get; set; }

        [XmlElement(ElementName = "lbHitRateEUtranRemoveThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateEUtranRemoveThreshold { get; set; }

        [XmlElement(ElementName = "lbHitRateEUtranMeasUeIntensity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbHitRateEUtranMeasUeIntensity { get; set; }

        [XmlElement(ElementName = "lbUeEvaluationTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbUeEvaluationTimer { get; set; }

        [XmlElement(ElementName = "ocdMinHighHitThresh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ocdMinHighHitThresh { get; set; }

        [XmlElement(ElementName = "ocdMaxNoHighHitRateCells", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ocdMaxNoHighHitRateCells { get; set; }

        [XmlElement(ElementName = "isUlEvalAllowedAtTpLbHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isUlEvalAllowedAtTpLbHo { get; set; }

        [XmlElement(ElementName = "isUlEvalAllowedAtCaTrHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isUlEvalAllowedAtCaTrHo { get; set; }
    }
}