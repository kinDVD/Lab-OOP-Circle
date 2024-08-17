using Lab_OOP_Circle;

Console.WriteLine("Please enter the starting radius of your circle:");

bool runProgram = true;
while (runProgram)
{
    double radiant = 0;
    while (true)
    {
        try
        {
            radiant = double.Parse(Console.ReadLine());
            if (radiant < 0)
            {
                throw new Exception("Cannot be a negative.");
            }
            else if (radiant == 0)
            {
                throw new Exception("Cannot be a zero.");
            }
            else
            {
                break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
    while (true)
    {
        Circle o = new Circle(radiant);
        Console.WriteLine($"The radius is: {radiant}.");
        Console.WriteLine($"The diameter of the circle is: {o.calculateDiameter(radiant)}.");
        Console.WriteLine($"The circumference of the circle is: {o.getCircumference(radiant)}.");
        Console.WriteLine($"The area of the circle is: {o.getArea(radiant)}.");
        Console.WriteLine("Would you like to grow the circle? yes/no");
        string grow = Console.ReadLine().ToLower();
            if (grow == "yes")
            {
                radiant = o.grow(radiant);
                Console.Clear();
                continue;
            }
            else if (grow == "no")
            {
                runProgram = false;
                Console.WriteLine("Thanks for using our circle calculator!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }
    }
}