using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            public enLights PreviousColor;
            public enLights CurrentColor;
        

            public EventData(enLights PreviousColor, enLights CurrentColor)
            {
                this.PreviousColor = PreviousColor;
                this.CurrentColor = CurrentColor;
            }



        }
        

        /// <summary>
        /// Event to notify subs after color changed
        /// </summary>
        public event Action<EventData> OnColorChanged;
        // Create a protected method to raise the event with a parameter
        protected virtual void ColorChanged(EventData e)
        {
            Action<EventData> handler = OnColorChanged;
            if (handler != null)
            {
                handler(e); // Raise the event with the parameters
            }
        }


        public enum enLights {Red=1,Orange=2,Green=3 };


        private enLights _CurrentLight=enLights.Red;
        private byte _GreenTime;
        private byte _RedTime;
        private byte _OrangeTime;

        /// <summary>
        /// Counter to set color
        /// </summary>
        private byte _Counter;

        public enLights CurrentLight { set
            {
                _CurrentLight = value;
                    
                if(value==enLights.Red)
                {
                    pbTrafficLight.Image = Resources.Red;
                    _Counter = RedTime;
                    lblCounter.ForeColor = Color.Red;
                }
                else if(value==enLights.Green)
                {
                    pbTrafficLight.Image = Resources.Green;
                    _Counter = GreenTime;
                    lblCounter.ForeColor = Color.Green;

                }
                else if(value==enLights.Orange)
                {
                    pbTrafficLight.Image = Resources.Orange;
                    _Counter = OrangeTime;
                    lblCounter.ForeColor = Color.Orange;

                }
                ;
            }


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
            _Counter = RedTime;
            Timer1.Start();
        }


        /// <summary>
        /// set color and rise 'color changed' event
        /// </summary>
        private void changeColor()
        {
            switch(_CurrentLight)
            {
                case enLights.Red:
                    CurrentLight = enLights.Orange;
                    //ColorChanged(new EventData(enLights.Red,_CurrentLight));
                    break;
                case enLights.Orange:
                    CurrentLight = enLights.Green;
                   // ColorChanged(new EventData(enLights.Orange, _CurrentLight));
                    break;
                case enLights.Green:
                    CurrentLight = enLights.Red;
                   // ColorChanged(new EventData(enLights.Green, _CurrentLight));
                    break;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblCounter.Text = _Counter.ToString();


            if (_Counter==1)
            {
                changeColor();
                return;
            }
            else
            {
                _Counter--;
       
            }


        }
    }
}
