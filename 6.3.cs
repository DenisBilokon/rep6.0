class Program
{
    Random random = new Random();

    int[] array = new int[10];

    public void generateArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 30);
        }
    }
    public void printArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }


    public void BubleSort()  
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int value = array[i];
                    array[i] = array[j];
                    array[j] = value;
                }
            }
        }
    }

    static void Main()
    {
        Program sort = new Program();

        sort.generateArray();
        sort.BubleSort();
        sort.printArray();
    }
}