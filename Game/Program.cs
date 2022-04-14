do // Цикл
{
    Console.ForegroundColor = ConsoleColor.Green; // Цвет текста = зелёный
    Console.WriteLine("Компьютер загадывает число от 1 до 10..."); //Вывод
    Console.WriteLine("Ваша задача - отгадать это число. Удачи! ;-)"); // Вывод
    int num = new Random().Next(1, 10); // Рандомит число от 1 до 10 и записывает в num
    Console.ForegroundColor = ConsoleColor.Red; // Цвет текста = красный
    Console.Write("Введите число: "); // Вывод
    var num1 = Console.ReadLine(); // Ввод числа от пользователя
    int Num1; // Целочисленная переменная
    bool IsNum = int.TryParse(num1, out Num1); // IsNum = true or false, если num1 - это число, то значение = true
    while (IsNum == false) // Цикл, пока IsNum имеет значение false
    {
        Console.Write("Это не число, попробуй ещё раз: "); // Вывод
        num1 = Console.ReadLine(); // Ввод число от пользователся
        IsNum = int.TryParse(num1, out Num1); // IsNum = true or false, если num1 - это число, то значение = true
    }
    while (Num1 > 10 | Num1 < 1) // Цикл, пока Num1 > 10 или < 1
    {
        if (Num1 > 10) // Если больше 10
        {
            Console.WriteLine("Смысл вводить число больше 10? xD"); // Вывод
            Console.Write("Не дури, введи число ещё раз: "); // Вывод
            var num2 = Console.ReadLine(); // Ввод число от пользователя
            int Num2; // Целочисленная переменная
            bool IsNum2 = int.TryParse(num2, out Num2); // IsNum2 = true or false, если num1 - это число, то значение = true
            Num1 = Num2; // Значение из Num2 перетекает в Num1
            while (IsNum2 == false) // Цикл, пока IsNum имеет значение false
            {
                Console.Write("Это не число, попробуй ещё раз: "); // Вывод
                num2 = Console.ReadLine(); // Ввод число от пользователя
                IsNum2 = int.TryParse(num2, out Num2); // IsNum2 = true or false, если num1 - это число, то значение = true
                Num1 = Num2; // Значение из Num2 перетекает в Num1
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
    if (num == Num1) // Условия к победе
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы победили! Ура-ура!!!");
        Console.Write("Загаданное число - ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num);
    }
    else // Лошара, проиграл
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Вы проиграли! Попробуйте ещё раз. :-(");
        Console.Write("Загаданное число - ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(num);
    }
    Console.WriteLine("Нажмите Y, чтобы сыграть ещё раз! :-)");
}
while (Console.ReadKey(true).Key == ConsoleKey.Y); // Условие цикла, Если пользователь нажмёт кнопку Y, то идём на повтор