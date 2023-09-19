namespace _24._2_TheColour;

class Program
{
    static void Main(string[] args)
    {
        List<Colour> list = new List<Colour>();
        list.Add(new Colour(3, 47, 199));
        list.Add(Colour.Purple);

        foreach(Colour colour in list)
        {
            Console.WriteLine(colour.ToString());
        }

        Console.ReadLine();
    }
}

public class Colour
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public Colour(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
    public override string ToString()
    {
        return $"RED: {Red}, GREEN: {Green}, BLUE: {Blue}";
    }

    // static colours
    public static Colour White { get; } = new Colour(255, 255, 255);
    public static Colour Black { get; } = new Colour(0, 0, 0);
    public static Colour _Red { get; } = new Colour(255, 0, 0);
    public static Colour Orange { get; } = new Colour(255, 165, 0);
    public static Colour Yellow { get; } = new Colour(255, 255, 0);
    public static Colour _Green { get; } = new Colour(0, 128, 0);
    public static Colour _Blue { get; } = new Colour(0, 0, 255);
    public static Colour Purple { get; } = new Colour(128, 0, 128);
}