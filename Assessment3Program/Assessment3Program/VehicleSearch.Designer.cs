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
            this.SuspendLayout();
            // 
            // cbSelectVehicle
            // 
            this.cbSelectVehicle.FormattingEnabled = true;
            this.cbSelectVehicle.Location = new System.Drawing.Point(12, 25);
            this.cbSelectVehicle.Name = "cbSelectVehicle";
            this.cbSelectVehicle.Size = new System.Drawing.Size(121, 21);
            this.cbSelectVehicle.TabIndex = 1;
            // 
            // lblSelectVehicle
            // 
            this.lblSelectVehicle.AutoSize = true;
            this.lblSelectVehicle.Location = new System.Drawing.Point(12, 9);
            this.lblSelectVehicle.Name = "lblSelectVehicle";
            this.lblSelectVehicle.Size = new System.Drawing.Size(84, 13);
            this.lblSelectVehicle.TabIndex = 2;
            this.lblSelectVehicle.Text = "Select a Vehicle";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(140, 32);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(268, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 115);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Error";
            // 
            // VehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 388);
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
    }
}

