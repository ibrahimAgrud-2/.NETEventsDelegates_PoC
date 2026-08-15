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


        public class EventData : EventArgs
        {
            public int val1;
            public int val2;
            public int result;

            public EventData(int val1, int val2, int result)
            {
                this.val1 = val1;
                this.val2 = val2;
                this.result = result;
            }



        }
        
        
        public event Action<int> OnColorChanged;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonLoaded(int PersonID)
        {
            Action<int> handler = OnColorChanged;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }


        public enum enLights {Red=1,Orange=2,Green=3 };


        private enLights _CurrentLight;
        private byte _GreenTime;
        private byte _RedTime;
        private byte _OrangeTime;

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


        /// <summary>
        ///GreenTime determines how many seconds the light color will remain green after turning green.
        /// </summary>
        public byte GreenTime { set { _GreenTime = value; } get { return _GreenTime; } }

        /// <summary>
        ///OrangeTime determines how many seconds the light color will remain orange after turning orange.
        /// </summary>
        public byte OrangeTime { set { _OrangeTime = value; } get { return _OrangeTime; } }

        /// <summary>
        ///RedTime determines how many seconds the light color will remain red after turning red.
        /// </summary>
        public byte RedTime { set { _RedTime = value; } get { return _RedTime; } }



        /// <summary>
        /// starts the timers.
        /// </summary>
        public void Start()
        {

          
        }



    }
}
