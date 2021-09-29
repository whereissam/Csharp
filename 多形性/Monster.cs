using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Monster : Creature
    {
        public Monster(string name) : base(name)
        {

        }

        public void attack(Creature c)
        {
            c.injured(10);
        }
    }
}
