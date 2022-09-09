class User
{
    public string Name = "";
    public string Surname = "";
    public long ID;
    public int Score;
    public static void PrintInputInformation(User data)
    {
        Console.Write("{0} {1} {2} {3} {4}",data.Name,data.Surname,data.ID,data.Score);
    }

}