using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

namespace Task_001
{
    public class Task_001
    {
        public static void Main(string[] args) {

            string inString = GetDataFromConsole();
            
            while(true) {
                if(isExit(inString) || isEvenSumValue(inString)) {
                    System.Console.WriteLine("[STOP]");
                    Environment.Exit(0);
                }
                inString = GetDataFromConsole();
            }
        }

        public static string GetDataFromConsole() {
            System.Console.Write("Введите число: ");
            string? inValue = System.Console.ReadLine();
            if(inValue == null) inValue = "";
            return inValue;
        }

         public static int ConvertStringToNumber(string number) {
            try{
                return Convert.ToInt32(number);
            } catch (Exception)
                {
                System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
            }
            return -1;
        }

        public static bool isExit(string str) {
            if(str.Contains('q')) {
                return true;
            }
            return false;
        }

        public static bool isEvenSumValue (string str) {
            int sum = 0;
            string[] array = str.Split(' ');
            foreach(string item in array) {
                sum += ConvertStringToNumber(item);
            }
            return sum % 2 == 0;
        }


    }
}