System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int first_number = number / 100;
int third_number = number % 10;
System.Console.Write(first_number);
System.Console.WriteLine(third_number);