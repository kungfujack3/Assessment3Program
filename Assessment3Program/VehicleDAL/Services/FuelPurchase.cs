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
    public class FuelPurchase : IFuelPurchase
    {
        private string connectionString = ConfigurationManager
.ConnectionStrings["PokemonConnection"]
.ConnectionString.ToString();

        public List<Fuel> RetrieveFuel()
        {
            List<Fuel> fuel = new List<Fuel>();
            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT fuel.Name, fuel.Cost FROM fuel", conn);

                conn.Open();

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {

                        fuel.Add(new Fuel
                        (
                            dataReader.GetString("Name"),
                            dataReader.GetInt32("Cost")
                        ));
                    }
                }

                conn.Close();
            }

            return fuel;
        }
    }
}
