using System;

namespace Inlämning3
{
    public partial class Form1 : Form
    {
        private Bank bank;
        public Form1()
        {
            InitializeComponent();
            Customer.SetupListView(listView1, true);
            bank = new Bank(this);
        }

        public void AddCustomer(Customer in_customer)
        {
            listView1.Items.Add(in_customer.CreateListViewItem(true));
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void AddCustomers(List<Customer> in_customers)
        {
            foreach (var customer in in_customers)
            {
                listView1.Items.Add(customer.CreateListViewItem(true));

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void RemoveCustomers()
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            try
            {
                customer.Money = Convert.ToInt32(textBoxMoney.Text);
                customer.PinCode = Convert.ToInt32(textBoxPinCode.Text);
                bank.AddCustomer(customer);
            }
            catch
            {
                MessageBox.Show("Money and Pin Code need to be numbers");
            }

        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedCustomer = listView1.SelectedItems[0].Tag as Customer;
                if (selectedCustomer != null && selectedCustomer.IsLocked())
                {
                    bank.Unlock(selectedCustomer);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedCustomer = listView1.SelectedItems[0].Tag as Customer;
                if (selectedCustomer != null)
                {
                    bank.Remove(selectedCustomer);
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "csv Files (*.csv)|*.csv";
            fileDialog.FilterIndex = 0;
            fileDialog.Title = "Select file to save to";
            fileDialog.DefaultExt = "csv";
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                bank.Save(fileDialog.FileName);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "csv Files (*.csv)|*.csv|All Files|*.*";
            fileDialog.FilterIndex = 0;
            fileDialog.Title = "Select file to save to";
            fileDialog.DefaultExt = "csv";
            fileDialog.Multiselect = false;
            fileDialog.CheckFileExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                bank.Load(fileDialog.FileName);
            }
        }
    }
}