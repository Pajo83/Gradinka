using System;
using System.Collections.Generic;
using System.Text;

namespace Gradinka
{
    class Kid
    {
        private string name;
        private double age;

        public string Name { get => name; set => name = value; }
        public double Age { get => age; set => age = value; }

        public Kid(string name, double age)
        {
            this.age = age;
            this.name = name;
        }
    }
}
