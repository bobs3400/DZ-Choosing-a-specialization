Console.Clear();
Console.WriteLine("Введите длину массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите члены массива");
string[] mass = new string[n];
int i = 0;
while (i < n)
{
       Console.Write($"Введите {i+1} член массива ");
       mass[i] = Console.ReadLine();
       i = i + 1;
}
string[] array = new string[n];
int j = 0;
for(i = 0; i < n; i ++)
{
    if (mass[i].Length <= 3)
    {   
        array[j] = mass[i];
        Console.Write(array[j] + ", ");
        j++;
    }
}