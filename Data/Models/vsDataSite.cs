using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "VsDataSite", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataSite
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "location", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string Location { get; set; }

        [XmlElement(ElementName = "latitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Latitude { get; set; }

        [XmlElement(ElementName = "longitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Longitude { get; set; }

        [XmlElement(ElementName = "altitude", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Altitude { get; set; }

        [XmlElement(ElementName = "timeZone", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string TimeZone { get; set; }

        [XmlElement(ElementName = "freeText", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string FreeText { get; set; }

        [XmlElement(ElementName = "listOfNe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<string> ListOfNe { get; set; }

        [XmlElement(ElementName = "datum", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string Datum { get; set; }

        [XmlElement(ElementName = "worldTimeZoneId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string WorldTimeZoneId { get; set; }

        [XmlElement(ElementName = "daylightSavingsAdjust", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DaylightSavingsAdjust { get; set; }
    }
}
