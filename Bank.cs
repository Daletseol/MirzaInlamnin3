using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();
        private FormClient clientUI;
        private Form1 bankUI;
        private string csvHeader = "Bank and Bankomat Customers v1";

        public Bank(Form1 in_bankUI)
        {
            bankUI = in_bankUI;
            clientUI = new FormClient(this);
            clientUI.Show(bankUI);
            in_bankUI.SetDesktopLocation(100, 100);
            clientUI.SetDesktopLocation(in_bankUI.DesktopBounds.Right, in_bankUI.DesktopLocation.Y);
        }
        public void AddCustomer(Customer in_customer)
        {
            in_customer.AssignAccountNumber();
            customers.Add(in_customer);
            bankUI.AddCustomer(in_customer);
            clientUI.AddCustomer(in_customer);
        }

        public bool TryPin(Customer in_customer, int in_pin)
        {
            bool result = in_customer.TryPin(in_pin);
            if (!result && in_customer.IsLocked())
            {
                RefreshBankUI();
            }
            return result;
        }

        public bool Withdraw(Customer in_customer, int in_amount)
        {
            if (!in_customer.IsLocked() && in_customer.Money >= in_amount && in_amount > 0)
            {
                in_customer.Money -= in_amount;
                RefreshBankUI();
                return true;
            }
            return false;
        }
        public bool Insert(Customer in_customer, int in_amount)
        {
            if (!in_customer.IsLocked() && in_amount > 0)
            {
                in_customer.Money += in_amount;
                RefreshBankUI();
                return true;
            }
            return false;
        }

        public void Unlock(Customer in_customer)
        {
            in_customer.Unlock();
            RefreshBankUI();
        }

        public void Remove(Customer in_customer)
        {
            customers.Remove(in_customer);
            RefreshBankUI();
            RefreshClientUI();
        }
        public void Save(string in_fileName)
        {
            using (StreamWriter writer = new StreamWriter(in_fileName))
            {
                writer.WriteLine(csvHeader);
                foreach (var customer in customers)
                {
                    writer.WriteLine(customer.GetCSV());
                }
            }
        }
        public void Load(string in_fileName)
        {
            customers.Clear();
            using (StreamReader reader = new StreamReader(in_fileName))
            {
                string? line = reader.ReadLine();
                Customer.NextId = 0;
                if (line == null || line != csvHeader)
                {
                    MessageBox.Show("Invalid file header");
                    return;
                }
                line = reader.ReadLine();
                while (line != null)
                {
                    // Try just in case I read an empty or faulty line from the file.
                    try
                    {
                        Customer customer = new Customer(line);
                        customers.Add(customer);

                        line = reader.ReadLine();
                    }
                    catch
                    {
                        MessageBox.Show("Failed to read all the file");
                        break;
                    }
                }
            }
            RefreshBankUI();
            RefreshClientUI();
        }

        private void RefreshBankUI()
        {
            bankUI.RemoveCustomers();
            bankUI.AddCustomers(customers);
        }
        private void RefreshClientUI()
        {
            clientUI.RemoveCustomers();
            clientUI.AddCustomers(customers);
        }

    }
}
