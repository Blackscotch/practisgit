int[] arr = CreateArr();
Console.WriteLine($"Массив: {String.Join(", ", arr)}");
while (true)
{
    Console.WriteLine("Введите искомое значение или 0 для выхода");
    var k = Convert.ToInt32(Console.ReadLine());
    if (k == 0)
    {
        break;
    }
    var search = BinarySearch(arr, k, 0, arr.Length - 1);
    if (search < 0)
    {
        Console.WriteLine("Элемент со значением {0} не найден", k);
    }
    else
    {
        Console.WriteLine("Элемент найден. Индекс элемента со значением {0} равен {1}", k, search);
    }
}

static int [] CreateArr(){
    int len = 12;
    int[] arr = new int[len];
    var rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1,50);
    }

    Array.Sort(arr);
    return arr;
}
static int BinarySearch(int[] array, int searchedValue, int left, int right)
{
    while (left <= right)
    {
        var middle = (left + right) / 2;

        if (searchedValue == array[middle])
        {
            return middle;
        }
        else if (searchedValue < array[middle])
        {
            right = middle - 1;
        }
        else
        {
            left = middle + 1;
        }
    }
    return -1;
}
