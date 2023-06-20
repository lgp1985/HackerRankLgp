public class Result
{

    /*
     * Complete the 'noPrefix' function below.
     *
     * The function accepts STRING_ARRAY words as parameter.
     */

    public static void noPrefix(List<string> words)
    {
        var indexedWords = new HashSet<string>(StringComparer.Ordinal);
        var indexedPrefix = new HashSet<string>(StringComparer.Ordinal);
        foreach (var word in words)
        {
            if (indexedPrefix.Contains(word))
            {
                Console.WriteLine("BAD SET");
                Console.WriteLine(word);
                return;
            }
            foreach (var prefix in Enumerable.Range(1, word.Length).Select(l => word[..l]))
            {
                _ = indexedPrefix.Add(prefix);
                if (indexedWords.Contains(prefix))
                {
                    Console.WriteLine("BAD SET");
                    Console.WriteLine(word);
                    return;
                }
            }
            _ = indexedWords.Add(word);
        }
        Console.WriteLine("GOOD SET");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var words = new List<string>();

        for (var i = 0; i < n; i++)
        {
            var wordsItem = Console.ReadLine();
            words.Add(wordsItem);
        }

        Result.noPrefix(words);
    }
}
