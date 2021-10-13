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
            //this.button3.Click += new EventHandler(this.ButtonClick);
            this.button3.Click += (sender, e) =>
            {
                this.textBox1.Text = "heop";
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ButtonClick(object sender, EventArgs e)
        {
           if(sender == this.button1)
            {
                this.textBox1.Text = "Hello";
            }
           if(sender == this.button2)
            {
                this.textBox1.Text = "World";
            }
           if(sender == this.button3)
            {
                this.textBox1.Text = "Hey";
            }

        }
    }
   
}
