<<<<<<< HEAD
﻿//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сейчас проверим, является ли оно палиндромом");

        if (n > 99999)
        {
            Console.WriteLine("Неправильное число");
        }
        else
        {
            int a1 = n % 10;
            int a2 = n / 10 % 10;
            int a3 = n / 100 % 10;
            int a4 = n / 1000 % 10;
            int a5 = n / 10000;
            int pal = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

            if (pal == n)
            {
                Console.Write(n);
                Console.WriteLine(" Является палиндромом");
            }

            else
            {
                Console.Write(n);
                Console.WriteLine(" Не является палиндромом");
            }
        }
        
    }
=======
﻿//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сейчас проверим, является ли оно палиндромом");

        if (n > 99999)
        {
            Console.WriteLine("Неправильное число");
        }
        else
        {
            int a1 = n % 10;
            int a2 = n / 10 % 10;
            int a3 = n / 100 % 10;
            int a4 = n / 1000 % 10;
            int a5 = n / 10000;
            int pal = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;

            if (pal == n)
            {
                Console.Write(n);
                Console.WriteLine(" Является палиндромом");
            }

            else
            {
                Console.Write(n);
                Console.WriteLine(" Не является палиндромом");
            }
        }
        
    }
>>>>>>> 0a7e6acc1e4ebc40cd41bf3c0adfc30777e608aa
}