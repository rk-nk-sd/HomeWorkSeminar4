using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

namespace Task_003
{
    public class Task_003
    {
        public const int MIN = 1;
        public const int MAX = 9;

        public static void Main(string[] args) {
            int randSizeArray = new Random().Next(5, 10);

            int[] array = GetArrayWithRandomValue(randSizeArray);

            System.Console.WriteLine("Оригинальный массив:");
            System.Console.WriteLine(PrintArray(array));

            System.Console.WriteLine("Перевернутый массив:");
            System.Console.WriteLine(PrintArray(ReversItemInArray(array)));

        }

         public static int[] GetArrayWithRandomValue(int size) {
            int[] array = new int[size];
            for(int i = 0; i < size; i++) {
                array[i] = new Random().Next(MIN, MAX);
            }
            return array;
        }

        public static string PrintArray(int[] array) {
            string result = "";
            foreach(int item in array) {
                result = result + item + " ";
            }
            return result;
        }

        public static int[] ReversItemInArray(int[] array) {
            int temp = 0;
            for(int i = 0; i < (int) array.Length / 2; i++) {
                temp = array[i];
                array[i] = array[array.Length-1 - i];
                array[array.Length-1 - i] = temp;
            }
            return array;
        }
    }
}