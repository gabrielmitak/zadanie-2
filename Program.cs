using System;
using System.IO;
using System.Text.RegularExpressions;
namespace tak
{
    class Program
    {
        static void Main()
        {
            string filePath = @"C:\\praktyki\\zadanie2\plik.txt";
            try
            {
                string text = File.ReadAllText(filePath);
                string newText = Regex.Replace(text, @"\bpraca\b", "job");
                string changedFilePath = Path.GetFileNameWithoutExtension(filePath) + "_changed_" + DateTime.Now.ToString("yyyyMMdd") + Path.GetExtension(filePath);
                File.WriteAllText(changedFilePath, newText);
                Console.WriteLine("Zmiany zostały zapisane w pliku: " + changedFilePath + " o adresie: C:\\\\praktyki\\\\zadanie2"); 
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Podany plik nie istnieje.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
        }
    }
}