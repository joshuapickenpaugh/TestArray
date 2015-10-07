//JP, IN2017, 10062015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_Ary
{
    class TestArray
    {
        public string msg { get; set; }

        public TestArray(string message)
        {
            msg = message;
        }

        public void AryDisplay(int[] methARRAY)
        {
            Console.WriteLine(this.msg);
            foreach (int num in methARRAY)
            {
                if (num >= 50)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
