using System.Collections.Generic;

namespace Edu.DesignPatterns.Behavioral.Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        private readonly List<string> _collection;

        public WordsCollection()
            : this(new List<string>())
        {
        }

        public WordsCollection(params string[] collection)
            : this(new List<string>(collection))
        {
        }

        public WordsCollection(List<string> collection)
        {
            _collection = collection;
        }

        public void AddItem(string item)
        {
            _collection.Add(item);
        }

        public List<string> GetItems()
        {
            return _collection;
        }

        public override System.Collections.IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this);
        }
    }
}
