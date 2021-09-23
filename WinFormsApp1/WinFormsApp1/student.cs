using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WinFormsApp1
{
    class Student
    {
        public int StudentID;
        public string Name;
        public int Grade;

        //Method
        //public output型別 method名稱(Input型別與名稱)
        public Student(int studentID, string name)
        {
            StudentID = studentID;
            Name = name;
            Grade = 1;
        }

        public Student(int studentID, string name, int grade)
        {
            StudentID = studentID;
            Name = name;
            Grade = grade;
        }

        public string Say()
        {
            return "I am " + Name + " ,I am " + Grade + " grade student";
        }

        public string Talk(Student s2)
        {
            return Grade + " grade "+ Name + " ,"+ s2.Grade + " grade " + s2.Name + " say hello ";
        }

        public void Upgrade()
        {
            Grade++;
        }
    }
}
