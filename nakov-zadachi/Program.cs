
using System;

namespace nakov_zadachi
{
    class Program
    {
        public static void TaskOne()
        {
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                array[i] = i * 5;
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        public static void TaskTwo()
        {
            int[] arr1 = new int[20];
            int[] arr2 = new int[20];

            for (int i = 0; i < 5; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int pesho = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        pesho++;
                    }
                }
            }

            if(pesho == 5)
            {
                Console.WriteLine("Qsha, ednakvi sa");
            }
            else
            {
                Console.WriteLine("Not Qsha, ne sa ednakvi");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
