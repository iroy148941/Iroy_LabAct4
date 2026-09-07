using System;
using System.Windows.Forms;

namespace Iroy_LabAct4
{
    public partial class Form1 : Form
    {
        decimal foodPrice, drinkPrice;
        decimal foodTotal, drinkTotal;
        decimal subTotal, discount, charges;
        decimal total, payment, change;

        int foodQty, drinkQty;

        public Form1()
        {
            InitializeComponent();

            // Food items
            cmbFood.Items.Add("Burger");
            cmbFood.Items.Add("Chicken Sandwich");
            cmbFood.Items.Add("Spaghetti");
            cmbFood.Items.Add("French Fries");

            // Drink items
            cmbDrink.Items.Add("Soft Drink");
            cmbDrink.Items.Add("Iced Tea");
            cmbDrink.Items.Add("Coffee");
            cmbDrink.Items.Add("Bottled Water");

            // Quantity settings
            nudFoodQty.Minimum = 1;
            nudFoodQty.Maximum = 100;
            nudFoodQty.Value = 1;

            nudDrinkQty.Minimum = 1;
            nudDrinkQty.Maximum = 100;
            nudDrinkQty.Value = 1;

            rdoDineIn.Checked = true;

            richTextBox1.ReadOnly = true;
            richTextBox1.Font = new System.Drawing.Font("Consolas", 10);

            ClearTotals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFood.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a food item.");
                return;
            }

            if (cmbDrink.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a drink item.");
                return;
            }

            foodQty = (int)nudFoodQty.Value;
            drinkQty = (int)nudDrinkQty.Value;

            // Get food price
            switch (cmbFood.Text)
            {
                case "Burger":
                    foodPrice = 85;
                    break;
                case "Chicken Sandwich":
                    foodPrice = 75;
                    break;
                case "Spaghetti":
                    foodPrice = 95;
                    break;
                case "French Fries":
                    foodPrice = 50;
                    break;
            }

            // Get drink price
            switch (cmbDrink.Text)
            {
                case "Soft Drink":
                    drinkPrice = 35;
                    break;
                case "Iced Tea":
                    drinkPrice = 40;
                    break;
                case "Coffee":
                    drinkPrice = 45;
                    break;
                case "Bottled Water":
                    drinkPrice = 25;
                    break;
            }

            foodTotal = foodPrice * foodQty;
            drinkTotal = drinkPrice * drinkQty;

            subTotal = foodTotal + drinkTotal;

            // Regular discount
            discount = 0;

            if (subTotal >= 500)
            {
                discount = subTotal * 0.10m;
            }

            // Senior citizen discount
            if (chkSeniorCitizen.Checked)
            {
                discount += (subTotal - discount) * 0.20m;
            }

            // Order type charges
            charges = 0;

            if (rdoTakeout.Checked)
            {
                charges = 20;
            }
            else if (rdoDelivery.Checked)
            {
                if (subTotal < 1000)
                    charges = 50;
            }

            total = subTotal - discount + charges;

            // Payment
            if (!decimal.TryParse(txtPayment.Text, out payment))
            {
                MessageBox.Show("Please enter a valid payment.");
                return;
            }

            if (payment < total)
            {
                MessageBox.Show("Insufficient payment.");
                lblChange.Text = "Change: ₱0.00";
                richTextBox1.Clear();
                return;
            }

            change = payment - total;

            // Display totals
            lblFoodTotal.Text = "Food Total: ₱" + foodTotal.ToString("N2");
            lblDrinkTotal.Text = "Drink Total: ₱" + drinkTotal.ToString("N2");
            lblSubTotal.Text = "Subtotal: ₱" + subTotal.ToString("N2");
            lblDiscount.Text = "Discount: ₱" + discount.ToString("N2");
            lblCharges.Text = "Charges: ₱" + charges.ToString("N2");
            lblTotal.Text = "TOTAL: ₱" + total.ToString("N2");
            lblChange.Text = "Change: ₱" + change.ToString("N2");

            Receipt();
        }

        private void Receipt()
        {
            string orderType;

            if (rdoDineIn.Checked)
                orderType = "Dine-in";
            else if (rdoTakeout.Checked)
                orderType = "Takeout";
            else
                orderType = "Delivery";

            richTextBox1.Clear();

            richTextBox1.AppendText("================================\n");
            richTextBox1.AppendText("             ABC CAFE\n");
            richTextBox1.AppendText("================================\n\n");

            richTextBox1.AppendText("Order Type: " + orderType + "\n");

            if (chkSeniorCitizen.Checked)
                richTextBox1.AppendText("Senior Citizen: Yes\n");
            else
                richTextBox1.AppendText("Senior Citizen: No\n");

            richTextBox1.AppendText("--------------------------------\n");

            richTextBox1.AppendText(
                cmbFood.Text + " " +
                foodQty + " x ₱" +
                foodPrice.ToString("N2") +
                " = ₱" +
                foodTotal.ToString("N2") + "\n"
            );

            richTextBox1.AppendText(
                cmbDrink.Text + " " +
                drinkQty + " x ₱" +
                drinkPrice.ToString("N2") +
                " = ₱" +
                drinkTotal.ToString("N2") + "\n"
            );

            richTextBox1.AppendText("--------------------------------\n");

            richTextBox1.AppendText(
                "Subtotal: ₱" + subTotal.ToString("N2") + "\n"
            );

            richTextBox1.AppendText(
                "Discount: ₱" + discount.ToString("N2") + "\n"
            );

            richTextBox1.AppendText(
                "Charges: ₱" + charges.ToString("N2") + "\n"
            );

            richTextBox1.AppendText("--------------------------------\n");

            richTextBox1.AppendText(
                "TOTAL: ₱" + total.ToString("N2") + "\n"
            );

            richTextBox1.AppendText(
                "Payment: ₱" + payment.ToString("N2") + "\n"
            );

            richTextBox1.AppendText(
                "Change: ₱" + change.ToString("N2") + "\n"
            );

            richTextBox1.AppendText("================================\n");
            richTextBox1.AppendText("           THANK YOU!\n");
            richTextBox1.AppendText("================================");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbFood.SelectedIndex = -1;
            cmbDrink.SelectedIndex = -1;

            nudFoodQty.Value = 1;
            nudDrinkQty.Value = 1;

            txtPayment.Clear();

            rdoDineIn.Checked = true;
            chkSeniorCitizen.Checked = false;

            ClearTotals();
            richTextBox1.Clear();
        }

        private void ClearTotals()
        {
            lblFoodTotal.Text = "Food Total: ₱0.00";
            lblDrinkTotal.Text = "Drink Total: ₱0.00";
            lblSubTotal.Text = "Subtotal: ₱0.00";
            lblDiscount.Text = "Discount: ₱0.00";
            lblCharges.Text = "Charges: ₱0.00";
            lblTotal.Text = "TOTAL: ₱0.00";
            lblChange.Text = "Change: ₱0.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Unused events generated by the Designer

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void rdoDineIn_CheckedChanged(object sender, EventArgs e) { }
        private void rdoTakeout_CheckedChanged(object sender, EventArgs e) { }
        private void rdoDelivery_CheckedChanged(object sender, EventArgs e) { }
        private void chkSeniorCitizen_CheckedChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void nudFoodQty_ValueChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void cmbDrink_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void nudDrinkQty_ValueChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void lblFoodTotal_Click(object sender, EventArgs e) { }
        private void lblDrinkTotal_Click(object sender, EventArgs e) { }
        private void lblSubTotal_Click(object sender, EventArgs e) { }
        private void lblDiscount_Click(object sender, EventArgs e) { }
        private void lblCharges_Click(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void lblChange_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void txtPayment_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}