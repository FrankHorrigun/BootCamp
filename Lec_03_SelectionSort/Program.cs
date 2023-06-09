﻿void SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i; //определяем рабочий элемент
        for (int j = i + 1; j < size; j++) // проходим со следующего после рабочего до конца массива
        {
            if (collection[j] < collection[pos]) pos = j; // запоминаем позицию эелемента меньше рабочего
        }
        int temp = collection[i]; // свпапаем рабочий с минимальным и начинаем второй проход со следующего от рабочего (в начале уже отсортированые элементы)
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
}

int[] array = { 7, 6, 3, 4, 5, 1, 2, 3 };
Console.WriteLine($"[{string.Join(", ", array)}]");
SortSelection(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

