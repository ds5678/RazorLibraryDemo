using RazorLibrary;

namespace EditionOne;

public class Program
{
	public static void Main(string[] args)
	{
		LibraryControlClass.Name = "Edition One";
		LibraryControlClass.Run(args);
	}
}
