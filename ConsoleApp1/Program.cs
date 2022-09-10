using Microsoft.VisualBasic;
using System.Dynamic;

class Address
{
    private static int _index;
    public int Index
    {
        get
        {
            return _index;
        }
        set
        {
            _index = value;
        }
    }
    private static string _country;
    public string Country
    {
        get
        {
            return _country;
        }
        set
        {
            _country = value;
        }
    }
    private static string _city;
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }
    private static string _street;
    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            _street = value;
        }
    }
    private static int _house;
    public int House
    {
        get
        {
            return _house;
        }
        set
        {
            _house = value;
        }
    }
    private static int _apartment;
    public int Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            _apartment = value;
        }
    }

    public void Print()
    {
        Console.WriteLine(
            Index + " " + 
            Country + " " + 
            City + " " + 
            Street + " " + 
            House + " " + 
            Apartment
        );
    }
}

class Converter
{
    public Converter(double usd, double eur, double rub)
    {
        _usd = usd;
        _eur = eur;
        _rub = rub;
    }
    private double _usd = 1;
    private double _eur = 1;
    private double _rub = 1;

    public void Convert(string currency, string targetCurrency, double value)
    {
        if (currency == "uah")
        {
            switch (targetCurrency)
            {
                case "eur":
                    Print(value / _eur);
                    break;
                case "usd":
                    Print(value / _usd);
                    break;
                case "rub":
                    Print(value / _rub);
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (currency)
            {
                case "eur":
                    Print(value * _eur);
                    break;
                case "usd":
                    Print(value * _usd);
                    break;
                case "rub":
                    Print(value * _rub);
                    break;
                default:
                    break;
            }
        }
    }

    public void Print(double value)
    {
        Console.WriteLine(value.ToString());
    }
}

class Employee
{
    public Employee(string name, string lastname)
    {
        _name = name;
        _lastname = lastname;

    }
    private string _name = "";
    private string _lastname = "";
    private double _tax = 0.2;

    public void getFee(double experience)
    {
        if (experience < 2)
        {
            Print(1000 * experience, "junior");
        }
        if (experience >= 2 && experience < 4)
        {
            Print(1200 * experience, "middle");
        }
        else
        {
            Print(1500 * experience, "senior");
        }
    }

    private void Print(double value, string position)
    {
        Console.WriteLine(_name + " " + _lastname + " " + position); 
        Console.WriteLine("amount without taxes: " + value);
        double taxesAmount = value * _tax;
        Console.WriteLine("taxes amount: " + taxesAmount);
        Console.WriteLine("final aamount: " + (value - taxesAmount));
    }


}

class User
{
    public User(string login, string name, string lastname, int age)
    {
        _login = login;
        _name = name;
        _lastname = lastname;
        _age = age;
        _date = DateAndTime.DateString;
    }
    private string _login = "";
    private string _name = "";
    private string _lastname = "";
    private double _age = 0;
    private string _date = "";

    public void Print()
    {
        Console.WriteLine("user: " + _login);
        Console.WriteLine("name: " + _name);
        Console.WriteLine("lastname: " + _lastname);
        Console.WriteLine("age: " + _age);
        Console.WriteLine("Accont created at: " + _date);
    }
}
class Program
{
    static void Main(string[] args)
    {
        void StartAddress()
        {
            Address myAddress = new Address();
            
            Console.WriteLine("index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("country: ");
            string country = Console.ReadLine();
            Console.WriteLine("city: ");
            string city = Console.ReadLine();
            Console.WriteLine("street: ");
            string street = Console.ReadLine();
            Console.WriteLine("house: ");
            int house = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("apartments: ");
            int apartment = Convert.ToInt32(Console.ReadLine());

            myAddress.Index = index;
            myAddress.Country = country;
            myAddress.City = city;
            myAddress.Street = street;
            myAddress.House = house;
            myAddress.Apartment = apartment;
            myAddress.Print();
            Console.ReadLine();
        }
        void StartConverter()
        {
            Console.WriteLine("Type your currency: (uah/eur/usd/rub)");
            string cur = Console.ReadLine();
            Console.WriteLine("Type your target currency: (uah/eur/usd/rub)");
            string targetCur = Console.ReadLine();
            Console.WriteLine("Input amount of " + cur + ": ");
            double val = Double.Parse(Console.ReadLine());

            Converter myConverter = new Converter(37.1, 36.8, 0.5);
            myConverter.Convert(cur, targetCur, val);
        }
        void StartEmployee()
        {
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Your experience: ");
            double experience = Double.Parse(Console.ReadLine());

            Employee myEmployee = new Employee(name, lastname);
            myEmployee.getFee(experience);
        }
        void StartUser()
        {
            Console.WriteLine("Your login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            User myUser = new User(login, name, lastname, age);
            myUser.Print();
        }

        // StartAddress();
        // StartConverter();
        // StartEmployee();
        StartUser();
    }
}
