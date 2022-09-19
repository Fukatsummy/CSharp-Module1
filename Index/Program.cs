// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

Worker worker = new Worker("Сергеев Сергей Сергеевич", DateTime.Now, "+7928928928", "sergey@mail.ru", "Охранник", "Бдительность!", 19500);
Console.WriteLine($"Зарплата {worker.FIO} на должности {worker.Job}{worker.Salary}");
worker += 3000;
Console.WriteLine($"Зарплата {worker.FIO} на должности {worker.Job}{worker.Salary}");
worker -= 7000;
Console.WriteLine($"Зарплата {worker.FIO} на должности {worker.Job}{worker.Salary}");
Worker worker1 = new Worker("Сергеев Антон Сергеевич", DateTime.Now, "+7928928928", "sergey@mail.ru", "Менеджер", "Активность!", 25500);
Console.WriteLine($"Зарплата братьев равна {worker==worker1} ");
Console.WriteLine($"Зарплата  братьев не равна {worker!=worker1} ");
Console.WriteLine($"Зарплата Сергея больше Антона {worker>worker1} ");
Console.WriteLine($"Зарплата Сергея меньше Антона {worker<worker1} ");
worker += 10000;
Console.WriteLine($"Зарплата братьев равна {worker == worker1} ");
Console.WriteLine($"Зарплата братьев не равна {worker != worker1} ");
Console.WriteLine($"Зарплата Сергея больше Антона {worker > worker1} ");
Console.WriteLine($"Зарплата Сергея меньше Антона {worker < worker1} ");
Console.WriteLine($"Братья равны {worker.Equals(worker1)}");
Console.WriteLine($"Хэш код 1: {worker.GetHashCode()}" + $"Хэш код 2: {worker1.GetHashCode()}");
class Worker
{
    public string FIO { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Job { get; set; }
    public string JobDescription { get; set; }
    public int Salary {get;set;}

    public Worker(string fio, DateTime dateofbirth, string phone, string email, string job, string jobdescription, int salary)
    {
        FIO = fio;
        DateOfBirth = dateofbirth;
        Phone = phone;
        Email = email;
        Job = job;
        JobDescription = jobdescription;
        Salary = salary;
    }
    public static Worker operator +(Worker a,int b)
    {
        a.Salary += b;
        return a;
    }
    public static int operator +(int b,Worker a)//возвращает сумму с добавленной стоимостью
    {
         return b+ a.Salary;
       
    }
    public static Worker operator -(Worker a, int b)// вычитание из зарплаты
    {
        a.Salary -= b;
        return a;
    }
    public static int operator -(int b, Worker a)//возвращает сумму с  уменьшеной стоимостью
    {
        return b - a.Salary;

    }
    public static bool operator ==(Worker a, Worker b)
    {
       return  a.Salary == b.Salary? true : false;
    } 
    public static bool operator !=(Worker a, Worker b)
    {
        return a.Salary != b.Salary ? true : false;
    }
    public static bool operator >(Worker a, Worker b)
    {
        return a.Salary > b.Salary ? true : false;
    }
    public static bool operator <(Worker a, Worker b)
    {
        return a.Salary < b.Salary ? true : false;
    }
    public override string ToString()
    {
        return FIO + DateOfBirth.ToString() + Phone + Email + Job + JobDescription + Salary.ToString();
    }
    public override bool Equals(Object obj) // сравнивает объекты
    {
            return this.Salary.ToString()==obj.ToString();
    }
    public override int GetHashCode() // Шестнадцатиричное представление текста
    {
            return this.ToString().GetHashCode();
    }
}
class Sity
{

}
class CreditCart
{

}
class Matrix
{

}
