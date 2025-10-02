using System.Runtime.InteropServices;
using CLoxSharp;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 1)
        {
            Console.WriteLine("Usage: cloxsharp [script]");
            Environment.Exit(64);
        }
        else if (args.Length == 1)
        {
            RunFile(args[0]);
        }
        else
        {
            RunPrompt();
        }
    }

    private static void RunFile(string path)
    {
        var code = File.ReadAllText(path);
        Run(code);
    }

    private static void RunPrompt()
    {
        for (;;)
        {
            Console.Write("> ");
            var line = Console.ReadLine();
            if (line == null) break;
            Run(line);
        }
    }

    private static void Run(string source)
    {
        var scanner = new Scanner(source);
        var tokens = scanner.ScanTokens();
        
        foreach(var token in tokens)
        {
            Console.WriteLine(token);
        }
    }
}