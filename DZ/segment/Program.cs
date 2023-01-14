var number = new Random().Next(10, 99);
System.Console.WriteLine(number);

int first_number = number / 10;
int second_number = number % 10;

if (first_number > second_number)
{
    System.Console.WriteLine("Большая цифра = " + first_number);
}
else if (second_number > first_number)
{
    System.Console.WriteLine("Большая цифра = " + second_number);
}
else
{
    System.Console.WriteLine("Большей цифры нет, цифры равны ");
}



