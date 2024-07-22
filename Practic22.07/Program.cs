using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic22._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // одномерный массив
            /*            int[] numbers;
                        numbers = new int[5] { 3,4,12,4,4};

                        int[] num2 = new int[] { 5, 32, 6, 2, 1, 6 };
                        string[] str = { "ert", "ergty","rgff"};
                        Console.WriteLine(numbers[2]);*/

            // многомерный массив
            /*            int[,] arr1 = new int[2, 3] { { 5,32,2},{8,5,0 } };
                        int[,] arr2 = new int[,] { { 5,32,2},{8,5,0 } };
                        int[,] arr3 = { { 5,32,2},{8,5,3 } };
                        Console.WriteLine(arr1.GetLength(1)); // 8*/

            /*int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tempArr = (int[])arr.Clone();

            Array.Reverse(arr, 3, 4);
            PrintArray(arr, "Reverse");

            arr = tempArr;

            int[] arr2 = new int[20];
            PrintArray(arr2, "Arr2");

            arr.CopyTo(arr2, 5);
            PrintArray(arr2, "Arr2 после копирования");

            Array.Clear(arr2, 0, arr2.GetLength(0));
            PrintArray(arr2, "Arr2 после очистки");

            arr2 = new[] { 5, 8, 4, 3, 4, 6, 1, 6, 3, 4, 8, 6 };
            Array.Sort(arr2);
            PrintArray(arr2, "Arr2 после сортировки");

            Console.WriteLine("Поиск 6 в массиве arr2: " + Array.BinarySearch(arr2, 6));
            Console.WriteLine("Max = " + arr2.Max());
            Console.WriteLine("Min = " + arr2.Min());
            Console.WriteLine("Avg = " + arr2.Average());

            int[,,] arr3 = 
            { 
                { 
                    {6,4 },
                    {7,2 }
                }, 
                { 
                    {9,0 },
                    {0,0 }
                }, 
                { 
                    {1,6 },
                    { 7,7} 
                } 
            };
            Console.WriteLine("Rank = " + arr3.Rank);*/

            /*int size = 5;
            int[][] arr = new int[size][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[i + 1];
            }

            for (int i = 0;i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = i + j + 1;
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }*/

            /*string str = Console.ReadLine();
            if (str.Length == 6)
            {
                int[] num = new int[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        num[i] = Convert.ToInt32(str[i].ToString());
                }
                int n, m;
                n = Int32.Parse(Console.ReadLine());
                m = Int32.Parse(Console.ReadLine());
                if (n < 6 && n >= 0 && m < 6 && m >= 0)
                {
                    int z = num[n];
                    num[n] = num[m];
                    num[m] = z;

                    foreach (int i in num)
                    {
                        Console.Write(i);
                    }
                }
            }*/
            string number = Console.ReadLine();
            /*if (number.All(char.IsDigit))
            {
                int indexStart = int.Parse(Console.ReadLine());
                int indexEnd = int.Parse(Console.ReadLine());
                char[] temp = number.ToCharArray();
                char z = temp[indexStart];
                temp[indexStart] = temp[indexEnd];
                temp[indexEnd] = z;
                int newNumber = int.Parse(new string(temp));
                Console.WriteLine(newNumber);
            }*/
            }

        /*static void PrintArray(int[] arr, string text)
        {
            Console.WriteLine(text + ":");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            foreach (int a in arr)
            {
                Console.Write(a + ",");
            }
            Console.WriteLine();
        }*/


    }
}
