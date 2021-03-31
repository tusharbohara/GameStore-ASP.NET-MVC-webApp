using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Models
{
    // Game M - 1 Category 
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage ="Maximum 1000 characters")]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string MinPcRequirements { get; set; }
        public int CategoryId { get; set; }
        // stores category id 

        [ForeignKey("CategoryId")]
        public virtual Category Cat { get; set; }
        // holds category object to store overall data of category
    }

    // Category class can be kept separately in new class 

    public class Category { 
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Game> Games { get; set; } // can fetch many games from game model
    }
}
