using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Building<P>
    {
        List<P> people = new List<P>();
        public void Add(P person)
        {
            people.Add(person);
        }

        public override string ToString()
        {
            string output = "這棟大樓有 : \r\n";

            for( int i = 0; i<people.Count; i++)
            {
                output += people[i].ToString() + "\r\n";
            }
            return output;
        }
    }
}
