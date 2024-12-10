using System;
using System.IO;

class Programmmm
{
    static void Main()
    {
        
        Console.WriteLine("Введите путь к исходному файлу:");
        string inputFilePath = Console.ReadLine();

       
        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("Файл не найден. Завершаем программу.");
            return;
        }

        
        string outputFilePath = "reversed_" + Path.GetFileName(inputFilePath);

        try
        {
            
            using (FileStream fs = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs))
            {
               
                string content = reader.ReadToEnd();

                
                string reversedContent = ReverseContent(content);

                
                using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(outputStream))
                {
                    
                    writer.Write(reversedContent);
                }

                
                Console.WriteLine($"Содержимое файла перевернуто и сохранено в {outputFilePath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    
    static string ReverseContent(string content)
    {
        
        var lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        Array.Reverse(lines);
        return string.Join(Environment.NewLine, lines);
    }
}
