namespace CustomerManagementSystemConsoler
{
    public static class Validations
    {
        public static int FormatCheckOfInput(string? input)
        {
            try
            {
                var result = int.Parse(input);
                return result;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong format " + ex.Message);
                Environment.Exit(0);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + "The value can`nt be null.");
                throw;
            }
            return -1;
        }
    }
}
