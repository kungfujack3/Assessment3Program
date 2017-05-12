using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDAL.Models;
using VehicleDAL.Services;

namespace Week12Program
{
    public class JourneyDistance : IJourneyDistance
    {
        private string connectionString = ConfigurationManager
.ConnectionStrings["PokemonConnection"]
.ConnectionString.ToString();

        public List<Journey> RetrieveJourney()
        {
            List<Journey> journey = new List<Journey>();
            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT vehicle.DistanceTravelled FROM vehicle", conn);

                conn.Open();

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        journey.Add(new Journey
                        (
                            dataReader.GetInt32("DistanceTravelled")
                        ));
                    }
                }

                conn.Close();
            }

            return journey;
        }
    }
}
