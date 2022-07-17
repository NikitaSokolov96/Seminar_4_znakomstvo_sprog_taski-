// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

static void summaArray(string[] args)
{
    int n;
    Console.WriteLine("Сколько будет цыфор");
    n = int.Parse(Console.ReadLine());
    int[] massiv = new int[n];
    Console.WriteLine("Что суммируем? "); //тут вводить по очереди
    for (int i = 0; i < n; i++)
    {
        massiv[i] = int.Parse(Console.ReadLine());
    }
    int Sum = 0;
    for (int i = 0; i < n; i++)
    {
       Sum+=massiv[i];
    }
    Console.WriteLine("Сумма="+Sum);
}
summaArray(args);