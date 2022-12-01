class MenuManager
{
    public void Display() 
    {
        Console.WriteLine("================");
        Console.WriteLine("Arifm calculator");
        Console.WriteLine("================");
        Console.WriteLine(" 1 - Adding");
        Console.WriteLine(" 2 - Substracting");
        Console.WriteLine(" 3 - Multiplying");
        Console.WriteLine(" 4 - Dividing");
        Console.WriteLine(" 5 - Exit");
        Console.WriteLine("================");
    }
    public int GetChoice() 
    {
        Console.WriteLine("Enter operation num");
        return int.Parse(Console.ReadLine());
    }

    public bool AllowContinue()
    {
        Console.WriteLine("Continue (y/n)? - ");
        string allow = Console.ReadLine();
        return (allow == "y");
    }
}