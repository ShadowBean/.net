using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClockControl.Properties;

namespace ClockControl
{
    public partial class AnalogDigitClock: UserControl
    {

        readonly List<Bitmap> Images = new List<Bitmap>()
        {
             Resources.back,
             Resources.dot,
             Resources.hour,
             Resources.minute,
             Resources.second
        };

        public AnalogDigitClock()
        {
            InitializeComponent();
            Digit.Text = DateTime.Now.ToString("HH:mm   ss");

            Pictures();

            Timer.Start();
        }
        void Pictures()
        {
            backBox.Image = Images[0];
            backBox.Controls.Add(hourBox);
          

            hourBox.Controls.Add(minuteBox);
            hourBox.Location = new Point(0, 0);

            minuteBox.Controls.Add(dotBox);
            minuteBox.Location = new Point(0, 0);

            dotBox.Image = Images[1];
            dotBox.Location = new Point(0, 0);

            dotBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Digit.Text = DateTime.Now.ToString("HH:mm   ss");

            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            hourBox.Image = RotateImage(Images[2], AngleH);
            minuteBox.Image = RotateImage(Images[3], AngleM);
            secondBox.Image = RotateImage(Images[4], AngleS);

        }

        private Bitmap RotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }

            return rotatedImage;
        }

        
    }
}
