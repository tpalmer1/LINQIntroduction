using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                orderby score ascending
                select score;

            /*IEnumerable<int> scoreQuery =
                (from score in scores
                 where score > 80
                 select score).ToArray();*/

            //Console.WriteLine("{0}",scoreQuery.Count());

            //Immediate execution
            int scoreCount = scoreQuery.Count();

            //Deferred execution
            foreach(int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nTotal: {0}",scoreCount);
        }
    }
}
