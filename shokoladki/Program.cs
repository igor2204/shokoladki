using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите имеющиеся деньги: ");
        int money = int.Parse(Console.ReadLine());

        Console.Write("Введите цену за шоколадку: ");
        int price = int.Parse(Console.ReadLine());

        Console.Write("Введите количество обёрток для получения ещё одной шоколадки: ");
        int wrap = int.Parse(Console.ReadLine());

        int chocolates = money / price; // Получаем количество шоколадок, которое можно купить за имеющиеся деньги
        int wrappers = chocolates; // Изначально у нас количество обёрток равно количеству шоколадок

        while (wrappers >= wrap) // Цикл продолжается, пока у нас хватает обёрток для получения новой шоколадки
        {
            int newChocolates = wrappers / wrap; // Вычисляем новое количество шоколадок
            chocolates += newChocolates; // Увеличиваем общее количество шоколадок
            wrappers = newChocolates + wrappers % wrap; // Вычисляем новое количество обёрток
        }

        Console.WriteLine("Максимальное количество шоколадок: " + chocolates);
    }
}
