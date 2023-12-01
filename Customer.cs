using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inlämning3
{
    public class Customer
    {
        static public int NextId { get; set; } = 100001;
        public int AccountId { get; private set; } = 0;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Money { get; set; } = 0;
        public int PinCode { get; set; } = 0;
        public int FailedPinTries { get; private set; } = 0;
        public Customer()
        {
            AccountId = -1;
        }
        public Customer(string in_csv)
        {
            string[] strings = in_csv.Split(",");

            // I know the order the variables are stored in the file,
            // so I simply need to retrieve them in that order.
            AccountId = Convert.ToInt32(strings[0]);
            FirstName = strings[1];
            LastName = strings[2];
            Money = Convert.ToInt32(strings[3]);
            PinCode = Convert.ToInt32(strings[4]);
            FailedPinTries = Convert.ToInt32(strings[5]);

            if (AccountId >= NextId)
            {
                NextId = AccountId + 1;
            }
        }

        public void AssignAccountNumber()
        {
            if (AccountId < 0)
            {
                AccountId = NextId++;
            }
        }

        static public void SetupListView(ListView in_listView, bool in_fullInfo)
        {
            in_listView.Columns.Add("Account Id", -2);
            in_listView.Columns.Add("First Name", -2);
            in_listView.Columns.Add("Last Name", -2);
            if (in_fullInfo)
            {
                in_listView.Columns.Add("Money", -2);
                in_listView.Columns.Add("Pin Code", -2);
                in_listView.Columns.Add("Pin Locked", -2);
            }

        }
        public ListViewItem CreateListViewItem(bool in_fullInfo)
        {
            ListViewItem item;
            if (in_fullInfo)
            {
                item = new ListViewItem(new[] { Convert.ToString(AccountId), FirstName, LastName, Convert.ToString(Money), Convert.ToString(PinCode), Convert.ToString(IsLocked()) });
            }
            else
            {
                item = new ListViewItem(new[] { Convert.ToString(AccountId), FirstName, LastName });
            }
            item.Tag = this;
            return item;
        }

        public bool TryPin(int in_pin)
        {
            if (IsLocked())
            {
                return false;
            }
            if (in_pin == PinCode)
            {
                FailedPinTries = 0;
                return true;
            }
            FailedPinTries++;
            return false;
        }

        public bool IsLocked()
        {
            return FailedPinTries >= 3;
        }

        public void Unlock()
        {
            FailedPinTries = 0;
        }

        public string GetCSV()
        {
            return AccountId + "," + FirstName + "," + LastName + "," + Money + "," + PinCode + "," + FailedPinTries;
        }

    }
}
