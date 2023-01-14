System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int last_number = number % 10;
int second_number = number % 100;
second_number = second_number / 10;
System.Console.WriteLine("Третья цифра трехзначного числа = " + last_number);
System.Console.WriteLine("Вторая цифра трехзначного числа = " + second_number);