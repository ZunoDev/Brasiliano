using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Brasiliano.Data.Model

{
    public class Estado
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
