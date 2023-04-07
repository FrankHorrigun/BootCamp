// BubleSort
// classic
int[] array = { 3, 2, 5, 6, 7, 5, 9, 2 };
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length-1; j++)
    {
        int temp = array[j];
        if (array[j] > array[j+1])
        {
            array[j] = array[j+1];
            array[j+1] = temp;
        }
    }
}
Console.WriteLine($"[{string.Join(", ", array)}]");