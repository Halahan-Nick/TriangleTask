
//Declare variables for triangle ABC
Console.WriteLine("Enter coordinate x of dot A:");
    double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A:");
    double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate x of dot B:");
    double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B:");
    double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter coordinate x of dot C:");
    double xC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C:");
    double yC = Convert.ToDouble(Console.ReadLine());

//calculate triangle sides AB, BC, AC
    double yAB = Math.Pow((yA - yB), 2);
    double xAB = Math.Pow((xA - xB), 2);    
    double AB = Math.Round(Math.Sqrt(yAB + xAB), 3);

    double yBC = Math.Pow((yB - yC), 2);
    double xBC = Math.Pow((xB - xC), 2);
    double BC = Math.Round(Math.Sqrt(yBC + xBC), 3);

    double yAC = Math.Pow((yA - yC), 2);
    double xAC = Math.Pow((xA - xC), 2);
    double AC = Math.Round (Math.Sqrt(yAC + xAC),3);

//output of triangle sides
Console.WriteLine("Length of AB is:'" + AB + "'");
Console.WriteLine("Length of BC is:'" + BC + "'");
Console.WriteLine("Length of AB is:'" + AC + "'\n");


//output triangle IS Equilateral or NOT
if (AB == BC && AB == AC)
{
    Console.WriteLine("Triangle IS 'Equilateral'");
}
else
    Console.WriteLine("Triangle IS NOT'Equilateral'");

//output triangle IS Isosceles  or NOT
if (AB == BC | AB == AC | BC == AC)
{
    Console.WriteLine("Triangle IS 'Isoscelles'");
}
else
Console.WriteLine("Triangle IS NOT 'Isoscelles'");

//output triangle IS Right or NOT
double roundTo = 0.001;
double hypotenuseAB = Math.Abs(Math.Pow((AB),2) - (Math.Pow((BC), 2) + Math.Pow((AC), 2)));
double hypotenuseBC = Math.Abs(Math.Pow((BC), 2) - (Math.Pow((AB), 2) + Math.Pow((AC), 2)));
double hypotenuseAC = Math.Abs(Math.Pow((AC), 2) - (Math.Pow((BC), 2) + Math.Pow((AB), 2)));

if (hypotenuseAB <= roundTo)
{
    Console.WriteLine("Triangle IS 'Right'");
}
else if (hypotenuseBC <= roundTo)
{
    Console.WriteLine("Triangle IS 'Right'");
}
else if (hypotenuseAC <= roundTo)
{
    Console.WriteLine("Triangle IS 'Right'\n");
}
else
Console.WriteLine("Triangle IS NOT 'Right'\n");

//output Perimeter
double perimeter = AB + BC + AC;
Console.WriteLine("Perimeter:'" + perimeter + "'\n");

//output even numbers from 0 to value of triangle perimeter
int i = 0;
Console.WriteLine("Parity number in range from 0 to triangle perimeter:");

for (i = 0; i < perimeter; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ");
    }
}


Console.ReadKey();



