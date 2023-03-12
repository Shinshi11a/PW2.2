using System;

public class NumberManager
{
    private int n = 0;

    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return n + 1;
    }
}

class Program
{
    static void Main()
    {
        NumberManager numberManager = new NumberManager();

        while (true)
        {
            Console.Write($"Введите число {numberManager.GetExpectedNumber()}: ");
            int inputNumber;
            if (int.TryParse(Console.ReadLine(), out inputNumber))
            {
                if (numberManager.SetNumber(inputNumber))
                {
                    Console.WriteLine("Верно!");
                }
                else
                {
                    Console.WriteLine("Неверно! Начинаем сначала.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода! Попробуйте еще раз.");
            }
        }
    }
}