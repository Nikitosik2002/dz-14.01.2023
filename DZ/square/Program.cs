System.Console.WriteLine("Введите первое число");
int first_number = Convert.ToInt16(Console.ReadLine());
 System.Console.WriteLine("Введите второе число");
int second_number = Convert.ToInt16(Console.ReadLine());

    if (first_number == second_number * second_number)
    {
        System.Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        System.Console.WriteLine("Первое число не является квадратом второго");
    }
