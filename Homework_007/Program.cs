// Удалить вторую цифру трёхзначного числа
Console.Write("Случайное трёхзначное число: ");
int number = new Random().Next(99,1000);
Console.WriteLine(number);
int number2 = (number%1000 - number%100)/10 + number%10;
Console.WriteLine("Число, если удалить вторую цифру трёхзначного числа: " + number2);


