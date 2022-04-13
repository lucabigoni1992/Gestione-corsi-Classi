using System;
using System.Collections.Generic;
using System.Text;

namespace Gestione_corsi_Classi
{
    public class Studenti : IPersone
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string Matricola { get; set; }
    }
}
