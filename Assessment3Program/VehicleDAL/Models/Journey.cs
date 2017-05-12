using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDAL.Models
{
    public class Journey
    {
        public Journey() { }
        public Journey(int distanceTravelled)
        {
            DistanceTravelled = distanceTravelled;
        }

        public int DistanceTravelled { get; set; }
    }
}
