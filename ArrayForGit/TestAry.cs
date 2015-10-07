//Joshua Pickenpaugh, IN2017, Adv.C#
//Modulu 07, October 6th, 2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForGit
{
    //3b:
    class TestAry
    {
        static void Main(string[] args)
        {
            int[] myArray = { 23, 44, 55, 12, 6, 99 };

            //2c:
            Console.WriteLine("The values in the array are:");
            for (int a = 0; a < myArray.Length; a++)
            {
                Console.WriteLine(myArray[a]);
            }

            //2d:
            ArrayMethod(myArray);

            Console.WriteLine();

            //2f:
            TestArray testAry = new TestArray("Array of values above 50:");
            //2g:
            testAry.AryDisplay(myArray);

            Console.ReadKey();
        }

        public static void ArrayMethod(int[] METHarray)
        {
            Console.WriteLine("The array displayed from the user-defined method are: ");
            //2e:
            for (int a = 0; a < METHarray.Length; a++)
            {
                Console.WriteLine(METHarray[a]);
            }
        }
    }
}
