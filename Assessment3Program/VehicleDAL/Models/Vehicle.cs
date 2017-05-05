using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDAL.Models
{
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string manufacturer, string model, int make_year, string registration, int fuel_economy)
        {
            Manufacturer = manufacturer;
            Model = model;
            Make_Year = make_year;
            Registration = registration;
            Fuel_Economy = fuel_economy;
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Make_Year { get; set; }
        public string Registration { get; set; }
        public int Fuel_Economy { get; set; }
    }
}
