// Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.
// Входные данные
// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – количество кустов черники. Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.
// Выходные данные
// В выходной файл OUTPUT.TXT выведите ответ на задачу.

Console.Clear();
Console.WriteLine("Введите количество кустов черники: ");
int n = int.Parse(Console.ReadLine()!);
while (n<3 || n>1000)
{
  Console.WriteLine("Вы ошиблись!\nВведите количество кустов черники: ");
  n = int.Parse(Console.ReadLine()!);  
}
int sum = 0;
int max = 0;
int imax = 0;
int[] array = new int[n]; 
for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ("Введите число ягод на кусте: ");
        array [i] = int.Parse (Console.ReadLine()!);
        if (array[i]>max) 
        {
            max = array[i]; 
            imax = i;
        }
        
    }
if (imax == 0)
    sum = max + array[n-1]+array [imax+1];
else if (imax == n-1)
    sum = max + array[imax-1]+array [0];
else
    sum = max + array[imax-1]+array [imax+1];
Console.WriteLine($"Количество собранной черники: {sum}");