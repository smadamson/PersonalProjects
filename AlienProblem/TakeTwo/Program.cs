using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTwo
{
     class AlienProblem
    {
        ///What is the probability that the alien species dies eventually?
        public static void Main(String[] args)
        {
            //Number of simulations
            int n = 1;
            int count = 0;
            double exValue = 0;
            double prob = 0;

            //The starting number of aliens
            int aliens = 1;

            while (count < n)
            {
                exValue += Aliens(aliens, prob);
                count++;
            }

            Console.WriteLine(exValue / count);
        }

        /// <summary>
        /// Recursively returns the probability for the given number of aliens given the current probability.  
        /// </summary>
        /// <param name="aliens"></param>
        /// <param name="currProb"></param>
        /// <param name="prob"></param>
        /// <returns></returns>
        public static double Aliens(int aliens, double currProb)
        {
            Random rnd = new Random();
            int result;
            double prob = currProb;

            //options:
            // 0 = alien dies
            // 1 = alien does nothing
            // 2 = alien + 1
            // 3 = alien + 2
            // each one has a .25% chance of happeneing. 
            while (aliens > 0)
            {
                result = rnd.Next(0, 4);
                switch (result)
                {
                    case 0:
                        aliens--;
                        prob *= .25;
                        break;
                    case 1:
                        prob *= .25;
                        break;
                    case 2:
                        prob *= Aliens(aliens + 1, prob);
                        break;
                    case 3:
                        prob *= Aliens(aliens + 2, prob);
                        break;
                }
            }
            return prob;

        }
    }
}
