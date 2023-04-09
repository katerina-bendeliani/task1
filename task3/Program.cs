using System;
using System.Collections.Generic;
using System.Linq;

namespace quiz2


{
    class Program

    {
        static void Main(string[] args)
        {
            int[] myarray = { 4, 4, 5, 7, 2, 3, 3 };

            int sum = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] % 2 != 0)
                {
                    sum += myarray[i];
                }
            }

            Console.WriteLine(sum);

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] % 2 == 0)
                {
                    sum *= myarray[i];
                }

            }
            Console.WriteLine(sum);


            int[] counts = new int[myarray.Max() + 1];
            for (int i = 0; i < myarray.Length; i++)
                if (counts[myarray[i]] == 0)
                {
                    for (int j = 0; j < myarray.Length; j++)
                        if (myarray[i] == myarray[j])
                            counts[myarray[i]]++;
                    Console.WriteLine(myarray[i] + "-" + counts[myarray[i]] + "times");
                }
            Console.ReadKey();

        }

    }

}
