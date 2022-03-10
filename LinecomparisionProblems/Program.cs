//UC2
Console.WriteLine("Enter the length of the lineone :");
Console.WriteLine("Enter the length of the linetwo :");

double lineone = double.Parse(Console.ReadLine());
double linetwo = double.Parse(Console.ReadLine());
if (lineone.Equals(linetwo))
{
    Console.WriteLine("lineone is eqal to linetwo");

}
else
{
    Console.WriteLine("lineone is not equal to linetwo");
}
