//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double CalcDistanceTwoPoints()
{
double  x1, x2, aX,
        y1, y2, aY,
        z1, z2, aZ;
        
Console.WriteLine("Введите координаты точки А: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    y1 = Convert.ToDouble(Console.ReadLine());
    z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки Б: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    y2 = Convert.ToDouble(Console.ReadLine());
    z2 = Convert.ToDouble(Console.ReadLine());

// Расчет квадратов разности 
aX = Math.Pow(x2-x1,2);
aY = Math.Pow(y2-y1,2);
aZ = Math.Pow(z2-z1,2);

//Извлечение корня из суммы квадратов разности 
double result = Math.Sqrt(aX + aY + aZ);
return result;
}

double result = CalcDistanceTwoPoints();
Console.WriteLine($"Расстояние между точками А и Б = {result}");

