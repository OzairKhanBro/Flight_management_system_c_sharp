namespace db_project
{
    partial class HomePage
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
            this.changePasswordbutton = new System.Windows.Forms.Button();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.flightSchedualButton = new System.Windows.Forms.Button();
            this.updatePlaneDetails = new System.Windows.Forms.Button();
            this.SearchPassengerProfileButton = new System.Windows.Forms.Button();
            this.addPlaneDetailsButton = new System.Windows.Forms.Button();
            this.reserveSeatButton = new System.Windows.Forms.Button();
            this.FlightDetailsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changePasswordbutton
            // 
            this.changePasswordbutton.Location = new System.Drawing.Point(151, 28);
            this.changePasswordbutton.Name = "changePasswordbutton";
            this.changePasswordbutton.Size = new System.Drawing.Size(103, 23);
            this.changePasswordbutton.TabIndex = 10;
            this.changePasswordbutton.Text = "&Change Password";
            this.changePasswordbutton.UseVisualStyleBackColor = true;
            this.changePasswordbutton.Click += new System.EventHandler(this.changePasswordbutton_Click);
            // 
            // myProfileButton
            // 
            this.myProfileButton.Location = new System.Drawing.Point(25, 28);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(75, 23);
            this.myProfileButton.TabIndex = 9;
            this.myProfileButton.Text = "&My profile";
            this.myProfileButton.UseVisualStyleBackColor = true;
            this.myProfileButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // flightSchedualButton
            // 
            this.flightSchedualButton.Location = new System.Drawing.Point(450, 222);
            this.flightSchedualButton.Name = "flightSchedualButton";
            this.flightSchedualButton.Size = new System.Drawing.Size(135, 23);
            this.flightSchedualButton.TabIndex = 3;
            this.flightSchedualButton.Text = "&flight schedual";
            this.flightSchedualButton.UseVisualStyleBackColor = true;
            this.flightSchedualButton.Click += new System.EventHandler(this.flightSchedualButton_Click);
            // 
            // updatePlaneDetails
            // 
            this.updatePlaneDetails.Location = new System.Drawing.Point(310, 222);
            this.updatePlaneDetails.Name = "updatePlaneDetails";
            this.updatePlaneDetails.Size = new System.Drawing.Size(120, 23);
            this.updatePlaneDetails.TabIndex = 4;
            this.updatePlaneDetails.Text = "&Update plane Details";
            this.updatePlaneDetails.UseVisualStyleBackColor = true;
            // 
            // SearchPassengerProfileButton
            // 
            this.SearchPassengerProfileButton.Location = new System.Drawing.Point(450, 161);
            this.SearchPassengerProfileButton.Name = "SearchPassengerProfileButton";
            this.SearchPassengerProfileButton.Size = new System.Drawing.Size(135, 23);
            this.SearchPassengerProfileButton.TabIndex = 5;
            this.SearchPassengerProfileButton.Text = "&Search Passenger Profile";
            this.SearchPassengerProfileButton.UseVisualStyleBackColor = true;
            // 
            // addPlaneDetailsButton
            // 
            this.addPlaneDetailsButton.Location = new System.Drawing.Point(151, 222);
            this.addPlaneDetailsButton.Name = "addPlaneDetailsButton";
            this.addPlaneDetailsButton.Size = new System.Drawing.Size(129, 23);
            this.addPlaneDetailsButton.TabIndex = 6;
            this.addPlaneDetailsButton.Text = "&Add Plane Details";
            this.addPlaneDetailsButton.UseVisualStyleBackColor = true;
            this.addPlaneDetailsButton.Click += new System.EventHandler(this.addPlaneDetailsButton_Click);
            // 
            // reserveSeatButton
            // 
            this.reserveSeatButton.Location = new System.Drawing.Point(310, 161);
            this.reserveSeatButton.Name = "reserveSeatButton";
            this.reserveSeatButton.Size = new System.Drawing.Size(120, 23);
            this.reserveSeatButton.TabIndex = 7;
            this.reserveSeatButton.Text = "&Reserve seat";
            this.reserveSeatButton.UseVisualStyleBackColor = true;
            this.reserveSeatButton.Click += new System.EventHandler(this.reserveSeatButton_Click);
            // 
            // FlightDetailsButton
            // 
            this.FlightDetailsButton.Location = new System.Drawing.Point(151, 161);
            this.FlightDetailsButton.Name = "FlightDetailsButton";
            this.FlightDetailsButton.Size = new System.Drawing.Size(129, 23);
            this.FlightDetailsButton.TabIndex = 8;
            this.FlightDetailsButton.Text = "&Update Flight Details";
            this.FlightDetailsButton.UseVisualStyleBackColor = true;
            this.FlightDetailsButton.Click += new System.EventHandler(this.FlightDetailsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Operators duty schedual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changePasswordbutton);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.flightSchedualButton);
            this.Controls.Add(this.updatePlaneDetails);
            this.Controls.Add(this.SearchPassengerProfileButton);
            this.Controls.Add(this.addPlaneDetailsButton);
            this.Controls.Add(this.reserveSeatButton);
            this.Controls.Add(this.FlightDetailsButton);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePasswordbutton;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Button flightSchedualButton;
        private System.Windows.Forms.Button updatePlaneDetails;
        private System.Windows.Forms.Button SearchPassengerProfileButton;
        private System.Windows.Forms.Button addPlaneDetailsButton;
        private System.Windows.Forms.Button reserveSeatButton;
        private System.Windows.Forms.Button FlightDetailsButton;
        private System.Windows.Forms.Button button1;
    }
}