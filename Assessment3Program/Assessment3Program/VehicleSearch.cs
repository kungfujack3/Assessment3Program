using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDAL.Models;
using VehicleDAL.Services;
using Week12Program;

namespace VehicleSearchHUB
{
    public partial class VehicleSearch : Form
    {
        private readonly IVehicleService vehicleService;
        private readonly IFuelPurchase fuelPurchase;

        private string connectionString = ConfigurationManager
.ConnectionStrings["PokemonConnection"]
.ConnectionString.ToString();

        public VehicleSearch()
        {
            vehicleService = new VehicleService();
            fuelPurchase = new FuelPurchase();
            InitializeComponent();


            try
            {
                List<Vehicle> vehicle = new List<Vehicle>();
                vehicle = vehicleService.RetrieveVehicle();

                if (vehicle != null && vehicle.Count > 0)
                {
                    foreach (Vehicle v in vehicle)
                    {
                        cbSelectVehicle.Items
                            .Add($"{v.Model}");
                    }
                }
                else
                {
                    lblResults.Text = "No results found.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "An error has occured!";
                lblError.Text = ex.Message;
            }

            try
            {
                List<Fuel> fuel = new List<Fuel>();
                fuel = fuelPurchase.RetrieveFuel();

                if (fuel != null && fuel.Count > 0)
                {
                    foreach (Fuel v in fuel)
                    {
                        cbFuelUsed.Items
                            .Add($"{v.Name}");
                    }
                }
                else
                {
                    lblResults.Text = "No results found.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "An error has occured!";
                lblError.Text = ex.Message;
            }
        }

        private void cbSelectVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Vehicle> vehicle = new List<Vehicle>();
                vehicle = SelectVehicle();

                if (vehicle != null && vehicle.Count > 0)
                {
                    foreach (Vehicle v in vehicle)
                    {
                        txtManufacturer.Text = $"{v.Manufacturer}";
                        txtModel.Text = $"{v.Model}";
                        txtYear.Text = $"{v.Make_Year}";
                        txtRegistration.Text = $"{v.Registration}";
                        txtFuel.Text = $"{v.Fuel_Economy}";
                        txtDistance.Text = $"{v.DistanceTravelled}";
                        txtTotalFuelCost.Text = $"{v.TotalFuelCost}";
                    }
                }
                else
                {
                    lblResults.Text = "No results found.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "An error has occured!";
                lblError.Text = ex.Message;
            }
        }

        private void cbFuelUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Fuel> fuel = new List<Fuel>();
                fuel = SelectFuel();

                if (fuel != null && fuel.Count > 0)
                {
                    foreach (Fuel v in fuel)
                    {
                        txtFuelName.Text = $"{v.Name}";
                        txtFuelCost.Text = $"{v.Cost}";
                    }
                }
                else
                {
                    lblResults.Text = "No results found.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "An error has occured!";
                lblError.Text = ex.Message;
            }
        }

        public List<Vehicle> SelectVehicle()
        {
            List<Vehicle> vehicle = new List<Vehicle>();
            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT vehicle.Manufacturer, vehicle.Model, vehicle.Make_Year, vehicle.Registration, vehicle.Fuel_Economy, vehicle.DistanceTravelled, vehicle.TotalFuelCost FROM vehicle WHERE vehicle.Model = '" + cbSelectVehicle.Text + "'", conn);

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
                            dataReader.GetInt32("Fuel_Economy"),
                            dataReader.GetInt32("DistanceTravelled"),
                            dataReader.GetInt32("TotalFuelCost")
                        ));
                    }
                }

                conn.Close();
            }

            return vehicle;
        }

        public List<Fuel> SelectFuel()
        {
            List<Fuel> fuel = new List<Fuel>();
            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("SELECT fuel.Name, fuel.Cost FROM fuel WHERE fuel.Name = '" + cbFuelUsed.Text + "'", conn);

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

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            List<Vehicle> vehicle = new List<Vehicle>();
            MySqlDataReader dataReader;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand command =
                    new MySqlCommand("UPDATE vehicle SET vehicle.DistanceTravelled = " + ( (Convert.ToInt32(txtDistance.Text) + (Convert.ToInt32(txtKMTravelled.Text) ) ) ).ToString() + ", vehicle.TotalFuelCost = " + ( (Convert.ToInt32(txtTotalFuelCost.Text)) + ( ( (Convert.ToInt32(txtKMTravelled.Text)) / (Convert.ToInt32(txtFuel.Text)) ) * (Convert.ToInt32(txtFuelCost.Text)) ) ).ToString() + " WHERE vehicle.Model = '" + txtModel.Text + "'", conn);

            conn.Open();

            dataReader = command.ExecuteReader();

            conn.Close();
            }

            System.Windows.Forms.MessageBox.Show("Updated Vehicle Successfully.\n\n" +
                                                 "Manufacturer: " + txtManufacturer.Text +
                                                 "\nModel: " + txtModel.Text +
                                                 "\nMake Year: " + txtYear.Text +
                                                 "\nRegistration No: " + txtRegistration.Text +
                                                 "\nTotal Kilometres Travelled: " + ( ( Convert.ToInt32(txtDistance.Text) + (Convert.ToInt32(txtKMTravelled.Text) ) ) ).ToString() +
                                                 "\nTotal Services: " + ( (Convert.ToInt32(txtDistance.Text) + (Convert.ToInt32(txtKMTravelled.Text) ) ) / 100 ).ToString() +
                                                 "\nFuel Economy: " + txtFuel.Text + "L/100km" +
                                                 "\nTotal Fuel Cost: $" + ( (Convert.ToDouble(txtTotalFuelCost.Text)) + ( ( (Convert.ToDouble(txtKMTravelled.Text)) / (Convert.ToDouble(txtFuel.Text)) ) * (Convert.ToDouble(txtFuelCost.Text)) ) ) );
        }
    }
}
