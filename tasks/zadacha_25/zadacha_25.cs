// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

void mathpoww(double A, double B)
{
    double Sum = 0;
    for (double i = 0; i < A; i++)
    {
        Sum = Math.Pow(A, B);
    }
    Console.WriteLine(Sum);
}
mathpoww(3,5);
mathpoww(2,4);