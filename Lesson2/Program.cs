// See https://aka.ms/new-console-template for more information
#region Task
/*Random random = new Random();
int[] massive = new int[20];
int[] uniq = new int[21];
int countOne=0, countTwo=0;
int countUniq=0;
for(int i=0;i<massive.Length;i++)
{
    massive[i] = random.Next(20);
}
for(int i=0;i<massive.Length;i++)
{
    if(massive[i] % 2 == 0||massive[i]==0) { countOne++; }
    else { countTwo++; }
    Console.WriteLine(massive[i]);
    
}
for(int i=0;i<=20;i++)
{
    foreach (int j in massive)
    {
        if(i==j)
        {
            countUniq++;
            if(countUniq>1)
            {
                countUniq = 0;
                uniq[i] = 0;
                break;
            }
            else
            {
                uniq[i] = 1;
            }
        }
    }
}
Console.WriteLine("Количество четных элементов: {0}", countOne);
Console.WriteLine("Количество нечетных элементов: {0} ",countTwo);
for(int i = 0; i <= 20; i++)
{
    if (uniq[i] == 1) 
    {
        Console.WriteLine(i.ToString());
    }
}*/
#endregion Task

#region TaskOne
/*Random random = new Random();
int[] massive = new int[100];
int counter = 0;
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = random.Next(20);
}
Console.WriteLine("Введите число от 0 до 1000. Будут показаны все элементы меньше вашего числа");
try
{
    string number = Console.ReadLine();
    int z = Int32.Parse(number);
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < z || massive[i] == 0)
        {
            counter++;
            Console.WriteLine(massive[i]);
        }
    }
    Console.WriteLine("Чисел меньше{0} найдено {1} штук", z, counter);
}
catch (Exception)
{
    Console.WriteLine("Только числа!");
}*/
#endregion TaskOne

#region TaskTwo
/*using System.Text;

int[] massive = new int[12] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
int counter = 0;
string searchText;
string numbersText = "";
StringBuilder sb = new StringBuilder();

for(int i=0;i<massive.Length;i++)
{
    sb.Append(massive[i]);
}
numbersText = sb.ToString();
Console.WriteLine("Массив для поиска числового вхождения: \n" + numbersText);
searchText = Console.ReadLine();
for(int i=0;i<=numbersText.Length;i++)
{
    if(numbersText.Contains(searchText))
{
    int indexContain = numbersText.IndexOf(searchText);
    counter++;
    numbersText =numbersText.Remove(0, indexContain + 1);
        
}
else
{
    Console.WriteLine("искомой подстроки не обнаружено");
        break;
}

}
Console.WriteLine("искомая подстрока найдена {0} раз(a)",counter);
*/
#endregion TaskTwo

#region TaskTree

/*int start, end;
start = Int32.Parse(Console.ReadLine());
end = Int32.Parse(Console.ReadLine());
Console.WriteLine(MyClass.MyMethod(start,end ));
Console.ReadLine();
class MyClass
{
    public static int MyMethod(int start, int end)
    {
        int result=1;
        for(int i=start;i<=end;i++)
        {
            result *= i;
        }
        return result;
    }
}*/
#endregion TaskTree

#region TaskFour

/*int firstFib = 0, secondFib = 1;
Fibonacci(firstFib, secondFib, Int32.Parse(Console.ReadLine()));
static void Fibonacci(int a, int b, int endnumber)
{
    int result = a + b;
    if (result != endnumber && result < endnumber)
    {
        Fibonacci(b, result, endnumber);

    }
    else if (result == endnumber)
    {
        Console.WriteLine("Это число Фиббоначчи");
        Console.WriteLine("Число простое: {0} ", Simple(result));
    }
    else
    {
        Console.WriteLine("Это число не Фиббоначчи");
        Console.WriteLine("Число простое: {0} ", Simple(result));
    }
}
static bool Simple(int a)
{
    if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0 || a % 9 == 0)
    {
        return false;

    }
    else
    {
        return true;
    }
}*/
#endregion TaskFour

#region Task Five
/*
Plane pl = new Plane("Лебедь");
Plane pl2 = new Plane("Рак",2010);
Plane pl3 = new Plane("Щука",2010,"Победа","Грузовой");
Console.WriteLine(pl.NameAndType());
Console.WriteLine(pl.NameAndType(true));
Console.WriteLine(pl.NameAndType(false));
Console.WriteLine(pl2.NameAndType());
Console.WriteLine(pl2.NameAndType(true));
Console.WriteLine(pl2.NameAndType(false));
Console.WriteLine(pl3.NameAndType());
Console.WriteLine(pl3.NameAndType(true));
Console.WriteLine(pl3.NameAndType(false));

class Plane
{
    public string _name { get; set; }
    public string _manufacture { get; set; }
    public int _year { get; set; }
    public string _type { get; set; }
    public Plane(string name)
    {
        _name = name;
        _manufacture = "Аэрофлот";
        _year = 2005;
        _type = "Пассажирский";
    }
    public Plane(string name,int year)
    {
        _name = name;
        _manufacture = "Аэрофлот";
        _year = year;
        _type = "Пассажирский";
    }
    public Plane(string name,int year,string manufacture,string type)
    {
        _name = name;
        _manufacture = "Аэрофлот";
        _year = year;
        _type = type;
    }
    public string NameAndType()
    {
        return this._name+this._type;
    }
    public string NameAndType(bool manufacture)
    {
        if (manufacture)
        { return this._name + this._type + this._manufacture; }
        else { return this._name + this._type; }
    }

}*/

#endregion Task Five

#region Task Six
/*
using AIGuess;
Console.WriteLine("Введите число в диапазоне от 0 до 100");
int userNumber;
Random r = new Random();
RamdomNumberAndHisBool rnahb = new RamdomNumberAndHisBool();
do
{
    do { Console.WriteLine("Введите число в диапазоне от 0 до 100"); userNumber = Int32.Parse(Console.ReadLine());}
    while (userNumber < 0 || userNumber > 100);
    rnahb = AIGuess.Guess.SimpleGuess(0, 100, r, userNumber, rnahb); 
    Console.WriteLine("Число совпали с числом{0}?{1}", rnahb.RandomNumber, rnahb.HisBool.ToString());
    Console.WriteLine("Хотя с {0} попытки комп справился!", Guess.EndlessnessGuess(0, 100, r, userNumber));
        if (rnahb.HisBool) break;
    Console.WriteLine("Нажмите Y для новой попытки. Любую клавишу для отмены.");
}
while (Console.ReadLine() == ConsoleKey.Y.ToString());
namespace AIGuess
{
    internal class Guess
    {
        public static RamdomNumberAndHisBool SimpleGuess(int min, int max, Random r, int userNumber, RamdomNumberAndHisBool rnahb)
        {
            rnahb.RandomNumber = r.Next(min, max);
            rnahb.HisBool = (bool)(rnahb.RandomNumber == userNumber);
            return rnahb;
        }
        public static int EndlessnessGuess(int min, int max,Random r, int userNumber)
        {
            int buf = -1;
            int count = 0;
            while(buf!=userNumber)
            {
                buf = r.Next(min, max);
                count++;
            }
            return count;
        }
    }
    internal class RamdomNumberAndHisBool
    {
        public int RandomNumber { get; set; } = 0;
        public bool HisBool { get; set; } = false;
    }
}
*/
#endregion Task Six

#region Task Seven
/*using Morse;
using System.Text;

string startText;
Console.WriteLine("Введите текст для перевода в азбуку Морзе");
startText = Console.ReadLine();
startText = ConvertToMorse.TextToMorse(startText);
Console.WriteLine("Ваш текст в виде азбуки Морзе" + startText);

namespace Morse
{
    class ConvertToMorse
    {
        public static string TextToMorse(string alphaText)
        {
            char[] chars = alphaText.ToLower().ToCharArray();
            string[] massiveMorseng = new string[] { "*-", "-***", "*--", "--*", "-**" };
            string[] massiveAlphabet = new string[] { "а", "б", "в", "г", "д" };
            string betaText;
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                foreach (string str in massiveAlphabet)
                {
                    
                    if (chars[i] == str[0])
                    {
                        sb.Append(massiveMorseng[count]);
                    }
                    count++;
                }
                count = 0;
            }
            return betaText = sb.ToString();

        }


        static string MorseToText()
        {
            return "";
        }

    }

}*/

#endregion Task Seven

int size = 5;
int[] A = new int[size];
//int i = 0;
for (int i = 0; i < size; i++)//Ввод
{
    Console.WriteLine("Введите элементы массива: ");
    //A[i] = int.Parse(Console.ReadLine());
    //Console.WriteLine();
    //i++;
    A[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < size; i++)//Вывод
{
    Console.WriteLine("{0}", A[i].ToString());
}