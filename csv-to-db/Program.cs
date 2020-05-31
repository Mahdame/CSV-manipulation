using System;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;

namespace csv_to_db
{
    class Program
    {
        public static void Main()
        {
            var context = new DataContext();

            Console.WriteLine("Hello World!");

            var reader = new StreamReader(@"C:\Users\maira\dev\CSV-to-DB\csv-to-db\data.CSV");
            var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csvReader.GetRecords<Contato>().ToList();

            foreach (var contato in context.Contatos)
            {
                Console.WriteLine(contato.FName);
            }
        }
    }
}
