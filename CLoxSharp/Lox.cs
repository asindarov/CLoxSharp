namespace CLoxSharp;

public class Lox
{
    public static void Error(int line, string message)
    {
        Report(line, "", message);
    }
    
    private static void Report(int line, string where, string message)
    {
        Console.WriteLine($"[line {line}] Error {where}: {message}");
    }
}