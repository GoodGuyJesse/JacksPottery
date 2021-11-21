using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_2
{
    public partial class Form1 : Form
    {
        private bool signBeam;
        private bool signCylinder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlCylinder.Hide();
            rbBeam.Checked = true;
            signBeam = true;
            signCylinder = false;
        }

        private void rbBeam_CheckedChanged(object sender, EventArgs e)
        {
            signBeam = true;
            signCylinder = false;
            pnlBeam.Show();
            pnlCylinder.Hide();
        }

        private void rbCylinder_CheckedChanged(object sender, EventArgs e)
        {
            signBeam = false;
            signCylinder = true;
            pnlCylinder.Show();
            pnlBeam.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Customer objCustomer = null;
                Beam objBeam = null;
                Cylinder objCylinder = null;

                //Determine if all text boxes of the customer are filled
                bool filledTextBoxes = true;
                foreach (Control ctrl in pnlCustomer.Controls)
                {
                    if (ctrl is TextBox && ctrl.Text == "" && ctrl.Name != "tbMiddleName")
                    {
                        filledTextBoxes = false;
                        break;
                    }
                }

                //if all customer text boxes are filled
                if (filledTextBoxes)
                {
                    //Create Customer class instance
                    objCustomer = new Customer(tbFirstName.Text.Trim(), tbMiddleName.Text.Trim(), tbLastName.Text.Trim(),
                        tbLastName.Text.Trim(), tbCity.Text.Trim(), tbPostalCode.Text.TrimStart().TrimEnd());
                }
                else
                    throw new ArgumentException("Not all customer text boxes are filled");

                //In case the beam shaped flower box is checked
                if (signBeam)
                {
                    foreach (Control ctrl in pnlBeam.Controls)
                    {
                        if (ctrl is TextBox && ctrl.Text == "")
                        {
                            filledTextBoxes = false;
                            break;
                        }
                    }

                    if(filledTextBoxes)
                    {
                        int length, width, height;

                        if(int.TryParse(tbLength.Text.Trim(), out length) && int.TryParse(tbWidth.Text.Trim(), out width) &&
                            int.TryParse(tbHeightBeam.Text.Trim(), out height))
                        {
                            objBeam = new Beam(length, width, height);
                            tbOrder.Text = objCustomer.Print() + objBeam.Print();
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Provide valid sizes for the beam formed flower box");
                    }
                }
                
                //in case the cylinder shaped flower box is checked
                else if (signCylinder)
                {
                    foreach (Control ctrl in pnlCylinder.Controls)
                    {
                        if (ctrl is TextBox && ctrl.Text == "")
                        {
                            filledTextBoxes = false;
                            break;
                        }
                    }

                    if(filledTextBoxes)
                    {
                        int diameter, height;
                        if (int.TryParse(tbDiameter.Text.Trim(), out diameter) && int.TryParse(tbHeightCilinder.Text.Trim(), out height))
                        {
                            objCylinder = new Cylinder(diameter, height);
                            tbOrder.Text = objCustomer.Print() + objCylinder.Print;
                        }
                        else
                            throw new ArgumentException("Provide valid sizes for the cylinder formed flower box");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //******** Tets class Beam ***********
            //Beam constructor and Print method test
            Beam objBeam = new Beam(80, 40, 30);
            MessageBox.Show(objBeam.Print());
            
            //in case of a cube 
            Beam objCube = new Beam(80, 80, 80);
            MessageBox.Show(objCube.Print());

            //Properties test
            if (objBeam.Length == 80 && objBeam.Width == 40 && objBeam.Heigth == 30)
                MessageBox.Show("properties of class Beam are oke");
            else
                MessageBox.Show("Error in properties of class beam");

            //Volume test
            if (objBeam.Volume == (80 * 40 * 30))
                MessageBox.Show("The volume is calculated correctly");
            else
                MessageBox.Show("The volume is NOT calculated correctly");


            //************ Test class Customer ***********
            Customer objCustomer = new Customer("Piet", "van de", "Hoek",
                "Dorpstraat 16", "Losser", "7587 KL");

            //Now that we have used auto-implemented properties for the class customer
            //we can also instantiate an object of the class customer in the following way
            //using the default constructor
            Customer objCustomer2 = new Customer
            {
                FirstName = "Piet",
                MiddleName = "van de",
                LastName = "Hoek",
                Address = "Dorpstraat 16",
                City = "Losser",
                PostalCode = "7587 KL"
            };

            //Properties test
            if (objCustomer.FirstName == "Piet" && objCustomer.MiddleName == "van de" && objCustomer.LastName == "Hoek" &&
                objCustomer.Address == "Dorpstraat 16" && objCustomer.City == "Losser" && objCustomer.PostalCode == "7587 KL")
                MessageBox.Show("properties of the class Customer are ok");
            else
                MessageBox.Show("properties of the class Customer are NOT ok");

            //Method test
            MessageBox.Show(objCustomer.Print());
        }
    }
}
