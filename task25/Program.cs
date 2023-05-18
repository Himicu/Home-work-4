// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Exponentiate(int baseNum, int degree)
{
    int result = baseNum;
    for (int i = 1; i < degree; i++)
    {
        result *= baseNum;
    }
    return result;
}
int A = InputNumber();
int B = InputNumber();
int result = Exponentiate(A, B);
Console.WriteLine($"Результат {A} в степени {B} = {result}");