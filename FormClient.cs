using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inlämning3
{
    public partial class FormClient : Form
    {
        private Bank bank;
        private Customer? selectedCustomer;

        public FormClient(Bank in_bank)
        {
            InitializeComponent();
            Customer.SetupListView(listView1, false);
            bank = in_bank;
            DisableAll();
        }
        public void AddCustomer(Customer in_customer)
        {
            listView1.Items.Add(in_customer.CreateListViewItem(false));
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void AddCustomers(List<Customer> in_customers)
        {
            foreach (var customer in in_customers)
            {
                listView1.Items.Add(customer.CreateListViewItem(false));

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void RemoveCustomers()
        {
            listView1.Items.Clear();
            DisableAll();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                selectedCustomer = listView1.SelectedItems[0].Tag as Customer;
                if (selectedCustomer != null && !selectedCustomer.IsLocked())
                {
                    listView1.Enabled = false;
                    buttonPin.Enabled = true;
                    buttonCancel.Enabled = true;
                    textBoxPin.Enabled = true;
                    textBoxInfo.Text = "Need PIN Code";
                }
                else if (selectedCustomer != null)
                {
                    selectedCustomer = null;
                    textBoxInfo.Text = "Go to the bank to unlock account";
                }
            }
        }

        private void DisableAll()
        {
            listView1.Enabled = true;
            buttonPin.Enabled = false;
            buttonCancel.Enabled = false;
            buttonWithdraw.Enabled = false;
            buttonInsert.Enabled = false;
            buttonMoney.Enabled = false;
            textBoxPin.Enabled = false;
            textBoxAmount.Enabled = false;
            textBoxInfo.Text = "Select customer";
            selectedCustomer = null;
            textBoxAmount.Text = String.Empty;
            textBoxPin.Text = String.Empty;
        }

        private void buttonPin_Click(object sender, EventArgs e)
        {
            try
            {
                var pin = Convert.ToInt32(textBoxPin.Text);
                if (bank.TryPin(selectedCustomer, pin))
                {
                    buttonPin.Enabled = false;
                    buttonWithdraw.Enabled = true;
                    buttonInsert.Enabled = true;
                    buttonMoney.Enabled = true;
                    textBoxPin.Enabled = false;
                    textBoxAmount.Enabled = true;
                    textBoxInfo.Text = "PIN OK";
                }
                else if (selectedCustomer.IsLocked())
                {
                    textBoxPin.Enabled = false;
                    buttonPin.Enabled = false;
                    textBoxInfo.Text = "Too many tries, go to the bank to unlock account.";
                }
                else
                {
                    textBoxInfo.Text = "Wrong code, try again";
                }
            }
            catch
            {
                MessageBox.Show("Insert numbers");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DisableAll();
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "You have " + selectedCustomer.Money + " kr in your account.";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var amount = Convert.ToInt32(textBoxAmount.Text);
                if (bank.Insert(selectedCustomer, amount))
                {
                    textBoxInfo.Text = "Inserted " + amount + " kr in your account.";
                }
                else
                {
                    textBoxInfo.Text = "Invalid amount " + amount;
                }
            }
            catch
            {
                MessageBox.Show("Insert numbers");
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                var amount = Convert.ToInt32(textBoxAmount.Text);
                if (bank.Withdraw(selectedCustomer, amount))
                {
                    int[] moneyTypes = { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
                    int highestCoin = 10;
                    textBoxInfo.Clear();
                    for (int i = 0; i < moneyTypes.Count(); ++i)
                    {
                        int value = moneyTypes[i];
                        if (amount >= value)
                        {
                            int bills = amount / value;
                            amount -= bills * value;
                            if (value > highestCoin)
                            {
                                textBoxInfo.Text += "You received " + bills + " bills of " + value + " kr" + Environment.NewLine;
                            }
                            else
                            {
                                textBoxInfo.Text += "You received " + bills + " coins of " + value + " kr" + Environment.NewLine;
                            }
                        }
                    }
                }
                else
                {
                    textBoxInfo.Text = "Insufficient funds to withdraw " + amount;
                }
            }
            catch
            {
                MessageBox.Show("Insert numbers");
            }
        }
    }
}
