// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//С РАНДОМОМ
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNumber()
{

    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr, int minRandom, int maxRand)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minRandom, maxRand);
    }

}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.Write("Введите размер массива: ");
int size = InputNumber();
int[] array = new int[size];
Console.Write("Введите минимальное для рандома: ");
int min = InputNumber();
Console.Write("Введите максимальное для рандома: ");
int max = InputNumber();
CreateArray(array, min, max);
PrintArray(array);
