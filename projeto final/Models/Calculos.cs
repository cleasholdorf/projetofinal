using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class Calculos 
    {
        [Key]
        public int Id { get; set; } 
        
        public List<CalculoParametro> CalculoParametro { get; set; }
    }
}
