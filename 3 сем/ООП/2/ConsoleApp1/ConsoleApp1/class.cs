using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App2
{
    partial class House
    {
        private readonly int id;
        private int numberOfFlat;
        private int square;
        private int amountOfRooms;
        private string street;
        private int floor;
        private string typeOfBulding;
        private int lifetime;
        public static int count = 0;

        public int Id
        {
            get { return id; }
        }

        public int NumberOfFlat
        {
            get { return numberOfFlat; }
            set
            {
                numberOfFlat = value;
            }
        }
        public int NumberOfRooms
        {
            get { return amountOfRooms; }
            set { amountOfRooms = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public string TypeOfBulding
        {
            get { return typeOfBulding; }
            set { typeOfBulding = value; }
        }

        public int Lifetime
        {
            get { return lifetime; }
            set { lifetime = value; }
        }
        public House()
        {
            int id = 1;
            int numberOfFlat = 1;
            int square = 20;
            int amountOfRooms = 2;
            string street = "st.Pushkin";
            int floor = 1;
            string typeOfBulding = "skyscraper";
            int lifetime = 2015;
        }
        public House(int id, int numberOfFlat, int square, int amountOfRooms, string street, int floor, string typeOfBulding, int lifetime)
        {
            this.id = id;
            this.numberOfFlat = numberOfFlat;
            this.square = square;
            this.amountOfRooms = amountOfRooms;
            this.street = street;
            this.floor = floor;
            this.typeOfBulding = typeOfBulding;
            this.lifetime = lifetime;
        }

        public House(int id = 3, int square = 30, int amountOfRooms = 4, string street = "st.Lenin", int floor = 3, string typeOfBulding = "skyscraper", int lifetime = 5)
        {
            this.id = id;
            numberOfFlat = 13;
            this.square = square;
            this.amountOfRooms = amountOfRooms;
            this.street = street;
            this.floor = floor;
            this.typeOfBulding = typeOfBulding;
            this.lifetime = lifetime;
        }

        public override int GetHashCode()
        {
            var hash = 0;
            foreach (char temp in street)
            {
                hash += Convert.ToInt32(temp);
            }
            return Convert.ToInt32(hash);
        }

        static House() { count = 0; }

        public const string city = "Minsk   ";

        public string ToString()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Площадь " + square);
            Console.WriteLine("Количество комнат " + amountOfRooms);
            Console.WriteLine("Улица " + street);
            Console.WriteLine("Этаж " + floor);
            Console.WriteLine("Тип здания " + typeOfBulding);
            Console.WriteLine("Срок эксплуатации " + lifetime);
            Console.WriteLine("Город: " + city);
            return city;
        }
        public int Time(ref int time)
        {
            int result = 2023 - time;
            return result;
        }
    }
}