using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;



//Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
//Шакун Кирилл
namespace ConvertCSVtoXML
{
    class Program
    {
        static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentIndo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }

        static void Main(string[] args)
        {
            Converter("..\\..\\students_6.csv", "..\\..\\students_8.xml");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Готово!");
            Console.ReadKey();
        }
    }
}
