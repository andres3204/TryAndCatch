namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number please: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

    }
    
}