using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void myProfileButton_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Parent = this;
            this.Hide();
            p.Show();
        }

        private void changePasswordbutton_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            this.Hide();
            c.Show(this);
        }

        private void FlightDetailsButton_Click(object sender, EventArgs e)
        {
            Flight_Details d = new Flight_Details();
            this.Hide();
            d.Show(this);
        }

        private void reserveSeatButton_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            this.Hide();
            r.Show();
        }

        private void addPlaneDetailsButton_Click(object sender, EventArgs e)
        {
            Plane_details planeDetails = new Plane_details();
            this.Hide();
            planeDetails.Show();
        }

        private void flightSchedualButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            duty_schedual d = new duty_schedual();
            this.Hide();
            d.Show(this);
        }
    }
}
