// Задача 2
Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Max number is: {a}");
}
else if (a < b)
{
    Console.WriteLine($"Max number is: {b}");
} else 
{
    Console.WriteLine("Numbers are equal");
}
// Задача 4
Console.Write("Enter the 1st number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 2nd number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the 3rd number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"Max number is: {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"Max number is: {n2}");
} 
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"Max number is: {n3}");
}
else
{
    Console.WriteLine("Numbers are equal");
}
// Задача 5
Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());


int count = -n;

while (count <+ n)
{
    Console.Write(count + " ");
    count++;
}
// Задача 6
Console.Write("Please, enter the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} is even");
}
else 
{
    Console.WriteLine($"{num} is odd");
}
// Задача 7
Console.Write("Enter 3 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;
int result = 0;

if (length == 3)
{
    result = number % 10;
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Please enter 3 digit number!!!");
// Задача 8
Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (n >= count)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
