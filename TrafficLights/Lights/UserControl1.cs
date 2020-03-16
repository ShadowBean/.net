using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Lights.Properties;

namespace Lights
{
    public partial class UserControl1: UserControl
    {
        readonly List<int> Durations = new List<int>()
        {
            3,
            1,
            5
        };
        readonly List<Image> Lights = new List<Image>()
        {
             Resources.zielone,
             Resources.zolty,
             Resources.czerwone
        };

        private void TimerInit()
        {
            green_duration.Value = Durations[0];
            yellow_duration.Value = Durations[1];
            red_duration.Value = Durations[2];

            Green_Timer.Stop();
            Green_Timer.Interval = Durations[0] * 1000;

            Yellow_Timer.Stop();
            Yellow_Timer.Interval = Durations[1] * 1000;

            Red_Timer.Stop();
            Red_Timer.Interval = Durations[2] * 1000;
            Red_Timer.Start();
            pictureBox1.Image = Lights[2];

        }

        public UserControl1()
        {
            InitializeComponent();
            TimerInit();
           
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Durations[0] = (int)green_duration.Value;
            Durations[1] = (int)yellow_duration.Value;
            Durations[2] = (int)red_duration.Value;
            TimerInit();
        }

        private void Green_Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Lights[1];
            Red_Timer.Stop();
            Yellow_Timer.Start();
            Green_Timer.Stop();
        }

        private void Yellow_Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Lights[2];
            Red_Timer.Start();
            Yellow_Timer.Stop();
            Green_Timer.Stop();
        }

        private void Red_Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Lights[0];
            Red_Timer.Stop();
            Yellow_Timer.Stop();
            Green_Timer.Start();
        }
    }
}
