# Singleton Design Pattern in C#

This repository contains an example implementation of the Singleton design pattern in C#. The Singleton pattern ensures that a class has only one instance and provides a global point of access to it.

## Overview

The Singleton pattern is one of the most common design patterns. It is used in scenarios where exactly one instance of a class is needed, and it provides a global point of access to this instance.

### Features of Singleton Pattern

- **Lazy Initialization**: The Singleton instance is created only when it is needed.
- **Thread Safety**: The implementation is thread-safe, ensuring that only one instance is created even in a multithreaded environment.
- **Global Access**: The Singleton instance can be accessed globally.

## Example Code

The code consists of two main files:

- `Singleton.cs`: Contains the Singleton class implementation.
- `Program.cs`: Contains the example usage of the Singleton class.

### Singleton.cs

```csharp
using System;

namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _lock = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something!");
        }
    }
}
