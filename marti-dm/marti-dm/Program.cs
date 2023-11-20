using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marti_dm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Rectangle> rectanglesHolder = new Dictionary<string, Rectangle>();

            int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int numberOfRectangles = tokens[0];
            int numberOfChecks = tokens[1];

            for (int iterator = 0; iterator < numberOfRectangles; iterator++)
            {
                string[] rectangleTokens = Console.ReadLine().Split(' ').ToArray();
                string id = rectangleTokens[0];
                rectanglesHolder[id] = new Rectangle(
                    id, 
                    int.Parse(rectangleTokens[1]), 
                    int.Parse(rectangleTokens[2]), 
                    int.Parse(rectangleTokens[3]), 
                    int.Parse(rectangleTokens[4]));
            }

            for (int iterator = 0; iterator < numberOfChecks; iterator++)
            {
                string[] rectanglesToCheck = Console.ReadLine().Split(' ');
                Rectangle firstRectangle = rectanglesHolder[rectanglesToCheck[0]];
                Rectangle secondRectangle = rectanglesHolder[rectanglesToCheck[1]];

                Console.WriteLine(firstRectangle.impriefs(secondRectangle) || secondRectangle.impriefs(firstRectangle));
            }
        }
    }
}
