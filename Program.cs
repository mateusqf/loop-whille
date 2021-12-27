using System;

namespace Atv_loop_whille
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
            }




            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("valor de num: " + i, num[i]);
            }
        }
    }
}
