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
        public int Score { get; set; }
        public int MatchesPlayed { get; set; }
        public int MatchesWon { get; set; }

        //FK Relazione Molti (Entità Player) a uno (Entità Team)
        public int TeamId { get; set; }
        public Team Team { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
