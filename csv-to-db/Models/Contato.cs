using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csv_to_db
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
                
        public string FName { get; set; }
        public string LName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string State { get; set; }
        public string CountryId { get; set; }
        public string Lang { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
