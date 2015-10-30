using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13_1
{
    public partial class IrvineHotel : Form
    {
        public IrvineHotel()
        {
            InitializeComponent();
        }
        internal string custName, custCredit, roomType, roomView;
        internal DateTime arrivalDate, departureDate;
        internal bool hasLuxRefrig = false, hasKitchen = false, hasWineBar = false;

        public void IrvineHotel_Load(object sender, EventArgs e)
        {
            // set default values
            cBView.SelectedItem = "Courtyard View";
            rBStand.Checked = true;
            // make sure depature date is 1 day later than arrival date
            dTDeparture.Value = dTArrival.Value.AddDays(1);
        }
        private void bSubmit_Click(object sender, EventArgs e)
        {
            // Validate tBName or tBCredit
            if (tBName.Text == "Enter your name")
            {
                MessageBox.Show("Please enter your name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tBName.Focus();
                return;
            }
            if (tBCredit.Text == "Paypal account or credit card")
            {
                MessageBox.Show("Please enter your paypal account or credit card", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tBCredit.Focus();
                return;
            }
            // construct info to pass Reservation Summary form
            custName = tBName.Text;
            custCredit = tBCredit.Text;
            if (rBStand.Checked) roomType = "Standard";
            else
                roomType = "Suite";
            roomView = cBView.Text;
            if (chBRef.Checked)
                hasLuxRefrig = true;
            if (chBKit.Checked)
                hasKitchen = true;
            if (chBWine.Checked)
                hasWineBar = true;
            arrivalDate = dTArrival.Value;
            departureDate = dTDeparture.Value;
            // pass information to ReservationSummary.cs via a constructor
            ReservationSummary resSummary = new ReservationSummary(this);
            resSummary.ShowDialog(); // use modal form
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
