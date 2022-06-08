// Показать вторую цифру трёхзначного числа
Console.WriteLine("Случайное трёхзначное число");
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int result = (number%100 - number%10)/10;
Console.WriteLine("Вторая цифра трёхзначного числа : " + result);