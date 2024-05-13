using CMS.Common.Interfaces;

namespace CMS.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(this IEnumerable<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
