using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pairsinarr
{
     class arrclass
    {
        public static void arrmeth(int arrayLength, int[] myArray, Random random)
    {
        for (int i = 0; i < arrayLength; i++)
        {
            myArray[i] = random.Next(-10000, 10001);
            Console.Write(myArray[i] + ",");
        }
    }

        public static int GetNumberOfPairs(int[] array, int length)
        {
            int amountOfPairs = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    amountOfPairs++;
                }
            }
            return amountOfPairs;
        }
    }
}