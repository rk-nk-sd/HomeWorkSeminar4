using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

namespace Task_002
{
    public class Task_002
    {
        public const int MIN = 100;
        public const int MAX = 999;

        public static void Main(string[] args) {
            int randSizeArray = new Random().Next(5, 10);

            int[] array = GetArrayWithRandomValue(randSizeArray);

            System.Console.WriteLine("Оригинальный массив:");
            System.Console.WriteLine(PrintArray(array));

            System.Console.WriteLine("Количество чётных элементов массива:");
            System.Console.WriteLine(GetCountEvenValue(array));;
        }

        public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static int GetCountEvenValue(int[] array) {
            int count = 0;
            foreach(int item in array) {
                if(item % 2 == 0) count++;
            }
            return count;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + " ";
            }
            return result;
        }
    }
}