using System.ComponentModel;
using ConsoleApp1;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Squre s1 =new Squre{ leftPoint = 78};

        Line line1 = new Line { leftPoint = 6 };
        Line line2 = new Line { leftPoint = 2 };
        Line line3 = new Line { leftPoint = 8 };
        Line line4 = new Line { leftPoint = 2 };
        s1.AddComponent(line1);
        s1.AddComponent(line2);
        s1.AddComponent(line3);
        s1.AddComponent(line4);

        s1.move(3);


    }
}