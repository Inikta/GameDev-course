class Task1           
{
    static void Main(string[] args)         //точка входа
    {
        int[] a = BubbleSort.generateArray(10, 100);     //генерируем и выводим исходный массив
        Console.WriteLine("Was: ");
        printArray(a);

        Console.WriteLine();

        BubbleSort.sort_bubble(a);                       //сортируем массив и выводим результат
        Console.WriteLine("Sorted: ");
        printArray(a);
    }

    /*
     * Метод для вывода массива в одну строку 
     */
    static void printArray(int[] array)        
    {
        foreach (int i in array)
        {
            Console.Write(i.ToString() + " ");
        }
    }
}
class BubbleSort                                     //решил создать отдельный класс для операций над массивом,
                                                //т.к так правильнее с точки зрения ООП
{
    /*
     * Метод генерации массива. 
     * Принимает параметры размера массива и максимального числа.
     */
    public static int[] generateArray(int size, int max)
    {
        Random randonNum = new Random();

        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = randonNum.Next(max);
        }

        return array;
    }

    /*
     * Сортировка пузырьком.
     */
    public static void sort_bubble(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (array[j] < array[i])
                {
                    int c = array[j];
                    array[j] = array[i];
                    array[i] = c;
                }
            }
        }
    }
}