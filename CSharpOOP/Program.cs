using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior(190, 80, "Good guy");

            Warrior theBadGuy = new Warrior(170, 90, "Bad guy");

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);
        }
    }
}
