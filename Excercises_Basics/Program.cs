namespace Excercises_Basics;

using System;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int ProductionDate { get; set; }

    public Car(string brand, string model, int productionDate)
    {
        Brand = brand;
        Model = model;
        ProductionDate = productionDate;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Production date: {ProductionDate}");
    }
}

public class Student
{
    public string Name { get; private set; }

    private int _grade;

    public int Grade
    {
        get { return _grade; }
        set { if (value >= 1 && value <= 6) { _grade = value; } }
    }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public bool IsPassing()
    {
        return Grade >= 2;
    }
}

public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Pages { get; private set; }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public Book() : this("Cursed book", "Anonim", 2137) { }

    public string GetSummary()
    {
        return $"{Title} by {Author}, pages: {Pages}";
    }
}

public class BankAccount
{
    public string OwnerName { get; private set; }
    private double _balance;

    public BankAccount(string ownerName)
    {
        OwnerName = ownerName;
        _balance = 0;
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance: {_balance}");
    }
}

public class Food
{
    public string TypeName { get; private set; }

    public Food(string typeName)
    {
        TypeName = typeName;
    }

    public int ChangeIntoEnergy()
    {
        Random rand = new Random();
        int energy = rand.Next(6, 11); 
        return energy;
    }
}

public class Dog
{
    public string Name { get; private set; }
    public int EnergyLvl { get; private set; }

    public Dog(string name)
    {
        Name = name;
        EnergyLvl = 0;
    }

    public void Eat(object food)
    {
        if (food is Food)
        {
            Food foodItem = (Food)food;
            EnergyLvl += foodItem.ChangeIntoEnergy();
        }
        else
        {
            Console.WriteLine("This is not food!");
        }
    }
}
