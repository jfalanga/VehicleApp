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
            try
            {
                switch (CBxVType.Text)
                {
                    case "Sedan":
                        v = new Sedan();
                        break;
                    case "Truck":
                        v = new Truck();
                        break;
                    default:
                        textBox1.Text = "There needs to be, at least, something in Vehicle Type!";
                        return;
                }
                v.LicensePlate = TxtLicense.Text;
                v.VIN = TxtVIN.Text;
                vehicles.Add(v);
                LstInventory.DataSource = null;
                LstInventory.DataSource = vehicles;
                textBox1.Text = "Sucessfully added " + v.VehicleType;

            }
            catch (Exception prob)
            {
                textBox1.Text = prob.ToString();
            }
        }

        private void ListInventory_MDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle myVehicle = LstInventory.SelectedItem as Vehicle;
            TxtSummery.Text = myVehicle.GetDescription();
        }

        private void VehicleInventoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
