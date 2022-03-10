//UC3
Console.WriteLine("Enter the length of lineone:");
Console.WriteLine("Enter the length of linetwo:");

double lineone = double.Parse(Console.ReadLine());
double linetwo = double.Parse(Console.ReadLine());

if (lineone == linetwo)
{
    Console.WriteLine("lineone is equal to linetwo");

}
else if (lineone > linetwo)
{
    Console.WriteLine("lineone is greater than linetwo");
}
else
{
    Console.WriteLine("lineone is less than linetwo");
}

