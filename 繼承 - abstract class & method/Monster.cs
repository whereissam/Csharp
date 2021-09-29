using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Monster : Creature
    {
        public Monster() : base("monster")
        {
            
            hp = 500;
        }
        public void Attack(Creature c) //攻擊數字
        {
            c.Injured(10);
        }

        public override string attack()
        {
            return "Monster attack heavily";
        }

        public new string Move()
        {
            return name + " GO beside";
        }

        public string Say()
        {
            return base.introducedSelf() + ", I am monster";
        }
        public override string introducedSelf()
        {
            return base.introducedSelf() + ", I am monsterss";
        } 
      
    }
}
