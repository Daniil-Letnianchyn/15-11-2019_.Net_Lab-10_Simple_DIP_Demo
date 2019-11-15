using System;

namespace Demo.DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation of "plumbing" object
            IWriteTo writeToJson = new WriteToJson();

            //Initialisation of "abstract" loger service with "specific implementation" in client code(in the place where we invoke it)
            ICustomLog customLogger = new CustomLogerService(writeToJson);
            customLogger.LogError("Error1");
            //As long as we still invoke methods against ICustomLog, we could initialise it with other "specific implementation" and continue to use same interface
            customLogger = new CustomLogerService(new WriteToXML());
            customLogger.LogError("Error2");

            Console.ReadKey();
        }
    }
}
