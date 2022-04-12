do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Компьютер загадывает число от 1 до 10...");
    Console.WriteLine("Ваша задача - отгадать это число. Удачи! ;-)");
    Console.Write("Введите число: ");

    int num1 = Convert.ToInt32(Console.Read());

    int num = 2;//new Random().Next(1, 10);

    Console.ForegroundColor = ConsoleColor.Red;
    if (num1 == num)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы победили! Ура-ура!!!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы проиграли! :-(");
        Console.Write("Загаданное число - ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num);
    }
    Console.WriteLine("Хотите попробовать ещё раз? :-) Нажмите Y, чтобы сыграть ещё раз");
}
while(Console.ReadKey(true).Key == ConsoleKey.Y);