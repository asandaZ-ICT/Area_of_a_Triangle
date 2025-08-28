// See https://aka.ms/new-console-template for more information
Console.Write("Write the height : ");
double height =double.Parse(Console.ReadLine());

Console.Write("Write the base : ");
double baseLength =double.Parse(Console.ReadLine());

double answer = (0.5 * baseLength * height );
Console.WriteLine($"the area of a triangle is {answer}");