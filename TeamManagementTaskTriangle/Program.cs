class Triangle
{
    public static double ParseStringValue()
    {
        string coordinateString = Console.ReadLine();
        double cleanInput1 = 0;
        while (!double.TryParse(coordinateString, out cleanInput1))
        {
            Console.WriteLine("Wrong data. Enter number");
            coordinateString = Console.ReadLine();
        }
        return cleanInput1;
    }
    public static double SideLength(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    }

    public static void Main(string[] args)
    {

        Console.WriteLine("Enter coordinate x of dot A:");
        double dot1x = ParseStringValue();
        Console.WriteLine("Enter coordinate y of dot A:");
        double dot1y = ParseStringValue();
        Console.WriteLine("Enter coordinate x of dot B:");
        double dot2x = ParseStringValue();
        Console.WriteLine("Enter coordinate y of dot B:");
        double dot2y = ParseStringValue();
        Console.WriteLine("Enter coordinate x of dot C:");
        double dot3x = ParseStringValue();
        Console.WriteLine("Enter coordinate y of dot C:");
        double dot3y = ParseStringValue();

        double ab = SideLength(dot1x, dot1y, dot2x, dot2y);
        double bc = SideLength(dot2x, dot2y, dot3x, dot3y);
        double ac = SideLength(dot1x, dot1y, dot3x, dot3y);

        Console.WriteLine($"Length of AB is: '{ab}'");
        Console.WriteLine($"Length of BC is: '{bc}'");
        Console.WriteLine($"Length of AC is: '{ac}'");

        Console.WriteLine();


    }
}
