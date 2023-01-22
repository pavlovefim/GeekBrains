// Задача 19
Console.Write("Enter the 5 digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

int n0 = n / 10000;
int n1 = n / 1000 % 10;
int n2 = n / 100 % 10;
int n3 = n / 10 % 10;
int n4 = n % 10;

if (n0 == n4 && n1 == n3) 
{
    Console.WriteLine($"Number '{n}' is Palindrome");
}
else 
{
    Console.WriteLine($"Number '{n}' is NOT Palindrome");
}
Footer
// Задача 21
Console.WriteLine("Enter coordinates for point A, ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates for point B, ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double DistanceIn3D(int x1_m, int y1_m, int z1_m, int x2_m, int y2_m, int z2_m)
{
    return Math.Sqrt((x2_m - x1_m) * (x2_m - x1_m) +
    (y2_m - y1_m) * (y2_m - y1_m) + (z2_m - z1_m) * (z2_m - z1_m));
}

double result = DistanceIn3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance between two points is {Math.Round(result, 2)}");
// Задача 23
Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} -> {i*i*i}");
}