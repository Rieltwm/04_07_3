﻿// See https://aka.ms/new-console-template for more information
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Решение задачи 19 ");

int num,a,sum=0,t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
a=num % 10;
sum=sum*10+a;
}
if(t==sum)
Console.WriteLine($"{t} является палиндромом.");
else
Console.WriteLine($"{t} не является палиндромом.");
} else
Console.WriteLine("Введите правильное число: ");