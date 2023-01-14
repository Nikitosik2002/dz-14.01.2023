System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i < number)
{
    if (i % 2 == 0)
{
    System.Console.WriteLine(i);
    System.Console.WriteLine("");
}
i++;
}