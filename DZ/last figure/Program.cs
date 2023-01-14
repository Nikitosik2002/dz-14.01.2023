System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 >= 1 && number / 100 < 10)
{
int last_number = number % 10;
System.Console.WriteLine("Последняя цифра трехзначного числа равна " + last_number);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}