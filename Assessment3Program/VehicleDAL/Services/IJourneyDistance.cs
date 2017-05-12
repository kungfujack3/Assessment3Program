using VehicleDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDAL.Services
{
    public interface IJourneyDistance
    {
        List<Journey> RetrieveJourney();
    }
}
