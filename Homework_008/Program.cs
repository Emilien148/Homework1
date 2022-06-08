// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число :");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число :");
int number2 = int.Parse(Console.ReadLine());
if (number1%number2==0)
{
    Console.Write("Первое число кратно второму");
}
else if (number1%number2!=0)
{
    Console.Write("Первое число не кратно второму. Остаток составляет: " + number1%number2);
}