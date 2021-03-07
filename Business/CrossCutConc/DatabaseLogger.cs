using System;
namespace Business.CrossCutConc
{
    public class DatabaseLogger : ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }


}
