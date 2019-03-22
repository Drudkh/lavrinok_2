using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 7. Implement function that takes array of numbers as parameter and returns array of Objects which has 1 property, 
//and one method.Property is Number from array, Method is function that returns True if number is odd and False if even.

namespace ConsoleApp1
{
    public class MyClass
    {
        public int Number { get; set; }

        public bool Check() {
            return Number % 2 == 0;
        }
    }

    class Program
    {
        public static MyClass[] LetsCheckIt(int[] input_arr)
        {
            MyClass[] result = new MyClass[input_arr.Length];

            for (int i = 0; i < input_arr.Length; i++)
            {
                result[i] = new MyClass();
                result[i].Number = input_arr[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] input_arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            MyClass[] mas_obj = LetsCheckIt(input_arr);
            for (int i = 0; i < input_arr.Length; i++)
            {
                Console.WriteLine(i + "-е слово в массиве - " + input_arr[i]);
                Console.WriteLine(i + "-й объект, что имеет свойство: <<" + mas_obj[i].Number + ">> - и метод возвращает: " + mas_obj[i].Check());
            }
            Console.ReadKey();
        }
    }
}
