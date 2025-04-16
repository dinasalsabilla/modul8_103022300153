// See https://aka.ms/new-console-template for more information
namespace modul8_103022300153
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig config = BankTransferConfig.Config();

            config.WriteNewConfigFile();

            Console.Write("“Please insert the amount of money to transfer: " + config.threshold + ": ");
            double threshold = Convert.ToDouble(Console.ReadLine());

            Console.Write(“Please insert the amount of money to transfer: ");
    
        }
    }
}