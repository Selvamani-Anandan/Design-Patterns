namespace Singleton;

/// <summary>
/// Thread-safe Singleton implementation using Lazy<T>
/// </summary>
public class LazyLogger
{
    // Lazy<T> is thread-safe by default
    private static readonly Lazy<LazyLogger> _lazyInstance = 
        new Lazy<LazyLogger>(() => new LazyLogger());
    
    private List<string> _logs;
    private readonly object _lock = new object();
    
    private LazyLogger()
    {
        _logs = new List<string>();
    }
    
    public static LazyLogger Instance => _lazyInstance.Value;
    
    public void Log(string message)
    {
        lock (_lock) // Thread-safe logging
        {
            var logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            _logs.Add(logEntry);
            Console.WriteLine($"[Lazy] {logEntry}");
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