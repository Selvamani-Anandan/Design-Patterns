namespace Singleton;

/// <summary>
/// Thread-safe Singleton implementation using double-check locking
/// </summary>
public class ThreadSafeLogger
{
    // Volatile keyword ensures that the instance is correctly initialized
    // before it's accessed by other threads
    private static volatile ThreadSafeLogger? _instance;
    private static readonly object _lock = new object();
    private List<string> _logs;
    
    private ThreadSafeLogger()
    {
        _logs = new List<string>();
    }
    
    public static ThreadSafeLogger Instance
    {
        get
        {
            // First check (no lock)
            if (_instance == null)
            {
                // Lock only if instance is null
                lock (_lock)
                {
                    // Second check (with lock)
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeLogger();
                    }
                }
            }
            return _instance;
        }
    }
    
    public void Log(string message)
    {
        lock (_lock) // Thread-safe logging
        {
            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            _logs.Add(logEntry);
            Console.WriteLine($"[Thread-Safe] {logEntry}");
        }
    }
    
    public IReadOnlyList<string> GetLogs()
    {
        lock (_lock) // Thread-safe read
        {
            return _logs.ToList().AsReadOnly();
        }
    }
}