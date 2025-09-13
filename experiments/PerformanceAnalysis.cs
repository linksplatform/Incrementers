using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Platform.Incrementers;

namespace PerformanceAnalysis;

public class PerformanceAnalysisRunner
{
    private const int ITERATIONS = 1_000_000;
    private const int TEST_RUNS = 10;
    
    public static void Main()
    {
        Console.WriteLine("=== Performance Analysis: Increment Method vs Anonymous Lambda Functions ===\n");
        Console.WriteLine($"Running {TEST_RUNS} iterations of {ITERATIONS:N0} operations each\n");
        
        var results = new Dictionary<string, List<long>>();
        
        for (int run = 0; run < TEST_RUNS; run++)
        {
            Console.WriteLine($"Run {run + 1}/{TEST_RUNS}:");
            
            RunBenchmarkWithCollection("IncrementMethod", TestIncrementMethod, results);
            RunBenchmarkWithCollection("AnonymousLambda", TestAnonymousLambda, results);
            RunBenchmarkWithCollection("DirectAnonymousLambda", TestDirectAnonymousLambda, results);
            RunBenchmarkWithCollection("DirectFieldIncrement", TestDirectFieldIncrement, results);
            
            Console.WriteLine();
        }
        
        Console.WriteLine("=== Statistical Summary ===");
        foreach (var kvp in results)
        {
            var times = kvp.Value;
            var avg = times.Average();
            var min = times.Min();
            var max = times.Max();
            var stdDev = Math.Sqrt(times.Sum(t => Math.Pow(t - avg, 2)) / times.Count);
            
            Console.WriteLine($"{kvp.Key,-25}: Avg={avg:F2}ms, Min={min}ms, Max={max}ms, StdDev={stdDev:F2}ms");
        }
        
        Console.WriteLine("\n=== Performance Comparison Analysis ===");
        
        var incrementMethodAvg = results["IncrementMethod"].Average();
        var anonymousLambdaAvg = results["AnonymousLambda"].Average();
        var directAnonymousLambdaAvg = results["DirectAnonymousLambda"].Average();
        var directFieldIncrementAvg = results["DirectFieldIncrement"].Average();
        
        Console.WriteLine($"Direct Field Increment is the fastest (baseline)");
        Console.WriteLine($"Anonymous Lambda is {anonymousLambdaAvg / directFieldIncrementAvg:F2}x slower than direct field increment");
        Console.WriteLine($"Incrementer.Increment() is {incrementMethodAvg / directFieldIncrementAvg:F2}x slower than direct field increment");
        Console.WriteLine($"Direct Anonymous Lambda is {directAnonymousLambdaAvg / directFieldIncrementAvg:F2}x slower than direct field increment");
        
        Console.WriteLine($"\nComparing Incrementer.Increment() vs Anonymous Lambda:");
        if (incrementMethodAvg > anonymousLambdaAvg)
        {
            Console.WriteLine($"Anonymous Lambda is {incrementMethodAvg / anonymousLambdaAvg:F2}x faster than Incrementer.Increment()");
        }
        else
        {
            Console.WriteLine($"Incrementer.Increment() is {anonymousLambdaAvg / incrementMethodAvg:F2}x faster than Anonymous Lambda");
        }
    }
    
    private static void RunBenchmarkWithCollection(string name, Action testAction, Dictionary<string, List<long>> results)
    {
        if (!results.ContainsKey(name))
            results[name] = new List<long>();
            
        // Warmup
        for (int i = 0; i < 100; i++)
            testAction();
            
        // Actual measurement
        var stopwatch = Stopwatch.StartNew();
        testAction();
        stopwatch.Stop();
        
        results[name].Add(stopwatch.ElapsedMilliseconds);
        Console.WriteLine($"  {name,-25}: {stopwatch.ElapsedMilliseconds} ms");
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