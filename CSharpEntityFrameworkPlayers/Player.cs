using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayers
{
    [Table("player")]
    
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int score { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesWon { get; set; }
    }
}
