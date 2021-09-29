using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Monster mon = new Monster("Momo");
            Creature cat = new Monster("Momo");
            Village vil = new Village();

            mon.attack(vil);
            mon.attack(mon);

            MessageBox.Show(vil.say());
            MessageBox.Show(mon.say());

        }
    }
}
