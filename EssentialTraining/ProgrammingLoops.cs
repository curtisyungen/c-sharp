using System;

namespace EssentialTraining
{
    public class ProgrammingLoops
    {
        public void ForLoop()
        {
            var sum = 0;
            for (var i=0; i<100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
