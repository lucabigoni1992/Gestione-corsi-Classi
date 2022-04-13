using System;
using System.Collections.Generic;
using System.Text;

namespace Gestione_corsi_Classi
{
    public class Docente : IPersone
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string TitoloDiStudio { get; set; }
        public Docente(string nome, string cognome, string titoloDiStudio)
        {
            this.nome = nome;
            this.cognome = cognome;
            TitoloDiStudio = titoloDiStudio;
        }
    }
}
