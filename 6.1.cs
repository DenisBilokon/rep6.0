using hw6;
using System;
using System.Collections;

namespace hw6
{
    class MyList<T>
    {
        private ArrayList myList;

        public T this[int index]
        {
            get { return (T)myList[index]; }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new ArrayList();
        }

        public MyList(int count)
        {
            this.myList = new ArrayList(count);
        }

        public void Add(T item)
        {
            myList.Add(item);
        }

        public int Capacity
        {
            get { return myList.Capacity; }
            set
            {

                if (value < myList.Count)
                    throw new ArgumentOutOfRangeException();

                myList.Capacity = value;
            }
        }

        public int Count
        {
            get { return myList.Count; }
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        MyList<int> mylist = new MyList<int>(5);
        mylist[0] = 1;
        Console.WriteLine("Емкость списка: {0} элемент(-ов)", mylist.Capacity);
        Console.WriteLine("Список фактически содержит: {0} элемент(-ов)", mylist.Count);
        mylist.Add(15);
        Console.WriteLine("Емкость списка: {0} элемент(-ов)", mylist.Capacity);

        Console.ReadKey();
    }
}
