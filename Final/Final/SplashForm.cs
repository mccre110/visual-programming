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
    public partial class SplashForm : Telerik.WinControls.UI.ShapedForm
    {
        public SplashForm()
        {
            InitializeComponent();

            PictureBox spashPictureBox = new PictureBox();
            spashPictureBox.Image = new Bitmap(@"splash.jpg");
            spashPictureBox.SizeMode = PictureBoxSizeMode.Normal;
            spashPictureBox.Dock = DockStyle.Fill;
            this.Controls.Add(spashPictureBox);

            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
