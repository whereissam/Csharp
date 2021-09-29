using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class User
    {
        private string Username;
        private string Password;
        private int count1, count5, count10;

        public int Money
        {
            get { return count1 + count5 * 5+ count10 * 10; }
        }

        private int HP;
        public int hp
        { 
          get {return HP ;}
          set
            {
                if (value < 10)
                    HP = 0;
                else
                    HP = value;
            }
        }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            this.HP = 20;
            this.count1 = 1;
            this.count5 = 1;
            this.count10 = 1;
        }
        public bool comparePassword(string targetPassword)
        {
            if (this.Password == targetPassword)
                return true;
            else
                return false;
        }

        public string getUserName()
        {
            return Username;
        }
        public void reset()
        {
            Password = "";
        }

        public void hurt(int decreaseHP)
        {
            if (HP >= decreaseHP)
                HP -= decreaseHP;
            else
                HP = 0;
        }

        public int getHP()
        {
            return HP;
        }
    }
}
