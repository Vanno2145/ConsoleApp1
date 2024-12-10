using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Programmm
{
    static void Main()
    {
        
        Console.WriteLine("Введите путь к файлу с текстом:");
        string textFilePath = Console.ReadLine();

        Console.WriteLine("Введите путь к файлу со словами для модерации:");
        string wordsFilePath = Console.ReadLine();

      
        if (!File.Exists(textFilePath) || !File.Exists(wordsFilePath))
        {
            Console.WriteLine("Один или оба файла не найдены. Завершаем программу.");
            return;
        }

        try
        {
            
            List<string> moderationWords = new List<string>(File.ReadAllLines(wordsFilePath));

            
            using (FileStream fs = new FileStream(textFilePath, FileMode.Open, FileAccess.ReadWrite))
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                StringBuilder content = new StringBuilder();
                string line;
                int replacementCount = 0;

                
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string word in moderationWords)
                    {
                        
                        if (line.Contains(word))
                        {
                            int wordLength = word.Length;
                            string replacement = new string('*', wordLength);
                            line = line.Replace(word, replacement);
                            replacementCount++;
                        }
                    }

                    
                    content.AppendLine(line);
                }

                
                fs.Seek(0, SeekOrigin.Begin);

                
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.Write(content.ToString());
                }

               
                Console.WriteLine($"Произведено {replacementCount} замен.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
