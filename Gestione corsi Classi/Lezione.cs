using System;
using System.Collections.Generic;
using System.Text;

namespace Gestione_corsi_Classi
{
    public class Lezione
    {

        string escrizione { get; set; }
        DateTime data { get; set; }
        DateTime inizio { get; set; }
        int durata { get; set; }
        Docente docente { get; set; }
        List<Assenza> Assenze { get; set; }

        public Lezione(string escrizione, DateTime data, DateTime inizio, int durata, Docente docente)
        {
            this.escrizione = escrizione;
            this.data = data;
            this.inizio = inizio;
            this.durata = durata;
            this.docente = docente;
            Assenze = new List<Assenza>();
        }

    }
}
