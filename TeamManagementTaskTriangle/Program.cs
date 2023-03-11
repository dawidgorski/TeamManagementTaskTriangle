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


    }
}
