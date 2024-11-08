using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerkeerspleinProject
{
    public partial class Verkeersplein : Form
    {
        public Verkeersplein()
        {
            InitializeComponent();
            rood = true;
            oranje = false;
            groen = false;
            rood2 = true;
            groen2 = false;
        }
        bool rood, oranje, groen, knipperen = true;
        bool rood2, groen2;
        int speed = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rood == true)
            {
                rood = false;
                oranje = false;
                groen = true;
                timer1.Interval = 8000;
            }
            else if (groen == true)
            {
                rood = false;
                oranje = true;
                groen = false;
                timer1.Interval = 2000;
            }
            else if (oranje == true)
            {
                rood = true;
                oranje = false;
                groen = false;
                timer1.Interval = 60000;
            }
            picStopLicht1.Invalidate();
            picStopLicht2.Invalidate();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (oranje == true)
            {
                picCar.Left = picCar.Left + 15;
            }

            if (groen== true)
            {
                picCar.Left = picCar.Left + 30;
                
            }

            if (oranje == true)
            {
                picCar2.Left -= speed;
            }

            if (groen == true)
            {
                picCar2.Left -= speed;

            }

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (rood2 == true)
            {
                rood2 = false;
                groen2 = true;
                timer3.Interval = 8000;
            }
            else
            {
                rood2 = true;
                groen2 = false;
                timer3.Interval = 80000;
            }
            picMiniStopLicht1.Invalidate();
            picMiniStopLicht2.Invalidate();
            picMiniStopLicht3.Invalidate();
            picMiniStopLicht4.Invalidate();
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (groen2 == true)
            {
                picJohnnyWalker.Top += speed;
                picJohnnyWalker2.Top -= speed;
            }
            else if (rood2 == true)
            {
                picJohnnyWalker.Top += speed;
                picJohnnyWalker2.Top -= speed;
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            rood = false;
            groen = false;

            if (knipperen == true)
            {
                picAmbulance.Top = picAmbulance.Top + 5;
                oranje = true;
                knipperen = false;
            }
            else
            {
                picAmbulance.Top = picAmbulance.Top + 5;
                oranje = false;
                knipperen = true;
            }

            if (picAmbulance.Location.Y > 350)
            {
                timer5.Interval = 600;
                rood = true;
                oranje = false; ;
                groen = false;
                knipperen = false;
            }
            picStopLicht1.Invalidate();
            picStopLicht2.Invalidate();
            picStopLicht3.Invalidate();
            picStopLicht4.Invalidate();

        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            rood = false;
            groen = false;

            if (knipperen == true)
            {
                oranje = true;
                knipperen = false;
            }
            else
            {
                oranje = false;
                knipperen = true;
            }
            picStopLicht1.Invalidate();
            picStopLicht2.Invalidate();
            picStopLicht3.Invalidate();
            picStopLicht4.Invalidate();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        private void btnVoetgangers_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer4.Enabled = true;
        }
        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
        }
        private void btnKnipperen_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
        }
        private void jpiccanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.FillRectangle(Brushes.Black, 5, 5, 25, 25);
            if (rood == true)
            {
                Canvas.FillEllipse(Brushes.Red, 5, 5, 20, 20);
            }
            else
            {
                Canvas.FillEllipse(Brushes.Gray, 5, 5, 20, 20);
            }
            if (oranje == true)
            {
                Canvas.FillEllipse(Brushes.Orange, 5, 30, 20, 20);
            }
            else
            {
                Canvas.FillEllipse(Brushes.Gray, 5, 30, 20, 20);
            }
            if (groen == true)
            {
                Canvas.FillEllipse(Brushes.Green, 5, 55, 20, 20);
            }
            else
            {
                Canvas.FillEllipse(Brushes.Gray, 5, 55, 20, 20);
            }
        }
        private void jpiccanvas2_Paint(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.FillRectangle(Brushes.Black, 5, 5, 25, 25);
            if (rood2 == true)
            {
                Canvas.FillEllipse(Brushes.Red, 5, 5, 20, 20);
            }
            else
            {
                Canvas.FillEllipse(Brushes.Gray, 5, 5, 20, 20);
            }
            if (groen2 == true)
            {
                Canvas.FillEllipse(Brushes.Green, 5, 30, 20, 20);
            }
            else
            {
                Canvas.FillEllipse(Brushes.Gray, 5, 30, 20, 20);
            }
        }

    }
    
}