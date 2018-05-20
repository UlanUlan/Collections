using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*1.	Создать коллекцию List <int> . Вывести на экран позицию и значение элемента,
        являющегося вторым максимальным значением в коллекции. Вывести на экран сумму элементов на четных позициях.
        2.	Удалить все нечетные элементы списка List<int> */
            List<int> dc = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                dc.Add(i = r.Next(1, 20));

            }

            dc = dc.OrderBy(o => o).ToList();
            Console.WriteLine(dc[dc.Count - 1]);

            int summ = 0;
            for (int i = 0; i < dc.Count; i += 2)
            {
                Console.WriteLine("Element " + dc[i]);
                summ += dc[i];
                dc.Remove(i); // 2
            }

            Console.WriteLine("Sum" + summ);
            #endregion
            Console.WriteLine("-------------------------------------------------------------");
            #region 3
            // 3.	Дана коллекция типа List<double>. Вывести на экран элементы списка, значение которых больше среднего арифметического всех элементов коллекции.
            List<int> gq = new List<int>();
            double AvgTask3 = 0;
            Random ra = new Random();

            for (int i = 0; i < 10; i++)
            {
                gq.Add(i = ra.Next(1, 100));
            }

            AvgTask3 = gq.Sum(o => o) / gq.Count;
            Console.WriteLine("sum" + AvgTask3);

            foreach (var item in gq)
            {
                if (item > AvgTask3)
                    Console.WriteLine(item);
            }

            foreach (var item in gq.Where(o => o > AvgTask3))
            {
                Console.WriteLine("Value" + item);
            }
            #endregion
            Console.WriteLine("-------------------------------------------------------------");
            #region 4
            // 4	Напечатать содержимое текстового файла t, выписывая литеры каждой его строки в обратном порядке.
            Console.WriteLine("-------------------------------------------------------------");
            string str = "hjkjdfhgjkdsfhgjkhdsfgkjfdtiopertert";
            Console.WriteLine(str);

            List<char> xx = str.ToList();

            xx.Reverse();

            foreach (var item in xx)
            {
                Console.Write(item);

            }
            #endregion
            Console.WriteLine("-------------------------------------------------------------");
            #region 5
            //5.	Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            string s1 = "qwerty";
            string s2 = "ytrewq";
            string s3 = "";

            Console.WriteLine(s1);
            foreach (var item in s2.Reverse())
            {
                s3 += item;
            }
            Console.WriteLine(s1);
            Console.WriteLine(s3);
            #endregion
            Console.WriteLine("-------------------------------------------------------------");
            #region 6
            Console.WriteLine();
            /*6.	Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке:
              сначала все слова, начинающиеся на гласную букву, потом все слова, начинающиеся на согласную букву, 
              сохраняя исходный порядок в каждой группе слов.*/
            string text = "be or not to be is a questions";

            List<string> ttt = new List<string>();

            ttt = text.Split(' ').ToList();
            string bookva = "aoieu";
            foreach (var item in ttt)
            {
                if(bookva.Contains(item[0]) )
                    Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in ttt)
            {
                if (!bookva.Contains(item[0]))
                    Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine("-------------------------------------------------------------");
            #region 7
            #endregion
        }

    }
}
