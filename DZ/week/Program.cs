System.Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = Convert.ToInt16(Console.ReadLine());

if(number == 1)
{
    System.Console.WriteLine("Сегодня понедельник");
}
else if(number == 2)
{
    System.Console.WriteLine("Сегодня вторник");
}
else if(number == 3)
{
    System.Console.WriteLine("Сегодня среда");
}
else if(number == 4)
{
    System.Console.WriteLine("Сегодня четверг");
}
else if(number == 5)
{
    System.Console.WriteLine("Сегодня пятница");
}
else if(number == 6)
{
    System.Console.WriteLine("Сегодня суббота");
}
else 
{
    System.Console.WriteLine("Сегодня воскресенье");
}