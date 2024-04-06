using System;

namespace Edu.DesignPatterns.Behavioral.Iterator
{
    public static class Iterator
    {
        public static void Execute()
        {
            var words = new WordsCollection();
            words.AddItem("First");
            words.AddItem("Second");
            words.AddItem("Third");

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
