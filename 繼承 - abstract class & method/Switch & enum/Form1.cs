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
            /*
            Student s1 = new Student(1020, "ha", 160);
            Student s2 = new Student(1021, "JA", 190);
            Student s3 = new Student(2020, "wow", 3);

            int a = 10;
            int b = 20;
            int c = Math.max(a, b);

            s1.Score = 20;
            s2.Score = 80;

            Student.PassScore = 60;

            //MessageBox.Show(s2.Say());
            MessageBox.Show("" + c);
            */
            Monster monster = new Monster();

            monster.Move(Direction.UP);
            monster.Move(Direction.UP);
            monster.Move(Direction.LEFT);

            MessageBox.Show(monster.ReportPosition());
        }
    }
}
