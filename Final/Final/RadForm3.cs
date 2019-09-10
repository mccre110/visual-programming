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
    public partial class RadForm3 : Telerik.WinControls.UI.RadForm
    {
        public RadForm3()
        {
            InitializeComponent();
            this.Text = "Try Again";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
