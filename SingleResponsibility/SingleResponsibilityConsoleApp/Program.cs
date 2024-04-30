
using SingleResponsibilityBadCaseConsoleApp;

bool isStop = false;

while (!isStop)
{
    try
    {
        Console.WriteLine("Enter Amount");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
            throw new Exception("Amount must be numeric");

        Console.WriteLine("Select Listed Tax");
        Console.WriteLine("KDV");
        Console.WriteLine("ABC");
        Console.WriteLine("XYZ");

        string? name = Console.ReadLine();
        if (!string.IsNullOrEmpty(name))
            Calculator.CalculateAndWrite(name, amount);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


