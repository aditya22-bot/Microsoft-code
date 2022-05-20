using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.collection
{
    class student:IComparable<student>
    {
        string name;
        int percent;
        string lang;
        public int CompareTo(student c)
        {
            return this.percent.CompareTo(c.percent);
        }
        public override string ToString()
        {
            return "Name" + name + " percernt " + percent + " lang " + lang;
        }
        public student(string name, int percent, string lang)
        {
            this.Name = name;
            this.Percent = percent;
            this.Lang = lang;
        }


        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Lang { get => lang; set => lang = value; }
    }
    class QQ
    {
        string name;
        int percent;
        string lang;

        public QQ(string name, int percent, string lang)
        {
            this.Name = name;
            this.Percent = percent;
            this.Lang = lang;
        }

        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Lang { get => lang; set => lang = value; }

        static void Main(string[] args)
        {
            QQ q = new QQ("Aditya", 56, "It");
        }
    }
}
