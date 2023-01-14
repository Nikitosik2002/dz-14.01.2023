System.Console.WriteLine("Введите делимое");
int divisible = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите делитьель");
int divider = Convert.ToInt32(Console.ReadLine());

if (divisible % divider == 0)
{
    System.Console.WriteLine("Делитель кратен делимому, ответ = " + divisible / divider);
}
else
{
    System.Console.WriteLine("Делитель не кратен делимому, остаток от деления = " + divisible % divider);
}