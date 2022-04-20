using lab_3.Logger;

namespace lab_3.Logger
{
    public class Program
    {
        public static void Main()
        {
            ILogger[] loggers = new ILogger[]
            {
                new ConsoleLogger(),
                new FileLogger("log.txt"),
                new SocketLogger("google.com", 80)
            };

            using (ILogger logger = new CommonLogger(loggers))
            {
                logger.Log("Example message 1 ...");
                logger.Log("Example message 2 ...");
                logger.Log("Example message 3 ...", "value 1", "value 2", "value 3");
            }
        }
    }
}

/* 2022-03-23T00:18:17+00:00: Example message 1 ...
2022-03-23T00:18:17+00:00: Example message 2 ...
2022-03-23T00:18:17+00:00: Example message 3 ... value 1 value 2 value 3 */