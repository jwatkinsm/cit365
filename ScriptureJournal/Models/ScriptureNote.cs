using System;
using System.ComponentModel.DataAnnotations;


namespace ScriptureJournal.Models
{
    public class ScriptureNote
    {
        public int ID { get; set; }
        //book varaibales
        [Required]
        public string Book { get; set; }
        [Required]
        public string Chapter { get; set; }
        [Required]
        public string Verse { get; set; }
        
        public string Note { get; set; }
        //date
        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

    }
}
