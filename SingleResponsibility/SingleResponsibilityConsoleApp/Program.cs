
bool isStop = false;

while (isStop)
{
    try
    {
        Console.WriteLine("Enter Amount");
        if (!int.TryParse(Console.ReadLine(), out int amount))
            throw new Exception("Amount must be numeric");

        Console.WriteLine("Select Listed Tax");
        Console.WriteLine("KDV");
        Console.WriteLine("ABC");
        Console.WriteLine("XYZ");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


