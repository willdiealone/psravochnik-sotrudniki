using System;
using System.IO;
using static System.Console;
namespace Дз_6_модуль
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            static void WriteText(string path)                       //Метод записи файла
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    char key = 'д';
                    do
                    {
                        string note = string.Empty;
                        Clear();
                        WriteLine("\nВведите ID сотрудника:");
                        note += $"\n{ReadLine()}#";
                        
                        string now = DateTime.Now.ToString();
                        WriteLine($"\nДата и время добавления записи:{now}");
                        note += $"{now}#";
                        
                        WriteLine("\nВведите Ф.И.О сотрудника:");
                        note += $"{ReadLine()}#";
                        
                        WriteLine("\nВведите возраст сотрудника:");
                        note += $"{ReadLine()}#";
                        
                        WriteLine("\nВведите рост работника:");
                        note += $"{ReadLine()}#";
                        
                        WriteLine("\nВведите дату рождения сотрудника:");
                        note += $"{ReadLine()}#";
                        
                        WriteLine("\nВведиет место рождения сотрудника:");
                        note += $"{ReadLine()}#";
                        sw.Write(note);

                        WriteLine("\nЧтобы добавить еще одного сотруника нажмите - д\n" +
                                  "Чтобы выйти нажмите - enter"); 
                        key = ReadKey(true).KeyChar;
                    } while (char.ToLower(key) == 'д');
                }
            }


            static void ReadText(string path)                       //Метод для чтения из файла
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('#');
                        Clear();
                        WriteLine($"{data[0]}\n{data[1]}\n{data[2]}\n{data[3]}\n{data[4]}\n{data[5]}\n{data[6]}");
                    }
                }
            }

            string path = "/Users/lilrockstar/Desktop/Write.txt";
            WriteLine("Нажмите 1 чтобы вывести данные на экран\nНажмите 2 чтобы добавить новую запись в файл");
            int number = int.Parse(ReadLine());
            switch (number)
            {
                case 1: ReadText(path);break;
                case 2: WriteText(path);break;
                default: Clear();WriteLine("Такой кнопки нет в списке");break;
            }
        }
    }
}