using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Vehicle v;
            switch (CBxVType.Text)
            {
                case "Sedan":
                    v = new Sedan();
                    break;
                default:
                    return;
            }
            v.LicensePlate = TxtLicense.Text;
            vehicles.Add(v);
            textBox1.Text="Succ"
        }
    }
}
