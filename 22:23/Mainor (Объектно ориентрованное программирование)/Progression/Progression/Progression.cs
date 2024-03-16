using System;
using System.Runtime.ConstrainedExecution;

namespace Progression
{

    class Progression
    {

        protected long FirstValue()
        {
            this.cur = this.first;
            return this.cur;
        }

        protected long NextValue()
        {
            cur++;
            return cur;
        }

        public void PringProgression(int n)
        {
            Console.WriteLine(FirstValue());

            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine(NextValue);
                long number = NextValue();
                if(this.FlagError == false)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}