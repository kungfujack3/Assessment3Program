using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDAL.Models;
using VehicleDAL.Services;

namespace VehicleSearchHUB
{
    public partial class VehicleSearch : Form
    {
        private readonly IVehicleService vehicleService;

        public VehicleSearch()
        {
            vehicleService = new VehicleService();
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
                            .Add($"{v.Manufacturer}, {v.Model} ");
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

    }
}
