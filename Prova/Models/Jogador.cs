using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Models {
    public class Jogador {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Idade é obrigatorio")]
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }
    }
}
