

namespace ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            //    int number = int.Parse(Console.ReadLine());

            //    if (number < 1 || number > 100)
            //    {
            //        Console.WriteLine("Число вне диапазона!");
            //    }
            //    else if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number);
            //    }

            //Task 2

            //Console.Write("Введите число: ");
            //double value = double.Parse(Console.ReadLine());

            //Console.Write("Введите процент: ");
            //double percent = double.Parse(Console.ReadLine());

            //double result = (value * percent) / 100;
            //Console.WriteLine(result);

            //Task 3

            //Console.WriteLine("Введите четыре цифры по одной:");

            //Console.Write("Первая цифра: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Вторая цифра: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Третья цифра: ");
            //int num3 = int.Parse(Console.ReadLine());

            //Console.Write("Четвёртая цифра: ");
            //int num4 = int.Parse(Console.ReadLine());


            //int result = num1 * 1000 + num2 * 100 + num3 * 10 + num4;

            //Console.WriteLine($"Сформированное число: {result}");

            //Task 4

            //Console.Write("Введите шестизначное число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 100000 || number > 999999)
            //{
            //    Console.WriteLine("Ошибка: необходимо ввести шестизначное число.");
            //    return;
            //}

            //int firstDigit = number / 100000;
            //int secondDigit = (number / 10000) % 10;
            //int thirdDigit = (number / 1000) % 10;
            //int fourthDigit = (number / 100) % 10;
            //int fifthDigit = (number / 10) % 10;
            //int sixthDigit = number % 10;

            //int newNumber = sixthDigit * 100000 + secondDigit * 10000 + thirdDigit * 1000
            //                + fourthDigit * 100 + fifthDigit * 10 + firstDigit;

            //Console.WriteLine($"Результат после обмена: {newNumber}");

            //Task 5

            //Console.Write("Введите дату в формате дд.мм.гггг: ");
            //string input = Console.ReadLine();

            //int day = int.Parse(input.Substring(0, 2));
            //int month = int.Parse(input.Substring(3, 2));
            //int year = int.Parse(input.Substring(6, 4));


            //string season = "";
            //if (month == 12 && day >= 21 || month == 1 || month == 2 || month == 3 && day < 21)
            //    season = "Winter";
            //else if (month == 3 && day >= 21 || month == 4 || month == 5 || month == 6 && day < 21)
            //    season = "Spring";
            //else if (month == 6 && day >= 21 || month == 7 || month == 8 || month == 9 && day < 23)
            //    season = "Summer";
            //else if (month == 9 && day >= 23 || month == 10 || month == 11 || month == 12 && day < 21)
            //    season = "Autumn";


            //string dayOfWeek = "";
            //int totalDays = (month - 1) * 30 + day; 
            //totalDays += (year - 2000) * 365; 


            //switch (totalDays % 7)
            //{
            //    case 0:
            //        dayOfWeek = "Saturday";
            //        break;
            //    case 1:
            //        dayOfWeek = "Sunday";
            //        break;
            //    case 2:
            //        dayOfWeek = "Monday";
            //        break;
            //    case 3:
            //        dayOfWeek = "Tuesday";
            //        break;
            //    case 4:
            //        dayOfWeek = "Wednesday";
            //        break;
            //    case 5:
            //        dayOfWeek = "Thursday";
            //        break;
            //    case 6:
            //        dayOfWeek = "Friday";
            //        break;
            //}

            //Console.WriteLine($"{season} {dayOfWeek}");

            //Task 6

            //Console.WriteLine("Выберите конвертацию:");
            //Console.WriteLine("1. Фаренгейт в Цельсий");
            //Console.WriteLine("2. Цельсий в Фаренгейт");
            //Console.Write("Введите номер варианта (1 или 2): ");

            //int choice = int.Parse(Console.ReadLine());
            //double temperature, convertedTemperature;

            //if (choice == 1)
            //{
            //    Console.Write("Введите температуру в Фаренгейтах: ");
            //    temperature = double.Parse(Console.ReadLine());
            //    convertedTemperature = (temperature - 32) * 5 / 9; 
            //    Console.WriteLine($"Температура в Цельсии: {convertedTemperature}");
            //}
            //else if (choice == 2)
            //{
            //    Console.Write("Введите температуру в Цельсиях: ");
            //    temperature = double.Parse(Console.ReadLine());
            //    convertedTemperature = (temperature * 9 / 5) + 32;
            //    Console.WriteLine($"Температура в Фаренгейтах: {convertedTemperature}");
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка: неверный выбор.");
            //}

            //Task 7

            Console.Write("Введите первое число: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int end = int.Parse(Console.ReadLine());

            
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            Console.WriteLine($"Чётные числа в диапазоне от {start} до {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}