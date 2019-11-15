using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
    class Exam4
    {
        static Tuple<int, int> DigitalRoot(long num)
        {
            int i = 0;
            while (num > 9)
            {
                num = num.ToString().ToCharArray().Sum(x => x - '0');
                i++;
            }
            return new Tuple<int, int>(i, (int)num);
        }
        static void Main(string[] args)
        {
            int[] broj = { 98532 };
            foreach (long num in broj)
            {
                var q = DigitalRoot(num);

                Console.WriteLine(num + "{0} has digital root {2}", num, q.Item2);

            }
        }


    }
}