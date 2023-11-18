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

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
