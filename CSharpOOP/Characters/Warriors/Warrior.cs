using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Warrior
    {
        private int height;
        private int weight;
        private int age;
        private string name;

        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age {
            get
            {
                return age;
            }
            set
            {
                if (value >= 14 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The select age for {name}, is not a proper age for a Warrior. The age mut be between 18 and 45.");                  
                }
            }
        }
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            } 
        }

        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
        }
    }
}
