using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DependencyInjection
{
    [XmlRoot("VehicleInfoExportModel")]
    public class VehicleInfo
    {
        [JsonIgnore]
        [XmlIgnore]
        public string VIN { get; set; } = DateTime.Now.Ticks.ToString();

        [XmlElement("Brand")]
        public string Brand { get; set; }

        [XmlElement("Model")]
        public string Model { get; set; }

        [XmlElement("Year")]
        public int Year { get; set; }
    }
}
