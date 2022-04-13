using System;
using System.Collections.Generic;
using System.Text;

namespace Gestione_corsi_Classi
{
    internal class Aula
    {
        int capienza { get; set; }
        string nome { get; set; }
        /// <summary>
        /// es. Video Proiettore, PC, Notebook, Tablet, LIM, etc.).
        /// </summary>
        List<string> Risorse { get; set; }
    }
}
