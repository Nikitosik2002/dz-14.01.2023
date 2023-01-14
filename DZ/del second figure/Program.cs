System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int first_number = number / 100;
int third_number = number % 10;
int new_number = int.Parse(first_number.ToString() + third_number.ToString());
System.Console.WriteLine(new_number);
