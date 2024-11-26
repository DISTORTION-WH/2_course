using System;

namespace lab2._1.classes
{
    public class Organization
    {
        private int _id;
        private string _name;
        private string _shortName;
        private string _address;
        private DateTime _timeStamp;

        public int Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public string ShortName
        {
            get { return _shortName; }
            protected set { _shortName = value; }
        }

        public string Address
        {
            get { return _address; }
            protected set { _address = value; }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            protected set { _timeStamp = value; }
        }

        public Organization()
        {
            this.Id = GenerateRandomId();
        }

        public Organization(Organization organization)
        {
            this.Id = organization.Id;
            this.Address = organization.Address;
            this.Name = organization.Name;
            this.ShortName = organization.ShortName;
            this.Address = organization.Address;
            this.TimeStamp = organization.TimeStamp;
        }

        public Organization(string name, string shortName, string address)
        {
            this.Id = GenerateRandomId();
            Name = name;
            ShortName = shortName;
            Address = address;
            TimeStamp = DateTime.Now;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.ShortName);
            Console.WriteLine(this.Address);
            Console.WriteLine(this.TimeStamp);
        }

        private int GenerateRandomId()
        {
            Random random = new Random();
            return random.Next(1000000, 9999999);
        }
    }
}
