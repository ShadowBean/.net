using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Person i in TableOfPersons.Datas)
            {
                int index = TableOfPersons.Datas.IndexOf(i);
                Data.Text +="#"+index+" "+i.Imie+" "+i.Nazwisko+" "+i.Adres+"\r\n";
            }


        }
    }
}
