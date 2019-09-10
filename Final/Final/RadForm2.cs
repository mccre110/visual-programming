using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Final
{
    public partial class RadForm2 : Telerik.WinControls.UI.RadForm
    {
        RadForm1 Radform1Ref;
        RadForm3 RadForm3;
        public RadForm2(RadForm1 Radform1)
        {
            InitializeComponent();
            this.Radform1Ref = Radform1;
            this.Text = "Add Restaurant";
            priceAddList.DataSource = RadForm1.priceList;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse(ratingAddTextBox.Text, out x))
            {
                if (!RadForm1.locList.Contains(locAddTextBox.Text))
                {
                    RadForm1.locList.Add(locAddTextBox.Text);
                }
                RadForm1.recordList.Add(new Restaurant(nameAddTextBox.Text, locAddTextBox.Text, priceAddList.Text, x));
                this.Close();
            }
            else
                RadForm3.ShowDialog();

        }

        private void close(object sender, FormClosingEventArgs e)
        {
            nameAddTextBox.Clear();
            locAddTextBox.Clear();
            priceAddList.Text = String.Empty;
            ratingAddTextBox.Clear();
        }
    }
}
