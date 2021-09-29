using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Monster : Creature, ITalkable
    {
        public Monster(string name) : base(name)
        {

        }

        public void attack(Creature target)
        {
            target.injured(5);
        }
        public string talkTo(Creature target)
        {
            return "Hi " + target + "I am Monster";
        }

        public override string getName()
        {
            return "I am monster";
        }
    }
}
