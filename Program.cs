using System;
class Program
{
    public static void Main(string[] args)
    {
        User data = new User();
        Console("Name : ");
        data.Name = Console.ReadLine();
        Console.Write("Surname : ");
        data.Surname = Console.ReadLine();
        Consoel.Write("ID : ");
        data.ID = StringToLong(Console.ReadLine());
        Console.Write("Score : ");
        data.Score = StringToInt(Console.ReadLine());
    }
    public static int StringToInt(string value)
    {
        if(int.TryParse(value,out int number))
        {
            return number;
        }
        throw new Exception("Wrong Word");
    }
        public static long StringToLong(string value)
    {
        if(long.TryParse(value,out long number))
        {
            return number;
        }
        throw new Exception("Wrong Word");
    }
}