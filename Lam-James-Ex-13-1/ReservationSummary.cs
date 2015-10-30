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
    public partial class ReservationSummary : Form
    {
        private IrvineHotel mainF = null;
        public ReservationSummary(IrvineHotel mForm)
        {
            mainF = mForm as IrvineHotel;
            InitializeComponent();
        }

        private double calcTotalCharge()
        {
            TimeSpan days;
            double total = 150;
            if (this.mainF.roomType == "Suite")
            {
                total += 100; //add 100 for suite
            }
            if (this.mainF.roomView == "Ocean View")
            {
                total += 60;
            }
            else if (this.mainF.roomView == "Mountain View")
            {
                total += 30;
            }
            if (this.mainF.hasLuxRefrig)
                total += 20;
            if (this.mainF.hasKitchen)
                total += 60;
            if (this.mainF.hasWineBar)
                total += 30;
            days = this.mainF.departureDate - this.mainF.arrivalDate;
            total = total * days.TotalDays;

            return total;
        }

        // we calculate total charge as we load ReservationSummary form
        private void ReservationSummary_Load(object sender, EventArgs e)
        {
            tBCustName.Text = this.mainF.custName;
            tBCustCredit.Text = this.mainF.custCredit;
            tBCustArrival.Text = this.mainF.arrivalDate.ToString("d");
            tBCustDeparture.Text = this.mainF.departureDate.ToString("d");
            tBType.Text = this.mainF.roomType;
            tBView.Text = this.mainF.roomView;
            if (this.mainF.hasLuxRefrig)
                chBRefrig.Checked = true;
            if (this.mainF.hasKitchen)
                chBKitch.Checked = true;
            if (this.mainF.hasWineBar)
                chBWineB.Checked = true;
            tBTotal.Text = calcTotalCharge().ToString("c");
        }

        private void bReserve_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            // to add close to write reservation information to an xml file
            MessageBox.Show("Will write this to handle xml data interation in the next part");
        }
    }
}
