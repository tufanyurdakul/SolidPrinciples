namespace SingleResponsibilityBadCaseConsoleApp
{
    internal static class Calculator
    {
        public static void CalculateAndWrite(string type, decimal val)
        {
            // Write operation can be another class. All operation must do own business.
            decimal value = 0;
            if (type.ToLower().Equals("kdv"))
                value = val * (decimal)0.2;

            else if (type.ToLower().Equals("abc"))
                value = val * (decimal)0.1;

            else if (type.ToLower().Equals("xyz"))
                value = val * (decimal)0.15;

            Console.WriteLine(value);
        }
    }
}
