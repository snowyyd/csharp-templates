namespace MyTemplate;

internal static class Program
{
	internal static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
		Console.WriteLine($"Args: {(args.Length == 0 ? "(null)" : string.Join(" ", args))}");
	}
}
