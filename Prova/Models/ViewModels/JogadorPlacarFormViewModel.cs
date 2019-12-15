using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Models.ViewModels {
    public class JogadorPlacarFormViewModel {
        public Placar PlacarP { get; set; }
        public ICollection<Jogador> Jogadores { get; set; }

    }
}
