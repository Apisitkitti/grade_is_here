using System;
class Program
{
    public static void Main(string[] args)
    {
        Grade grade = new Grade();
        User data = new User();
        Console("Name : ");
        data.Name = Console.ReadLine();
        Console.Write("Surname : ");
        data.Surname = Console.ReadLine();
        Consoel.Write("ID : ");
        data.ID = StringToLong(Console.ReadLine());
        Console.Write("Score : ");
        grade.Score = StringToInt(Console.ReadLine());
        User.PrintInputInformation();
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