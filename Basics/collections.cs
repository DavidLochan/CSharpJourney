namespace Basics;
public class CollectionsDemo
{
    public static void Run()
    {
        List<string> languages = new List<string>
        {
            "C#",
            "Java",
            "Python"
        };

        foreach (var lang in languages)
        {
            Console.WriteLine(lang);
        }
    }
}
