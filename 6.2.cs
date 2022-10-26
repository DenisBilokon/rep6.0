
using System.Collections;

class MyDictionary<Tkey, Tval>
    {
        private int counter = 0;
        private Tkey[] keysArray = null;
        private Tval[] valsArray = null;



    public int Counter
        {
            get { return this.counter; }
        }

        public void Add(Tkey key, Tval val)
        {
            this.counter++;

            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;

            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }

        public Tval this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        for (int i = 0; i < keysArray.Length; i++)
            yield return new KeyValuePair<TKey, TValue>(keysArray[i], valsArray[i]);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    static void Main(string[] args);

}
