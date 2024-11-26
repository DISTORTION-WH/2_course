using App2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    class Class1
    {
        static void Main(string[] args)
        {
            House[] houses = new House[5];
            houses[0] = new House(1, 3, 30, 3, "st.Lenin", 1, "skyscraper", 2010);
            houses[1] = new House();
            houses[2] = new House(3, 2, 20, 2, "st.Lenin", 1, "skyscraper", 2000);
            houses[3] = new House(4, 30, 3, "st.Lenin", 2, "skyscraper", 2005);
            houses[4] = new House(5, 34, 10, 1, "st.Lenin", 3, "skyscraper", 2020);

            int t = houses[0].Lifetime;
            int res = houses[1].Time(ref t);
            Console.WriteLine("Возраст здания" + ' ' + res);
            if (res > 15)
            {
                Console.WriteLine("Нуждается в кап. ремонте");
            }
            else
            {
                Console.WriteLine("Не нуждается в кап. ремонте");
            }

            int f;
            Console.WriteLine("Поиск квартир по количесву комнат. Введите количество комнат:");
            f = Convert.ToInt32(Console.ReadLine());
            foreach (House house1 in houses)
            {
                if (house1.NumberOfRooms == f)
                    house1.ToString();
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }

            int floor, amount;
            Console.WriteLine("Поиск квартир по количесву комнат. Введите количество комнат: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите этаж: ");
            floor = Convert.ToInt32(Console.ReadLine());

            foreach (House house1 in houses)
            {
                if (house1.NumberOfRooms == amount && house1.Floor == floor)
                {
                    house1.ToString();
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                }
            }

        }
    }
}