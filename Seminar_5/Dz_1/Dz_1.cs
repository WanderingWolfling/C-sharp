﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 1000);
        }

        int evenCount = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine(numbers[]);
        Console.WriteLine("Number of even numbers: " + evenCount);
    }
}