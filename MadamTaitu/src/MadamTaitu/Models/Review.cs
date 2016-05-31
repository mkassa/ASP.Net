using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Models
{
    public class Review 
    {
        [Key]
        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
