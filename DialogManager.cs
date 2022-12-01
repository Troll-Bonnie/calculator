class DialogManager
{
    private CalcManager _calc;

    public DialogManager()
    {
        _calc = new CalcManager();
    }
    public void AddDialog()
    {
        Console.WriteLine("> Enter nums:");
        Console.Write("  a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("  b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"> {a} + {b} = {_calc.add(a, b)}");
    }
    public void SubDialog()
    {
        Console.WriteLine("> Enter nums:");
        Console.Write("  a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("  b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"> {a} - {b} = {_calc.sub(a, b)}");
    }
    public void MultDialog()
    {
        Console.WriteLine("> Enter nums:");
        Console.Write("  a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("  b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"> {a} * {b} = {_calc.mult(a, b)}");
    }
    public void DivDialog()
    {
        Console.WriteLine("> Enter nums:");
        Console.Write("  a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("  b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"> {a} / {b} = {_calc.div(a, b)}");
    }
}