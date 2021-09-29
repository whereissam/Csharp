using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Worker
    {
        private String name;
        public Worker(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Worker " + name;
        }
    }
}
