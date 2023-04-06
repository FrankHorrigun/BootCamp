// Big O Notation

// таблица умонжения от 1 до n

int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}
// сложность 0(n^2)
// оптимизируем
int[, ] matr = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matr[i, j] = (i + 1) * (j + 1);
        matr[j, i] = (i + 1) * (j + 1);
    }
}
 Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)                 
    {                                           
        Console.Write(matr[i, j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
// сложность O(n^2/2)



