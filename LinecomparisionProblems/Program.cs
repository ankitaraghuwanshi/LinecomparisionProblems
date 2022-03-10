//UC1
Console.WriteLine("Enter the co_ordinates x1 :");
Console.WriteLine("Enter the co_ordinates x2 :");
Console.WriteLine("Enter the co_ordinates y1 :");
Console.WriteLine("Enter the co_ordinates y2 :");

double x1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double lengthx = Math.Pow((x2 - x1), 2);
double lengthy = Math.Pow((y2 - y1), 2);

double sum = lengthx + lengthy;
double lengthOfLine = (Math.Sqrt(sum));

Console.WriteLine("Answer : " + lengthOfLine);

