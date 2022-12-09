// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int n;
Console.Write($"Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out n);

 string str = n.ToString();

 if (str[0] == str[4] && str[1] == str[3])
 {
    Console.Write($"Число является палиндромом\n");
 }
 else 
 {
    Console.Write($"Число не является палиндромом\n");
 }