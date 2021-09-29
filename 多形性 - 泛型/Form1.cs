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
            Building<Worker> b = new Building<Worker>();

            b.Add(new Worker("Han"));
            b.Add(new Worker("Jia"));

            //b.Add(new Resident("hoho"));
            MessageBox.Show(b.ToString());
         
        }
    }
}
