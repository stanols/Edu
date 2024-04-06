namespace Edu.DesignPatterns.Behavioral.Iterator
{
    public class AlphabeticalOrderIterator : BaseIterator
    {
        private WordsCollection _collection;
        private int _position = -1;

        public AlphabeticalOrderIterator(WordsCollection collection)
        {
            _collection = collection;
        }

        public override object Current()
        {
            var items = _collection.GetItems();
            return items[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            var updatedPosition = _position + 1;

            if (updatedPosition > 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = 0;
        }
    }
}
