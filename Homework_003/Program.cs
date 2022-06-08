// Выяснить является ли число чётным
Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
if (number%2==0)
{
    Console.Write("Число является четным!");
}
else 
{
    Console.Write("Число не является четным!");
}