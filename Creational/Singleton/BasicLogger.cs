namespace Singleton;

/// <summary>
/// Basic Singleton implementation - NOT thread-safe
/// </summary>
public class BasicLogger
{
    private static BasicLogger? _instance;
    private List<string> _logs;
    
    // Private constructor to prevent direct instantiation
    private BasicLogger()
    {
        _logs = new List<string>();
    }
    
    public static BasicLogger Instance
    {
        get
        {
            // Not thread-safe!
            if (_instance == null)
            {
                _instance = new BasicLogger();
            }
            return _instance;
        }
    }
    
    public void Log(string message)
    {
        var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
        _logs.Add(logEntry);
        Console.WriteLine($"[Basic] {logEntry}");
    }
    
    public IReadOnlyList<string> GetLogs() => _logs.AsReadOnly();
}