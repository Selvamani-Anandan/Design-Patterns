# Singleton Pattern

## What is the Singleton Pattern?
The Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance. It's useful when exactly one object is needed to coordinate actions across the system.

## Easy Way to Remember
Think of a Government:
- A country has only one government at a time
- Anyone who needs to interact with the government uses the same instance
- You can't create a new government; you must work with the existing one
- The government maintains its state and provides services to all citizens

## Implementation Approaches

### 1. Basic Singleton (Not Thread-Safe)
```csharp
public class BasicSingleton
{
    private static BasicSingleton _instance;
    
    private BasicSingleton() { }
    
    public static BasicSingleton Instance
    {
        get
        {
            if (_instance == null)
                _instance = new BasicSingleton();
            return _instance;
        }
    }
}
```

### 2. Thread-Safe with Double-Check Locking
```csharp
public class ThreadSafeSingleton
{
    private static volatile ThreadSafeSingleton _instance;
    private static readonly object _lock = new object();
    
    public static ThreadSafeSingleton Instance
    {
        get
        {
            if (_instance == null) // First check
            {
                lock (_lock)
                {
                    if (_instance == null) // Second check
                        _instance = new ThreadSafeSingleton();
                }
            }
            return _instance;
        }
    }
}
```

### 3. Lazy Initialization
```csharp
public class LazySingleton
{
    private static readonly Lazy<LazySingleton> _instance = 
        new Lazy<LazySingleton>(() => new LazySingleton());
    
    public static LazySingleton Instance => _instance.Value;
}
```

## Key Concepts

### Double-Check Locking
- First check without lock for performance
- Lock only if instance is null
- Second check inside lock for thread safety
- Uses volatile keyword for correct initialization

### Volatile Keyword
- Ensures field reads/writes go directly to main memory
- Prevents compiler optimizations that could cause threading issues
- Critical for double-check locking pattern
- Ensures instance is fully initialized before being accessed

## When to Use
1. Shared resources (database connections, file systems)
2. Configuration settings
3. Logging services
4. Device drivers or hardware interfaces
5. Application state management

## Benefits
1. Ensures single instance
2. Global access point
3. Lazy initialization possible
4. Can be extended for controlled number of instances

## Implementation Tips
1. Make constructor private
2. Create static method for instance access
3. Consider thread safety requirements
4. Use lazy initialization when possible
5. Implement double-check locking for performance

Remember: "One instance to rule them all!"
