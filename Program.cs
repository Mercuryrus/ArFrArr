using System;

namespace ArFrArr
{
    class Program
    {
        static void Main()
        {
            GetArray();
        }
        public static void GetArray()
        {
            int[] arrA = { 2, 2, 6, 4, 2, 8, 2, 2, 3, 3};
            double[] arrB = new double[arrA.Length / 2];
            Console.WriteLine(arrA.Length);
            Console.WriteLine(arrB.Length);
            foreach (int i in arrA)
            {
                Console.Write($" {i}");
            }

            Console.WriteLine();
                for(int k=0; k<arrB.Length;k++)
                {
                    arrB[k] = ((arrA[k+1] + arrA[k]) / 2.0);
                }
            Console.WriteLine("Новый массив:");
            foreach(int i in arrB)
            {
                Console.Write(i);
            }

        }
    }
}
