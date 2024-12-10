using System;
using System.IO;

class Programmmmm
{
    static void Main()
    {
        
        Console.WriteLine("Введите путь к файлу с числами:");
        string inputFilePath = Console.ReadLine();

        
        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("Файл не найден.");
            return;
        }

       
        int positiveCount = 0, negativeCount = 0, twoDigitCount = 0, fiveDigitCount = 0;

       
        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] numbers = line.Split(new[] { ' ', '\t', ',', ';', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var numStr in numbers)
                {
                    if (int.TryParse(numStr, out int number))
                    {
                        
                        if (number > 0) positiveCount++;
                        
                        if (number < 0) negativeCount++;
                        
                        if (Math.Abs(number) >= 10 && Math.Abs(number) < 100) twoDigitCount++;
                        
                        if (Math.Abs(number) >= 10000 && Math.Abs(number) < 100000) fiveDigitCount++;
                    }
                }
            }
        }

        
        Console.WriteLine($"Положительные числа: {positiveCount}");
        Console.WriteLine($"Отрицательные числа: {negativeCount}");
        Console.WriteLine($"Двузначные числа: {twoDigitCount}");
        Console.WriteLine($"Пятизначные числа: {fiveDigitCount}");

       
        CreateFileWithNumbers(inputFilePath, "positive_numbers.txt", positiveCount, 0, 1);
        CreateFileWithNumbers(inputFilePath, "negative_numbers.txt", negativeCount, 0, -1);
        CreateFileWithNumbers(inputFilePath, "two_digit_numbers.txt", twoDigitCount, 10, 100);
        CreateFileWithNumbers(inputFilePath, "five_digit_numbers.txt", fiveDigitCount, 10000, 100000);
    }

    static void CreateFileWithNumbers(string inputFilePath, string outputFilePath, int count, int lowerLimit, int upperLimit)
    {
        
        using (StreamReader reader = new StreamReader(inputFilePath))
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] numbers = line.Split(new[] { ' ', '\t', ',', ';', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var numStr in numbers)
                {
                    if (int.TryParse(numStr, out int number))
                    {
                        if (number > lowerLimit && number < upperLimit)
                        {
                            writer.WriteLine(number);
                        }
                    }
                }
            }
        }

        Console.WriteLine($"Числа записаны в файл: {outputFilePath}");
    }
}
