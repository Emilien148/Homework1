// Показать последнюю цифру трёхзначного числа
Console.Write("Случайоное трёхзначное число :");
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int result = number%100;
Console.WriteLine("Последняя цифра трехзначного числа: " + number%10);