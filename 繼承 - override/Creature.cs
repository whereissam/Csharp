using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Creature
    {
        private int hp = 100;

        public int GetHP() //取得血量
        {
            return hp;
        }

        public virtual string Move()
        {
            return name + "Go forward";
        }
        public void Injured(int injuredPoint) //扣血
        {
            hp -= injuredPoint;
        }

        public string name;

        public virtual string attack(Creature target)
        {
            return name + " 被攻擊了 " + target.name;
        }
        
    }
}
