// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1 =");
double b_1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1 =");
double k_1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2 =");
double b_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2 =");
double k_2 = Convert.ToDouble(Console.ReadLine());
double coor_x = PointIntersectionTwoLines_X(b_1, k_1, b_2, k_2);
double coor_y = PointIntersectionTwoLines_Y(coor_x, b_1, k_1);


Console.WriteLine($"Точка пересечения двух прямых с координатами X: {coor_x}, Y: {coor_y}");

double PointIntersectionTwoLines_X(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;

}
double PointIntersectionTwoLines_Y(double x, double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}