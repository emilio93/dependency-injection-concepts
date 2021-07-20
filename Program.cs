using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<VehicleInfo> vehicleList = new List<VehicleInfo>();
            for (int i = 1; i <= 10; i++)
            {
                vehicleList.Add(new VehicleInfo()
                {
                    Brand = $"Brand-{i}",
                    Year = 2021,
                    Model = string.Empty
                });
            }

            IList<VehicleInfoExportModel> vehicleExportModelList = vehicleList.Select(src => new VehicleInfoExportModel()
            {
                Brand = src.Brand,
                Model = src.Model,
                Year = src.Year
            }).ToList(); 

            var xml = vehicleList.ToXml();
            var json = vehicleList.ToJson();

            Console.WriteLine(xml);
            Console.WriteLine(json);

            var fromXml = xml.FromXml<List<VehicleInfo>>();
            var fromJson = json.FromJson<List<VehicleInfo>>();


            foreach (var xmlItem in fromXml)
            {
                Console.WriteLine($"{xmlItem.Brand} {xmlItem.Year}");
            }
            foreach (var jsonItem in fromJson)
            {
                Console.WriteLine($"{jsonItem.Brand} {jsonItem.Year}");
            }

        }
    }
}
