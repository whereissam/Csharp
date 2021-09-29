using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Creature
    {
        private int hp;
        private string name;
        public Creature(string name)
        {
            this.name = name;
            this.hp = 100;
        }
       
        public void injured(int demage)
        {
            if(demage > hp)
            {
                hp = 0;
            }
            else
            {
                hp -= demage;
            }
        }

        public string say()
        {
            return "I am " + name + ", I have " + hp + " HP";
        }
    }
}
