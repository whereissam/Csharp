using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Village : Creature, IAttackable, ITalkable
    {
       public Village() : base("Village")
        {

        }

        public void attack(Creature target)
        {
            target.injured(1);
        }

        public string talkTo(Creature target)
        {
            return "Hi " + target.getName() + ", I am Village";
        }
    }
}
