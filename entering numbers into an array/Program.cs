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
            int[] array = new int[0];
            bool isExit = false;
            int sum = 0;
            string command;

            while(isExit == false)
            {
                Console.Write("Введите команду (sum, exit) или число: ");
                command = Console.ReadLine();

                switch (command)
                {
                    case CommandExit:
                        isExit = true;
                        Console.WriteLine("Программа завершена");
                        break;
                    case CommandSum:
                        for (int i = 0; i < array.Length; i++)
                        {
                            sum += array[i];
                        }

                        Console.WriteLine(sum);
                        break;
                    default:
                        int[] tempArray = new int[array.Length + 1];

                        for(int i = 0; i < array.Length; i++)
                        {
                            tempArray[i] = array[i];
                        }

                        tempArray[tempArray.Length - 1] = Convert.ToInt32(command);

                        array = tempArray;
                        break;
                }
            }
        }
    }
}
