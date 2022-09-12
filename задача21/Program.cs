// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты точки А: x1 y1 z1: ");
string point_A = Console.ReadLine()!;
string[] parts_A = point_A.Split(' ');
int x1 = int.Parse(parts_A[0]);
int y1 = int.Parse(parts_A[1]);
int z1 = int.Parse(parts_A[2]);

Console.Write("Введите координаты точка В: x2 y2 z2: ");
string point2 = Console.ReadLine()!;
string[] parts_B = point2.Split(' ');
int x2 = int.Parse(parts_B[0]);
int y2 = int.Parse(parts_B[1]);
int z2 = int.Parse(parts_B[2]);


double length_AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {length_AB:F2}");
