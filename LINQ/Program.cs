using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names... done
            //Order the list of games by length of the game name.
            //Use the lambda expression in this exercise as well.
            //use Method Syntax for this exercise

            List<string> sportsTeams = new List<string>() { "Rangers", "Angels", "Indians", "Oilers", "Stars" };

           var sortedList = sportsTeams.OrderBy(x => x.Length);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }


        }
    }
}
