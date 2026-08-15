using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraficLight_PoC.Properties;

namespace TraficLight_PoC
{
    public partial class ctrlTraficLight : UserControl
    {
        public ctrlTraficLight()
        {
            InitializeComponent();
        }

       public enum enLights {Red=1,Orange=2,Green=3 };


        private enLights _CurrentLight;

       public enLights CurrentLight { set
            {
                _CurrentLight = value;
                    
                if(value==enLights.Red)
                {
                    pbTrafficLight.Image = Resources.Red;
                }
                else if(value==enLights.Green)
                {
                    pbTrafficLight.Image = Resources.Green;
                }
                else if(value==enLights.Orange)
                {
                    pbTrafficLight.Image = Resources.Orange;
                } ;}


            get { return _CurrentLight; } }


     

        public void Start()
        {
            

        }



    }
}
