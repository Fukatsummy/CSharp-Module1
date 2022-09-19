// See https://aka.ms/new-console-template for more information
Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
//Второй вариант
Console.WriteLine("It's easy to win forgiveness for being wrong;  ");
Console.WriteLine("being right is what gets you into real trouble.");
Console.WriteLine("Bjarne Stroustrup");


int[] massive = new int[5]; //Создание массива на 5 элементов
/*string line = Console.ReadLine();
massive[0] = Int32.Parse(line);*/
//massive[0] = Int32.Parse(Console.ReadLine());
int summary = 0;
int multiply = 1;
int max;
int min;
for(int i=0;i<5;i++)
{
    Console.WriteLine("Введите число для индекса {0} ", i);
    massive[i] = Int32.Parse(Console.ReadLine());
    
}
min = massive[0]; 
max = massive[0];
for(int i=massive.Length-1;i>=0;i--)
{
    summary += massive[i]; //сумма всех элементов
    multiply *= massive[i];//произведение всех элементов
    if (min < massive[i]) { min = massive[i]; }
    if (max > massive[i]) { max = massive[i]; }
}
Console.WriteLine("Сумма: {0}, Произведение:{1}, Min:{2}, Max: {3}", summary, multiply, max,min);

