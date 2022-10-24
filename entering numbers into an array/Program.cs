using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entering_numbers_into_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "sum";
            List<int> numbers = new List<int>();
            bool isExit = false;
            string command;

            while(isExit == false)
            {
                Console.Write("Введите команду (" + CommandSum + ", " + CommandExit + ") или число: ");
                command = Console.ReadLine();

                switch (command)
                {
                    case CommandExit:
                        isExit = true;
                        
                        break;
                    case CommandSum:
                        Console.Write($"Ccума всех чисел: {sumNumbers(numbers)}\n");
                        break;
                    default:
                        if(int.TryParse(command, out int number))
                        {
                            numbers.Add(number);
                        }
                        else
                        {
                            Console.WriteLine("Некоректный ввод");
                        }
                        break;
                }
            }

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }

        static int sumNumbers(List<int> numbers)
        {
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
