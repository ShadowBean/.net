using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MessageBoxes
{
    public partial class Form1 : Form
    {

        string curDir = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(curDir + @"\a.wav");
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(curDir + @"\b.wav");
            player.Play();
            DialogResult result1 = MessageBox.Show("Are you a illuminati?","Important Question",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result1 == DialogResult.Yes)
            {
                player = new System.Media.SoundPlayer(curDir + @"\e.wav");
                player.Play();
            }
            else
            {
                player = new System.Media.SoundPlayer(curDir + @"\d.wav");
                player.Play();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(curDir + @"\c.wav");
            player.Play();
            DialogResult result1 = MessageBox.Show("123456789", "Number of my ex-girl");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(curDir + @"\f.wav");
            player.Play();
            DialogResult result1 = MessageBox.Show("Gdyby bracia golec zrobily by grę to była by to strzelaninka z trąbkami", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DA DA DANCE", "PA PA YA!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3, MessageBoxOptions.RightAlign, curDir+@"\Readme.txt");
        }
    }
}
