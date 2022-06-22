using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Senha { get; set; }
        public List<Calculos> listaCalculos { get; set;}

}
}
