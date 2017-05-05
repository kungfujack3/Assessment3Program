using MySql.Data.MySqlClient;
using VehicleDAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDAL.Services
{
    public class VehicleService : IVehicleService
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["PokemonConnection"]
            .ConnectionString.ToString();

        public List<Vehicle> RetrieveVehicle()
        {
            List<Vehicle> vehicle = new List<Vehicle>();

            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT vehicle.Manufacturer, vehicle.Model, vehicle.Make_Year, vehicle.Registration, vehicle.Fuel_Economy FROM vehicle", conn);

                conn.Open();

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        vehicle.Add(new Vehicle
                        (
                            dataReader.GetString("Manufacturer"),
                            dataReader.GetString("Model"),
                            dataReader.GetInt32("Make_Year"),
                            dataReader.GetString("Registration"),
                            dataReader.GetInt32("Fuel_Economy")
                        ));
                    }
                }

                conn.Close();
            }

            return vehicle;
        }
    }
}
