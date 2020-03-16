using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Kodery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetImageEncodersExample();

        }

        private void GetImageEncodersExample()
        {
            ImageCodecInfo[] myCodecs;
            myCodecs = ImageCodecInfo.GetImageEncoders();
            int numCodecs = myCodecs.GetLength(0);
            
            if (numCodecs > 0)
            {

                string[] myCodecInfo = new string[(numCodecs * 12)];

                for (int i = 0; i < numCodecs; i++)
                {
                    myCodecInfo[i * 12] = "Codec Name = " + myCodecs[i].CodecName;
                    myCodecInfo[(i * 12) + 1] = "Class ID = " + myCodecs[i].Clsid.ToString();
                    myCodecInfo[(i * 12) + 2] = "DLL Name = " + myCodecs[i].DllName;
                    myCodecInfo[(i * 12) + 3] = "Filename Ext. = " + myCodecs[i].FilenameExtension;
                    myCodecInfo[(i * 12) + 4] = "Flags = " + myCodecs[i].Flags.ToString();
                    myCodecInfo[(i * 12) + 5] = "Format Descrip. = " + myCodecs[i].FormatDescription;
                    myCodecInfo[(i * 12) + 6] = "Format ID = " + myCodecs[i].FormatID.ToString();
                    myCodecInfo[(i * 12) + 7] = "MimeType = " + myCodecs[i].MimeType;
                    myCodecInfo[(i * 12) + 8] = "Version = " + myCodecs[i].Version.ToString();
                    myCodecInfo[(i * 12) + 9] = "Signature Masks = "+ myCodecs[i].SignatureMasks.ToString();
                    myCodecInfo[(i * 12) + 10] = "Signature Patterns = " + myCodecs[i].SignaturePatterns.ToString();
                    myCodecInfo[(i * 12) + 11] = "\n";
                }
                int numMyCodecInfo = myCodecInfo.GetLength(0);
            
                for (int i = 0; i < numMyCodecInfo; i++)
                {
                    listBox1.Items.Add(myCodecInfo[i]);
                }
            }
            else
                MessageBox.Show("No items found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}

