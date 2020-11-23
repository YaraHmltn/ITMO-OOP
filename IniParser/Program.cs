using System;


namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {

            string FilePath = @"C:\Users\yaros\source\repos\ITMO-OOP\Parser\bin\Debug\netcoreapp3.1\input.ini";
            string IncorrectPath = @"hvost";

            try
            {
                iniReader tmp = new iniReader(IncorrectPath);
            }
            catch (Exception MyException)
            {
                Console.WriteLine($"Возникла ошибка: {MyException.Message}");
            }


            try
            {
                iniReader R = new iniReader(FilePath);
                Console.WriteLine(R.TryGetValue<int>("COMMON", "LogXML"));
                Console.WriteLine(R.TryGetValue<float>("ADC_DEV", "BufferLenSecons"));
                Console.WriteLine(R.TryGetValue<int>("ADC_DEV", "Driver"));
            }
            catch (Exception MyException)
            {
                Console.WriteLine($"Возникла ошибка: {MyException.Message}");
            }



            Console.ReadKey();
        }
    }
}