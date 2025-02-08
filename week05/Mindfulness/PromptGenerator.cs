public static class PromptGenerator
{
    private static List<string> Prompts = new List<string>
    {
        "--- Think of a time when you stood up for someone else. ---",
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Think of a time when you did something truly selfless. ---"

    };
 
    public static string GetRandomPrompt()
    {
        var random = new Random();
        return Prompts[random.Next(Prompts.Count)];
    }
}