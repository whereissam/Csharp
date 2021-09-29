using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    abstract class Creature
    {
        protected int hp = 100;

        public Creature(string name)
        {
            this.name = name;
        }
        public int GetHP() //取得血量
        {
            return hp;
        }

        public abstract string attack();

        public virtual string Move()
        {
            return name + " Go forward";
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
        
       public virtual string introducedSelf()
        {
            return "I am bad guysss";
        }
    }
}
