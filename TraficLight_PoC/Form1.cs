using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficLight_PoC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlTraficLight1_OnColorChanged(ctrlTraficLight.EventData e)
        {
            MessageBox.Show($"Color changed from {e.PreviousColor} to {e.CurrentColor}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTraficLight1.Start();
        }
    }
}
