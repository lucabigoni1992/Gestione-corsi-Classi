using System;
using System.Collections.Generic;
using System.Text;

namespace Gestione_corsi_Classi
{
    public class GestioneCorsi
    {
        List<Corso> ListCorsi { get; set; }

        public GestioneCorsi() { 
            ListCorsi = new List<Corso>();
        }
        public void add(Corso c)
        {
            ListCorsi.Add(c);
        }
    }
}
