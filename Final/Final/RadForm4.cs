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
    public partial class RadForm4 : Telerik.WinControls.UI.RadForm
    {
        RadForm1 Radform1Ref;
        RadForm3 RadForm3;
        public RadForm4(RadForm1 Radform1)
        {
            InitializeComponent();
            this.Radform1Ref = Radform1;
            this.Text = "Edit Restaurant";
            priceEditList.DataSource = RadForm1.priceList;                
        }

        private void load(object sender, EventArgs e)
        {
            if (Radform1Ref.restList.SelectedIndex > -1)
            {
                nameEditTextBox.Text = RadForm1.recordList[Radform1Ref.restList.SelectedIndex].rname;
                locEditTextBox.Text = RadForm1.recordList[Radform1Ref.restList.SelectedIndex].location;
                priceEditList.Text = RadForm1.recordList[Radform1Ref.restList.SelectedIndex].price;
                ratingEditTextBox.Text = RadForm1.recordList[Radform1Ref.restList.SelectedIndex].rating.ToString();
            }
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            double x;
            if (Double.TryParse(ratingEditTextBox.Text, out x))
            {
                if (!RadForm1.locList.Contains(locEditTextBox.Text))
                {
                    RadForm1.locList.Add(locEditTextBox.Text);
                }
                RadForm1.recordList.RemoveAt(Radform1Ref.restList.SelectedIndex);
                RadForm1.recordList.Insert(Radform1Ref.restList.SelectedIndex, new Restaurant(nameEditTextBox.Text, locEditTextBox.Text, priceEditList.Text, x));
                this.Close();
            }
            else
                RadForm3.ShowDialog();
        }
    }
}
