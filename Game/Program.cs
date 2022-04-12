do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Компьютер загадывает число от 1 до 10...");
    Console.WriteLine("Ваша задача - отгадать это число. Удачи! ;-)");
    int num = new Random().Next(1, 10);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Введите число: ");
    var num1 = Console.ReadLine();
    int Num1;
    bool IsNum = int.TryParse(num1, out Num1);
    while (IsNum == false)
        if (IsNum == false)
        {
            Console.Write("Это не число, попробуй ещё раз: ");
            num1 = Console.ReadLine();
            IsNum = int.TryParse(num1, out Num1);
        }
    while (Num1 > 10 | Num1 < 1)
    {
        if (Num1 > 10)
        {
            Console.WriteLine("Смысл вводить число больше 10? xD");
            Console.Write("Не дури, введи число ещё раз: ");
            var num2 = Console.ReadLine();
            int Num2;
            bool IsNum2 = int.TryParse(num2, out Num2);
            Num1 = Num2;
            while (IsNum2 == false)
                if (IsNum2 == false)
                {
                    Console.Write("Это не число, попробуй ещё раз: ");
                    num2 = Console.ReadLine();
                    IsNum2 = int.TryParse(num2, out Num2);
                    Num1 = Num2;
                }
        }
        if (Num1 < 1)
        {
            Console.WriteLine("Смысл вводить число меньше 1? xD");
            Console.Write("Не дури, введи число ещё раз: ");
            var num2 = Console.ReadLine();
            int Num2;
            bool IsNum2 = int.TryParse(num2, out Num2);
            Num1 = Num2;
            while (IsNum2 == false)
                if (IsNum2 == false)
                {
                    Console.Write("Это не число, попробуй ещё раз: ");
                    num2 = Console.ReadLine();
                    IsNum2 = int.TryParse(num2, out Num2);
                    Num1 = Num2;
                }
        }
    }
    if (num == Num1)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы победили! Ура-ура!!!");
        Console.Write("Загаданное число - ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы проиграли! Попробуйте ещё раз. :-(");
        Console.Write("Загаданное число - ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num);
    }
    Console.WriteLine("Нажмите Y, чтобы сыграть ещё раз! :-)");
}
while (Console.ReadKey(true).Key == ConsoleKey.Y);