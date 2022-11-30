using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 6. Запишите любое число от 1 до 1000, введенное пользователем, 
    русскими буквами. Например, 2 – два, 150 – сто пятьдесят. */

namespace Lab_3_2_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] dozens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] doz_10_20 = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            
            for (int i = 0; i < 1000; i++)
            {
                int number = i % 10;
                int dozen = i / 10 % 10;                
                int hundred = i / 100 % 10;
                Console.Write(hundreds[hundred] + (hundreds[hundred] == "" ? "" : " "));
                if (dozen == 1)
                    Console.Write(doz_10_20[number] + " ");
                else
                {
                    Console.Write(dozens[dozen] + (dozens[dozen] == "" ? "" : " "));
                    Console.Write(numbers[number]);
                }                    
                Console.WriteLine();
            }
            Console.ReadKey();
        }        
    }
}
