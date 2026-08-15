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
            public enLights NextColor;


            public EventData(enLights PreviousColor, enLights CurrentColor,enLights nextColor)
            {
                this.PreviousColor = PreviousColor;
                this.CurrentColor = CurrentColor;
                this.NextColor = nextColor;
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


        private enLights _CurrentLight;


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
                    lblCounter.ForeColor = Color.Red;
                    _Counter = RedTime;
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



  
        private void setTimer()
        {
            switch (_CurrentLight)
            {
                case enLights.Red:
                    _Counter = RedTime;
                    break;
                case enLights.Orange:
                    _Counter = OrangeTime;
                    break;
                case enLights.Green:
                    _Counter = GreenTime;
                    break;
            }
        }

        /// <summary>
        /// starts the timers.
        /// </summary>
        /// 

        public void Start()
        {
            setTimer();
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
                    ColorChanged(new EventData(enLights.Red,_CurrentLight,enLights.Green));
                    break;
                case enLights.Orange:
                    CurrentLight = enLights.Green;
                    ColorChanged(new EventData(enLights.Orange, _CurrentLight, enLights.Red));
                    break;
                case enLights.Green:
                    CurrentLight = enLights.Red;
                    ColorChanged(new EventData(enLights.Green, _CurrentLight,enLights.Orange));
                    break;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
       
            if (_Counter==0)
            {
                changeColor();
                lblCounter.Text = _Counter.ToString();
                return;
            }
            else
            {
                lblCounter.Text = _Counter.ToString();
                _Counter--;
             
            }


        }
    }
}
