namespace VehicleSearchHUB
{
    partial class VehicleSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSelectVehicle = new System.Windows.Forms.ComboBox();
            this.lblSelectVehicle = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtKMTravelled = new System.Windows.Forms.TextBox();
            this.lblKMTravelled = new System.Windows.Forms.Label();
            this.lblFuelUsed = new System.Windows.Forms.Label();
            this.cbFuelUsed = new System.Windows.Forms.ComboBox();
            this.txtFuelName = new System.Windows.Forms.TextBox();
            this.txtFuelCost = new System.Windows.Forms.TextBox();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtTotalFuelCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbSelectVehicle
            // 
            this.cbSelectVehicle.FormattingEnabled = true;
            this.cbSelectVehicle.Location = new System.Drawing.Point(22, 33);
            this.cbSelectVehicle.Name = "cbSelectVehicle";
            this.cbSelectVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbSelectVehicle.TabIndex = 1;
            this.cbSelectVehicle.SelectedIndexChanged += new System.EventHandler(this.cbSelectVehicle_SelectedIndexChanged);
            // 
            // lblSelectVehicle
            // 
            this.lblSelectVehicle.AutoSize = true;
            this.lblSelectVehicle.Location = new System.Drawing.Point(22, 17);
            this.lblSelectVehicle.Name = "lblSelectVehicle";
            this.lblSelectVehicle.Size = new System.Drawing.Size(84, 13);
            this.lblSelectVehicle.TabIndex = 2;
            this.lblSelectVehicle.Text = "Select a Vehicle";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(150, 40);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(191, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(285, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(22, 71);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(152, 20);
            this.txtManufacturer.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(22, 97);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(152, 20);
            this.txtModel.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(22, 123);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(152, 20);
            this.txtYear.TabIndex = 8;
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(22, 149);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.ReadOnly = true;
            this.txtRegistration.Size = new System.Drawing.Size(152, 20);
            this.txtRegistration.TabIndex = 9;
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(84, 175);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.ReadOnly = true;
            this.txtFuel.Size = new System.Drawing.Size(90, 20);
            this.txtFuel.TabIndex = 10;
            // 
            // txtKMTravelled
            // 
            this.txtKMTravelled.Location = new System.Drawing.Point(288, 71);
            this.txtKMTravelled.Name = "txtKMTravelled";
            this.txtKMTravelled.Size = new System.Drawing.Size(123, 20);
            this.txtKMTravelled.TabIndex = 11;
            // 
            // lblKMTravelled
            // 
            this.lblKMTravelled.AutoSize = true;
            this.lblKMTravelled.Location = new System.Drawing.Point(213, 74);
            this.lblKMTravelled.Name = "lblKMTravelled";
            this.lblKMTravelled.Size = new System.Drawing.Size(70, 13);
            this.lblKMTravelled.TabIndex = 12;
            this.lblKMTravelled.Text = "KM Travelled";
            // 
            // lblFuelUsed
            // 
            this.lblFuelUsed.AutoSize = true;
            this.lblFuelUsed.Location = new System.Drawing.Point(228, 111);
            this.lblFuelUsed.Name = "lblFuelUsed";
            this.lblFuelUsed.Size = new System.Drawing.Size(55, 13);
            this.lblFuelUsed.TabIndex = 13;
            this.lblFuelUsed.Text = "Fuel Used";
            // 
            // cbFuelUsed
            // 
            this.cbFuelUsed.FormattingEnabled = true;
            this.cbFuelUsed.Location = new System.Drawing.Point(290, 106);
            this.cbFuelUsed.Name = "cbFuelUsed";
            this.cbFuelUsed.Size = new System.Drawing.Size(121, 21);
            this.cbFuelUsed.TabIndex = 14;
            this.cbFuelUsed.SelectedIndexChanged += new System.EventHandler(this.cbFuelUsed_SelectedIndexChanged);
            // 
            // txtFuelName
            // 
            this.txtFuelName.Location = new System.Drawing.Point(259, 133);
            this.txtFuelName.Name = "txtFuelName";
            this.txtFuelName.ReadOnly = true;
            this.txtFuelName.Size = new System.Drawing.Size(152, 20);
            this.txtFuelName.TabIndex = 15;
            // 
            // txtFuelCost
            // 
            this.txtFuelCost.Location = new System.Drawing.Point(288, 159);
            this.txtFuelCost.Name = "txtFuelCost";
            this.txtFuelCost.ReadOnly = true;
            this.txtFuelCost.Size = new System.Drawing.Size(123, 20);
            this.txtFuelCost.TabIndex = 16;
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(115, 230);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(199, 62);
            this.btnUpdateVehicle.TabIndex = 17;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "($/L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "(L/100km)";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(22, 204);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.ReadOnly = true;
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 20;
            this.txtDistance.Visible = false;
            // 
            // txtTotalFuelCost
            // 
            this.txtTotalFuelCost.Location = new System.Drawing.Point(22, 230);
            this.txtTotalFuelCost.Name = "txtTotalFuelCost";
            this.txtTotalFuelCost.ReadOnly = true;
            this.txtTotalFuelCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFuelCost.TabIndex = 21;
            this.txtTotalFuelCost.Visible = false;
            // 
            // VehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 318);
            this.Controls.Add(this.txtTotalFuelCost);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.txtFuelCost);
            this.Controls.Add(this.txtFuelName);
            this.Controls.Add(this.cbFuelUsed);
            this.Controls.Add(this.lblFuelUsed);
            this.Controls.Add(this.lblKMTravelled);
            this.Controls.Add(this.txtKMTravelled);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblSelectVehicle);
            this.Controls.Add(this.cbSelectVehicle);
            this.Name = "VehicleSearch";
            this.Text = "Vehicle Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectVehicle;
        private System.Windows.Forms.Label lblSelectVehicle;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtKMTravelled;
        private System.Windows.Forms.Label lblKMTravelled;
        private System.Windows.Forms.Label lblFuelUsed;
        private System.Windows.Forms.ComboBox cbFuelUsed;
        private System.Windows.Forms.TextBox txtFuelName;
        private System.Windows.Forms.TextBox txtFuelCost;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtTotalFuelCost;
    }
}

