using System;

namespace lesson
//lesson3 
{
    class Program
    {

        static void Main(string[] args)
        {
            var tel1 = "34651747355237";
            var tel2 = "45375177525237";
            var tel3 = "34551776253557";
            var tel4 = "62545177725237";
            var tel5 = "80375177825227";
            var contacts = new string[5, 2] { { "name one", tel1 }, { "name two", tel2 },
             { "name three", tel3 }, { "name four", tel4 }, { "name five", tel5 }};

            var y = contacts;
            for (var u = 0; u < y.GetLength(0); u++)
            {
                    for (var d = 0; d <= u - 1; d++) //сдвиг столбцев по диагонали
                    {
                        Console.Write("\t");
                    }

                    for (var j = 0; j < y.GetLength(1); j++)
                    {
                        Console.Write($"{y[u, j]}\t");
                    }
                    Console.WriteLine();            //выводим массив

            }
          
            Console.WriteLine("\n\t\t***"); //разделитель упражнений
                                            //***

            var strings = "Hello!";
            var x = strings.ToCharArray(); //стринг в чар
            var n = x.Length;        // длина массива
            var k = n / 2;          // середина массива
            char temp;               // вспомогательный элемент для обмена значениями
            for (var i = 0; i < k; i++)
            {
                temp = x[i];
                x[i] = x[n - i - 1];
                x[n - i - 1] = temp;
            }
            foreach (var i in x)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine("\n\t\t***");
        }
    }
}

