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

            Village village = new Village("Bungee");
            Monster monster = new Monster("Holy shis");
            Monster monster2 = new Monster("Hala gqu");

            monster.Attack(village);
            monster.Attack(monster2);

            Creature c = monster;

            string message = c.Move();

           // string message = village.attack(monster);

            //MessageBox.Show(monster.Move());
            MessageBox.Show(message);

            //MessageBox.Show("village " + village.GetHP());
            //MessageBox.Show("monster2 " + monster2.GetHP());
            
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
            //int[] scores = new int[40];


            //int[] scores = new int[] { 92, 80, 30};

            //scores[0] = 92;
            //scores[1] = 80;
            //scores[2] = 30;

            //essageBox.Show("" + scores[1]);

            /*
            int[,] A = new int[,] { { 5,6 }, { 7,8 } };
            int[,] B = new int[,] { { 1, 2 }, { 3, 4 } };

            //int c = A + B;

            string result = "";
            //double results = new double[]
            for (int x = 0; x < 2; x++) { 
                for(int y =0; y<2; y++)
                {
                    result += " " + A[x, y] + B[x,y];
                }
                result += "\n";
            }

            MessageBox.Show(result);
        }

        //private int [,] add(int[,] a, int[,] b)
       */
            /*
            User user = new User("SLMT", "1234");
            string result = "";
            if (user.comparePassword("1234"))
                result = "密碼正確!!";
            else
                result = "密碼錯誤喔喔喔";

            MessageBox.Show(result);
            MessageBox.Show(user.getUserName());
            */
            //User user = new User("SLMT", "1234");

            //user.hp = -10;
            //MessageBox.Show("" + user.Money);

            /*
            user.hurt(10);
            MessageBox.Show("" + user.getHP());
            user.hurt(10);
            MessageBox.Show("" + user.getHP());
            user.hurt(10);
            MessageBox.Show("" + user.getHP());
            */
        }
    }
}
