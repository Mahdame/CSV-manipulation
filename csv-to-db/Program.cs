using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;

namespace csv_to_db
{
    class Program
    {
        public static void Main()
        {
            var connection = new SqlConnection(@"server=localhost,1433;database=csvtodb;User ID=SA;Password=1q2w3e4r!@#$");

            //Contato contato = new Contato();
            List<Contato> contatos = new List<Contato>();

            string line;
            int counter = 0;

            string[] columns;
            string[] rows;

            var file = new StreamReader(@"C:\Users\maira\dev\CSV-to-DB\csv-to-db\database.csv");

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);

                if (counter == 0)
                {
                    columns = line.Split(";");
                }
                else
                {
                    Contato contato = new Contato();

                    rows = line.Split(";");
                    contato.Id = Convert.ToInt32(rows[0]);
                    contato.FName = rows[1];
                    contato.LName = rows[2];
                    contato.Title = rows[3];
                    contato.Email = rows[4];

                    contatos.Add(contato);
                }
                counter++;
            }
            
            var teste = contatos;
            //var bulk = new BulkOperation<Contato>(connection);
            //bulk.ColumnInputExpression = c => new { c.FName, c.LName, c.Title, c.Email, c.Mobile, c.Address1, c.Address2, c.City, c.Zip, c.State, c.CountryId, c.Lang, c.Birthdate };
            //bulk.ColumnOutputExpression = c => c.Id;
            //bulk.ColumnPrimaryKeyExpression = c => c.Id;
            //bulk.BulkMerge(file);
        }
    }
}
