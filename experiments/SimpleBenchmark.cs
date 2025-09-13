using System;
using System.Diagnostics;
using Platform.Incrementers;

namespace SimpleBenchmark;

public class SimpleBenchmarkRunner
{
    private const int ITERATIONS = 1_000_000;
    
    public static void Main()
    {
        Console.WriteLine("=== Performance Comparison: Increment Method vs Anonymous Lambda Functions ===\n");
        
        RunBenchmark("Incrementer.Increment() Method", TestIncrementMethod);
        RunBenchmark("Anonymous Lambda Function", TestAnonymousLambda);
        RunBenchmark("Direct Anonymous Lambda", TestDirectAnonymousLambda);
        RunBenchmark("Direct Field Increment", TestDirectFieldIncrement);
        
        Console.WriteLine("\n=== Analysis ===");
        Console.WriteLine("Results show relative performance between different increment approaches.");
        Console.WriteLine("Lower execution time indicates better performance.");
    }
    
    private static void RunBenchmark(string name, Action testAction)
    {
        // Warmup
        for (int i = 0; i < 1000; i++)
            testAction();
            
        // Actual measurement
        var stopwatch = Stopwatch.StartNew();
        testAction();
        stopwatch.Stop();
        
        Console.WriteLine($"{name,-30}: {stopwatch.ElapsedMilliseconds} ms ({stopwatch.ElapsedTicks} ticks)");
    }
    
    private static void TestIncrementMethod()
    {
        var incrementer = new Incrementer();
        for (int i = 0; i < ITERATIONS; i++)
        {
            incrementer.Increment();
        }
    }
    
    private static void TestAnonymousLambda()
    {
        ulong counter = 0UL;
        var action = () => counter++;
        
        for (int i = 0; i < ITERATIONS; i++)
        {
            action();
        }
    }
    
    private static void TestDirectAnonymousLambda()
    {
        ulong counter = 0UL;
        
        for (int i = 0; i < ITERATIONS; i++)
        {
            Action action = () => counter++;
            action();
        }
    }
    
    private static void TestDirectFieldIncrement()
    {
        ulong counter = 0UL;
        
        for (int i = 0; i < ITERATIONS; i++)
        {
            counter++;
        }
    }
}