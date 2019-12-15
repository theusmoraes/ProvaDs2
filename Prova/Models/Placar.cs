using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Models {
    public class Placar {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Jogador é obrigatorio")]
        [Display (Name = "Jogador")]
        public int IdJogador { get; set; }

        [Required(ErrorMessage = "Campo Pontos é obrigatorio")]
        [Range(0, 999999,ErrorMessage = "Campo Pontos não pode ser negativo")]
        public int Pontos { get; set; }
        [Required(ErrorMessage = "Campo Data é obrigatorio")]
        [Display (Name = "Data")]
        [DataType(DataType.Date)]

        public DateTime DataPonto { get; set; }

        public Jogador Jogador { get; set; }

    }
}
