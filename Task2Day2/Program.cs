// See https://aka.ms/new-console-template for more informa
#region TaskOne
Random random = new Random();
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
    for(int i=0;i<massive.Length;i++)
    {
        if(massive[i]<z||massive[i]==0)
        {
            counter++;
            Console.WriteLine(massive[i]);
        }
    }
    Console.WriteLine("Чисел меньше{0} найдено {1} штук", z, counter);
}
catch(Exception)
{
    Console.WriteLine("Только числа!");
}
#endregion TaskOne