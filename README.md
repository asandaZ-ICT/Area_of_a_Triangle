# Area_of_a_Triangle
A simple C# console application that asks the user to write the height and base of a triangle and then calculates the area

## Code example
```Csharp
Console.Write("Write the height : ");
double height =double.Parse(Console.ReadLine());

Console.Write("Write the base : ");
double baseLength =double.Parse(Console.ReadLine());

double answer = (0.5 * baseLength * height );
Console.WriteLine($"the area of a triangle is {answer}");
```
