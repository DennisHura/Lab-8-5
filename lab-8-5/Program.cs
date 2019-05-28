using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace prog_4s_l8_5
{
    class Program
    {
        static void Main(string[] args)
        {//1
            Random rand = new Random();
            ArrayList list = new ArrayList();
            for (int i = 0; i < 2300; i++)
            {
                list.Add(rand.Next(100, 500));
            }
            Console.WriteLine("Несортированый список");
            foreach (int i in list) Console.WriteLine(i);
            //2
            list.Sort();
            //3
            Console.WriteLine("\n\n\n\nОтсортированый список с внесенным номером варианта на соответствующей позиции");
            list.Insert(2, 3);
            foreach (int i in list) Console.WriteLine(i);
            //4

            int a = rand.Next(0, 1000);
            //5
            Console.WriteLine("Рандомное число: " + a);
            if (list.Contains(a))
                Console.WriteLine("index = " + list.IndexOf(a));
            else Console.WriteLine("Такого числа нет в списке");
            //6
            int b = rand.Next(0, 1990);
            list.Remove(b);
            //7
            list.Clear();

        }
    }
}
