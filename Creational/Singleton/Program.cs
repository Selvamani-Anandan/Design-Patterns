using Singleton;

Console.WriteLine("Singleton Pattern Demonstration");
Console.WriteLine("==============================\n");

// Demonstrate Basic Logger (Not Thread-Safe)
Console.WriteLine("Basic Logger (Not Thread-Safe):");
var logger1 = BasicLogger.Instance;
var logger2 = BasicLogger.Instance;
Console.WriteLine($"Are logger instances same? {ReferenceEquals(logger1, logger2)}");
logger1.Log("First message");
logger2.Log("Second message");
Console.WriteLine();

// Demonstrate Thread-Safe Logger with Double-Check Locking
Console.WriteLine("Thread-Safe Logger with Double-Check Locking:");
var threadSafeLogger1 = ThreadSafeLogger.Instance;
var threadSafeLogger2 = ThreadSafeLogger.Instance;
Console.WriteLine($"Are thread-safe logger instances same? {ReferenceEquals(threadSafeLogger1, threadSafeLogger2)}");
threadSafeLogger1.Log("First thread-safe message");
threadSafeLogger2.Log("Second thread-safe message");
Console.WriteLine();

// Demonstrate Lazy Logger
Console.WriteLine("Lazy Logger:");
var lazyLogger1 = LazyLogger.Instance;
var lazyLogger2 = LazyLogger.Instance;
Console.WriteLine($"Are lazy logger instances same? {ReferenceEquals(lazyLogger1, lazyLogger2)}");
lazyLogger1.Log("First lazy message");
lazyLogger2.Log("Second lazy message");
Console.WriteLine();

// Demonstrate Thread-Safety
Console.WriteLine("Demonstrating Thread-Safety with Parallel Logging:");
Parallel.For(0, 5, i =>
{
    ThreadSafeLogger.Instance.Log($"Parallel message {i}");
    LazyLogger.Instance.Log($"Parallel message {i}");
});