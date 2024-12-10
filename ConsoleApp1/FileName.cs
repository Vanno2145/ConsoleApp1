using System;
using System.IO;

class Programm
{
    static void Main()
    {
        
        Console.WriteLine("Введите путь к файлу:");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не найден. Завершаем программу.");
            return;
        }

       
        Console.WriteLine("Введите слово для поиска:");
        string searchWord = Console.ReadLine();
        Console.WriteLine("Введите слово для замены:");
        string replaceWord = Console.ReadLine();

        try
        {
            
            string content = File.ReadAllText(filePath);

            
            int replaceCount = 0;
            while (content.Contains(searchWord))
            {
                content = content.Replace(searchWord, replaceWord);
                replaceCount++;
            }

           
            File.WriteAllText(filePath, content);

            
            Console.WriteLine($"Заменено {replaceCount} вхождений слова '{searchWord}' на '{replaceWord}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
