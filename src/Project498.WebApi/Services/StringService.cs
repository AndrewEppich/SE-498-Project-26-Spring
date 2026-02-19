namespace Project498.WebApi.Services;

public class StringService : IStringService
{
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(' ', words);
    }
}
