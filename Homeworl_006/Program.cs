// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Случайное двузначное число");
int number = new Random().Next(9, 101); // В квадратных скобках выдавал ошибку
int numberA = (number%100 - number%10) / 10;
int numberB = number%10;
Console.WriteLine(number);
Console.WriteLine("Первая цифра двузначного числа :" + numberA);
Console.WriteLine("Вторая цифра двузначного числа :"+ number%10);
if (numberA>numberB)
{
    Console.Write("Первая цифра двузначного числа больше");
}
else if (numberA<numberB)
{
    Console.Write("Вторая цифра двузначного числа больше");
}
else 
{
    Console.Write("Цифры двузначного числа равны");
}