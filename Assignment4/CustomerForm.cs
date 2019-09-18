using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            quantityNumericUpDown.Minimum = 1;
        }
        List<string> names = new List<string> {};
        List<int> phones = new List<int> {};
        List<string> addresses = new List<string> {};
        List<string> orders = new List<string> {};
        List<int> quantities = new List<int> {};

        private void ShowData()
        {
            MoneyReceipt.Clear();
            for (int i = 0; i < names.Count(); i++)
            {
                MoneyReceipt.Text += "Name: " + names[i] + "\nContract No: " + phones[i] + "\nAddress: " +
                            addresses[i] + "\nOrder: " + orders[i] + "\nQuantity: " + quantities[i] + "\n \n";
            }
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string messege = "";
            if (!phones.Contains(Convert.ToInt32(txtContactInput.Text)))
            {
                if (!String.IsNullOrEmpty(comboBoxItem.Text))
                {
                    if (quantityNumericUpDown != null)
                    {
                        MoneyReceipt.Clear();
                        names.Add(txtNameInput.Text);
                        addresses.Add(txtAddressInput.Text);
                        phones.Add(Convert.ToInt32(txtContactInput.Text));
                        orders.Add(comboBoxItem.Text);
                        quantities.Add(Convert.ToInt32(quantityNumericUpDown.Value));
                        messege = "Order Information: " + "\n Name: " + txtNameInput + "\n Contract No: " + Convert.ToInt32(txtContactInput.Text) + "\n Address: " +
                            txtAddressInput.Text + "\n Order: " + comboBoxItem.Text + "\n Quantity: " + Convert.ToInt32(quantityNumericUpDown.Value) + "\n \n";
                        MoneyReceipt.AppendText(messege);
                    }
                    else
                    {
                        MessageBox.Show("Please enter quantity");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Plase select order");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This Contract no already exist!");
                return;
            }
        }
    }
}
