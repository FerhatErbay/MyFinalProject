using System;
namespace Business.CrossCutConc
{
    public class FileLogger :ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged to file.");
        }
    }


}
