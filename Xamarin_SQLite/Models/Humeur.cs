using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms_SQLite.Models
{
    [Table("Humeur")]
    public class Humeur
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Commentaire { get; set; }
        public int Note { get; set; }
        public DateTime DateAjout { get; set; }





    }
}
