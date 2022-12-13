using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "healthCheckResult", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class HealthCheckResult
    {
        //[XmlElement(ElementName = "startTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        [XmlIgnore]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}")]
        public DateTime StartTime { get; set; }

        [XmlElement(ElementName = "startTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string StartTimeAsText
        {
            get { return (StartTime != null) ? StartTime.ToString() : null; }
            set { StartTime = !string.IsNullOrEmpty(value) ? DateTime.Parse(value) : default(DateTime); }
        }

        [XmlElement(ElementName = "message", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? Message { get; set; }

        [XmlElement(ElementName = "healthCheckResultCode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int HealthCheckResultCode { get; set; }
    }
}