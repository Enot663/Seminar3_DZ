// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();

int DataEntry(string str)
{
   Console.Write(str);
   int number = int.Parse(Console.ReadLine());
   return number;
}

double CalcDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
   double result = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);
   return result;
   
}

int x1 = DataEntry("Введите координаты x1 = ");
int y1 = DataEntry("Введите координаты y1 = ");
int z1 = DataEntry("Введите координаты z1 = ");
int x2 = DataEntry("Введите координаты x2 = ");
int y2 = DataEntry("Введите координаты y2 = ");
int z2 = DataEntry("Введите координаты z2 = ");

double result = Math.Sqrt(CalcDistance(x1, y1, x2, y2, z1, z2));
double itog = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками = {itog}");


