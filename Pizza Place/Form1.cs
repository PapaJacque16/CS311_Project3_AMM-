using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace Pizza_Place
{
    public partial class PizzaPlace : Form
    {
        

        public PizzaPlace()
        {
            InitializeComponent();

        }

        private void PizzaPlace_Load(object sender, EventArgs e)
        {
            
        }

        private void picPizza_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            
            //Add Summarize Method to calculate order
            Summarize();

     
        }//end btnCalculateOrder_Click

        private void Summarize()

        {
            //Add Crust style to the Order Summary when individually selected
            if (rdoThinCrust.Checked)
                rtfOrderSummary.SelectedText += "You ordered a Thin Crust\n";
            if (rdoThickCrust.Checked)
                rtfOrderSummary.SelectedText += "You ordered a Thick Crust\n";
            if (rdoRegularCrust.Checked)
                rtfOrderSummary.SelectedText += "Your ordered a Regular Crust\n";

            //Add toppings to the Order Summary when checked
            if (ckbPepperoni.Checked)
                rtfOrderSummary.SelectedText += "Pepperoni\n";
            if (ckbSausage.Checked)
                rtfOrderSummary.SelectedText += "Canadian Bacon\n";
            if (ckbSpicyItalianSausage.Checked)
                rtfOrderSummary.SelectedText += "Spicy Italian Sausage\n";
            if (ckbOnion.Checked)
                rtfOrderSummary.SelectedText += "Onion\n";
            if (ckbGreenPepper.Checked)
                rtfOrderSummary.SelectedText += "Green Pepper\n";
            if (ckbBlackOlive.Checked)
                rtfOrderSummary.SelectedText += "Black Olive\n";
            if (ckbBoxGreenOlive.Checked)
                rtfOrderSummary.SelectedText += "Green Olive\n";
            if (ckbBananaPeppers.Checked)
                rtfOrderSummary.SelectedText += "Banana Peppers\n";
            if (ckbJalepeno.Checked)
                rtfOrderSummary.SelectedText += "Jalepeno\n";
            if (ckbExtraCheese.Checked)
                rtfOrderSummary.SelectedText += "Extra Cheese\n";
            if (ckbMushroom.Checked)
                rtfOrderSummary.SelectedText += "Mushroom\n";

            double subTotal = 0.00, tax = 0.08, totalAmount = 0.00;
            totalAmount = subTotal * tax;

            double Small = 2.00;
            double Medium = 5.00;
            double Large = 10.00;
            double Xlarge = 15.00;
            double Ginormous = 20.00;

            //Pizza Size
         
            if (cboPizzaSize.SelectedText == "Small")
            {
                subTotal = Small;
                cboPizzaSize.Items.Add(txtSubTotal.Text);
            }

            if (cboPizzaSize.SelectedText == "Medium")
            {
                subTotal = Medium;
                cboPizzaSize.Items.Add(txtSubTotal.Text);
            }

            if (cboPizzaSize.SelectedText == "Large")
            {
                subTotal = Large;
                cboPizzaSize.Items.Add(txtSubTotal.Text);
            }

            if (cboPizzaSize.SelectedText == "X-Large")
            {
                subTotal = Xlarge;
                cboPizzaSize.Items.Add(txtSubTotal.Text);
            }
            if (cboPizzaSize.SelectedText == "Ginormous")
            {
                subTotal = Ginormous;
                cboPizzaSize.Items.Add(txtSubTotal.Text);
            }
            

        }//end Summarize 

        private void cboPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            String data = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem);
            rtfOrderSummary.Text = data + "\n";

            
        }//end cboPizaSlice_SelectedIndexChanged

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            txtSubTotal.Clear();
            txtTax.Clear();
            txtTotalAmount.Clear();
            rtfOrderSummary.Clear();
        }
    }//end class

}//end namespace