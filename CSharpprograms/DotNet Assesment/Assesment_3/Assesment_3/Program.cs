using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    public class CricketTeam
        {
            public string TeamName { get; set; }
            public int matches { get; set; }
            public int Sum { get; set; }
            static public double Average { get; set; }

        public (int, int, double) PointsCalculation(int noOfMatches)
        {
            Sum = 0;
            for (int i = 0; i < noOfMatches; i++)
            {
                Console.WriteLine($"Enter score for match {i + 1}: ");
                Sum += Convert.ToInt32(Console.ReadLine());
            }
            matches = noOfMatches;
            Average = (double)Sum / noOfMatches;
            return (matches, Sum, Average);

        }
        class Program
        {
            static void Main()
            {
                CricketTeam team = new CricketTeam();
                team.TeamName = "Mumbai Indians";
                Console.WriteLine("Enter number of matches:");
                int noOfMatches = Convert.ToInt32(Console.ReadLine());
                var (matches, sum, average) = team.PointsCalculation(noOfMatches);
                Console.WriteLine($"Team:{team.TeamName}");
                Console.WriteLine($"Matches:{matches}");
                Console.WriteLine($"Sum:{sum}");
                Console.WriteLine($"Average:{Average}"); 
                Console.ReadLine();
            }
        }
    }
}
