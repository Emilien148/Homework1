// Найти максимальное из трех чисел
Console.WriteLine("Введите первое число :");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число :");
int number3 = int.Parse(Console.ReadLine());
if (number1>=number2)
if (number1>=number3)
{
    Console.Write("Первое число является максимальным, либо равным максимальному!");
}
if (number2>=number1)
if (number2>=number3)
{
    Console.Write("Второе число является максимальным, либо равным максимальному!");
}
else 
{
    Console.Write("Третье число является максимальным, либо равным максимальному!");
}