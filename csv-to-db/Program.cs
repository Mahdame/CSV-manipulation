using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using Z.BulkOperations;

namespace csv_to_db
{
    class Program
    {
        public static void Main()
        {
            List<Contato> contatos = new List<Contato>();

            string line;
            int counter = 0;
            string[] columns;
            string[] rows;

            var file = new StreamReader(@"{caminho do arquivo .csv}");

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
                    contato.Mobile = rows[5];
                    contato.Address1 = rows[6];
                    contato.Address2 = rows[7];
                    contato.City = rows[8];
                    contato.Zip = Convert.ToInt32(rows[9]);
                    contato.State = rows[10];
                    contato.CountryId = rows[11];
                    contato.Lang = rows[12];
                    contato.Birthdate = Convert.ToDateTime(rows[13]);

                    contatos.Add(contato);
                }
                counter++;
            }

            var connection = new SqlConnection(@"{connection string}");

            connection.Open();

            var bulk = new BulkOperation<Contato>(connection);

            bulk.DestinationTableName = "Contatos";
            bulk.ColumnInputExpression = c => new { c.FName, c.LName, c.Title, c.Email, c.Mobile, c.Address1, c.Address2, c.City, c.Zip, c.State, c.CountryId, c.Lang, c.Birthdate };
            bulk.ColumnOutputExpression = c => c.Id;
            bulk.ColumnPrimaryKeyExpression = c => c.Id;

            bulk.BulkInsert(contatos);
            //bulk.BulkUpdate(contatos);
        }
    }
}
