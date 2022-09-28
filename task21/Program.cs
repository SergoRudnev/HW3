﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
double GetDistance( double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    return distance; 
}
double GetNamber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}
double x1 = GetNamber("x1");
double x2 = GetNamber("x2");
double y1 = GetNamber("y1");
double y2 = GetNamber("y2");
double z1 = GetNamber("z1");
double z2 = GetNamber("z2");

Console.WriteLine("Расстояние между точками = " + GetDistance(x1, x2, y1, y2, z1, z2));
