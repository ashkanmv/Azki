namespace Azki.Repositories
{
    public class LogRepository
    {
        public async Task<bool> AddLog(string message)
        {
            try
            {
                var errorLog = Environment.NewLine + "UTC Occurrence Date => " + DateTime.UtcNow + " Error Message => " + message;
                await File.AppendAllTextAsync(Directory.GetCurrentDirectory() + "/ExceptionLogs.txt", errorLog);
                Console.WriteLine(errorLog);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
