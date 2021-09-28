using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Village : Creature
    {
        public Village(string name)
        {
            this.name = name;
        }
        public String Talk()
        {
            return "Oh~~ Weather is good";
        }

        public override string attack(Creature target)
        {
            return name + "不能攻擊其他玩家";
        }
    }
}
