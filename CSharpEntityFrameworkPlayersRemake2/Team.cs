using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityFrameworkPlayersRemake2
{
    [Table("team")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        public string Coach { get; set; }
        public string Colors { get; set; }

        //FK Relazione Uno (Entità Team) a Molti (Entità Player)
        public List<Player> Players { get; set; }
    }
}
