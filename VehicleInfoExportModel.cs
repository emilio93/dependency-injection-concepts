using System;
using System.Xml.Serialization;

namespace DependencyInjection
{

    public class VehicleInfoExportModel
    {
        [XmlAttribute]
        public string ExportBatchNumber { get; set; } = DateTime.Now.Ticks.ToString();

        [XmlAttribute]
        public string Brand { get; set; }

        [XmlAttribute]
        public string Model { get; set; }

        [XmlAttribute]
        public int Year { get; set; }
    }
}
