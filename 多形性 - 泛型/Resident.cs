using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Resident
    {
        private String name;
        public Resident(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Resident" + name;
        }
    }
}
