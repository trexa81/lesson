using System;

namespace lesson
  //lesson3 
{
    class Program
    {
      
            static void Main(string[] args)
            {
            var contacts = new string[5, 2] { { "one", "two" }, { "two", "four" },
             { "three", "two" }, { "four", "two" }, { "five", "two" },};
            for (var i = 0; i < contacts.Length; i++)
            {
                Console.WriteLine(contacts[i,1]); //выводим массив
            }
            var strings = "Hello!";
            var x = strings.ToCharArray(); //стринг в чар
            int n = x.Length;        // длина массива
            int k = n / 2;          // середина массива
            char temp;               // вспомогательный элемент для обмена значениями
            for (int i = 0; i < k; i++)
            {
                temp = x[i];
                x[i] = x[n - i - 1];
                x[n - i - 1] = temp;
            }
            foreach (var i in x)
            {
                Console.Write($"{i}");
            }

            }
        }

    }

