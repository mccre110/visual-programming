using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj07
{
    public partial class Form2 : Form
    {
        Form1 form1Ref;

        public Form2(Form1 form1)
        {
            InitializeComponent();

            this.form1Ref = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pingSecondsBox.Text = form1Ref.pingSecondsBox.Text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1Ref.pingSecondsBox.Text = pingSecondsBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
