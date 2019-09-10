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
    public partial class RadForm5 : Telerik.WinControls.UI.RadForm
    {
        RadForm1 Radform1Ref;
        private int r;
        public RadForm5(RadForm1 Radform1, int r)
        {
            InitializeComponent();
            this.Radform1Ref = Radform1;
            this.Text = "Random Restaurant";
            this.r = r;
        }

        private void load(object sender, EventArgs e)
        {
            TextBox.Text = RadForm1.recordList[this.r].rname;
        }
    }
}
