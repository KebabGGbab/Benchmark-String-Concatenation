using BenchmarkDotNet.Running;
using String_Concatenation;

internal class Program
{
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run<Test>();
    }
}