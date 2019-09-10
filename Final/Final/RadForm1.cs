using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

namespace Final
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public static BindingList<Restaurant> recordList = new BindingList<Restaurant>();
        public static List<string> priceList = new List<string>() {"$","$$","$$$","$$$$"};
        public static BindingList<String> locList = new BindingList<String>();
        RadForm2 RadForm2;
        RadForm3 RadForm3;
        RadForm4 RadForm4;
        RadForm5 RadForm5;
        RadForm6 RadForm6;

        public RadForm1()
        {
            InitializeComponent();
            Thread.Sleep(2000);
        }
        private void writeFile(object sender, FormClosingEventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(BindingList<Restaurant>));
            TextWriter writer = new StreamWriter("records.xml");
            ser.Serialize(writer, recordList);
            writer.Close();
        }
        private void addRestButton_Click(object sender, EventArgs e)
        {
            this.RadForm2 = new RadForm2(this);
            RadForm2.ShowDialog();
            restList.Refresh();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.RadForm4 = new RadForm4(this);
            RadForm4.ShowDialog();
            restList.Refresh();
            
        }
        private void genButton_Click(object sender, EventArgs e)
        {
            double b;
            if (greaterTextBox.Text.Equals("") && priceDropList.CheckedItems.Count != 0 && locationBox.CheckedItems.Count != 0)
            {
                List<Restaurant> list = new List<Restaurant>();
                foreach (Restaurant x in recordList)
                    foreach (var loc in locationBox.CheckedItems)
                        foreach (var price in priceDropList.CheckedItems)
                            if (x.location.Equals(loc.ToString()) && x.price.Equals(price.ToString()))
                                list.Add(x);
                if (list.Count != 0)
                {
                    Random rnd = new Random();
                    this.RadForm5 = new RadForm5(this, rnd.Next(0, list.Count));
                    RadForm5.ShowDialog();
                }

                else
                    RadForm6.ShowDialog();
            }
            else if(locationBox.CheckedItems.Count == 0 && priceDropList.CheckedItems.Count ==0 && greaterTextBox.Text.Equals(""))
            {
                    if (recordList.Count != 0)
                    {
                        Random rnd = new Random();
                        this.RadForm5 = new RadForm5(this, rnd.Next(0, recordList.Count));
                        RadForm5.ShowDialog();
                    }
            }
            else if (Double.TryParse(greaterTextBox.Text, out b))
            {
                List<Restaurant> list = new List<Restaurant>();
                foreach (Restaurant x in recordList)
                {
                    foreach (var loc in locationBox.CheckedItems)
                        foreach (var pr in priceDropList.CheckedItems)
                            if (x.location.Equals(loc.ToString())&& x.price.Equals(pr.ToString())&& x.rating>b)
                                list.Add(x);
                }                  
                if (list.Count != 0)
                {
                    Random rnd = new Random();
                    this.RadForm5 = new RadForm5(this, rnd.Next(0, list.Count));
                    RadForm5.ShowDialog();
                }

                else
                    RadForm6.ShowDialog();
            }
            else
                RadForm3.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            recordList.RemoveAt(restList.SelectedIndex);
            restList.Refresh();
        }

        private void restList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(restList.SelectedIndex>-1)
                nameTextBox.Text = recordList[restList.SelectedIndex].rname;
        }

        private void load(object sender, EventArgs e)
        {
            this.RadForm3 = new RadForm3();
            this.RadForm6 = new RadForm6();
            this.Text = "Random Restaurant Generator";

            if (!File.Exists("records.xml"))
                return;
            XmlSerializer ser2 = new XmlSerializer(typeof(BindingList<Restaurant>));
            TextReader reader = new StreamReader("records.xml");
            recordList = (BindingList<Restaurant>)ser2.Deserialize(reader);
            reader.Close();

            foreach (Restaurant x in recordList)
            {
                if (!locList.Contains(x.location))
                {
                    locList.Add(x.location);
                }
            }

            locationBox.DataSource = locList;
            restList.DataSource = recordList;
            restList.DisplayMember = "rname";

            priceDropList.DataSource = priceList;
        }
    }

    [Serializable]
    public class Restaurant
    {
        public string rname { get; set; }
        public string location;
        public string price;
        public double rating;
        public Restaurant() { }
        public Restaurant(string rname, string location, string price, double rating)
        {
            this.rname = rname;
            this.location = location;
            this.price = price;
            this.rating = rating;
        }
    }
}
