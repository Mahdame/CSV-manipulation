using CsvHelper.Configuration.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csv_to_db
{
    public class Contato
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FName { get; set; }
        [StringLength(75)]
        public string LName { get; set; }
        [StringLength(10)]
        public string Title { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public int Mobile { get; set; }
        [StringLength(100)]
        public string Address1 { get; set; }
        [StringLength(100)]
        public string Address2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(10)]
        public int Zip { get; set; }
        [StringLength(30)]
        public string State { get; set; }
        [StringLength(10)]
        public string CountryId { get; set; }
        [StringLength(5)]
        public string Lang { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
