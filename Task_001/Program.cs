// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


Console.Clear();

Console.WriteLine("Введите Ваше пятизначное число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Проверка числа {num} на полиндромность:");

int rem = num / 1000;
int rem1 = num % 100;
int rem2 = (rem1 % 10) * 10 + (rem1 / 10);

if (rem == rem2)
    Console.WriteLine($"Число {num} полиндромно.");
else
    Console.WriteLine($"Число {num} не полиндромно.");

