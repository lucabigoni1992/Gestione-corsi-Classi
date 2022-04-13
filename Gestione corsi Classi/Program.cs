using System;
using System.Collections.Generic;

namespace Gestione_corsi_Classi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studenti> listaStudenti = new List<Studenti>();

            Corso c = new Corso("Programmazione c#", 158);
            c.AddStudenti(new Studenti() { nome = "Luca", cognome = "Bigoni", Matricola = "LuBig001" });
            c.AddStudenti(new Studenti() { nome = "Mario", cognome = "Bigoni", Matricola = "maBig001" });
            c.AddStudenti(new Studenti() { nome = "Giacomo", cognome = "Bigoni", Matricola = "giBig001" });
            Docente d = new Docente("NomeDocente", "cognomeDocente", "Laurea in informatica");
            Docente d2 = new Docente("NomeDocente", "cognomeDocente", "Laurea in informatica");
            c.AddLezioni(new Lezione("lezione 1", DateTime.Now, DateTime.UtcNow, 60, d));
            c.AddLezioni(new Lezione("lezione 2", DateTime.Now, DateTime.UtcNow, 60, d));
            c.AddLezioni(new Lezione("lezione 3", DateTime.Now, DateTime.UtcNow, 60, d));
            c.AddLezioni(new Lezione("lezione 4", DateTime.Now, DateTime.UtcNow, 60, d2));

            GestioneCorsi gc = new GestioneCorsi();
            gc.add(c);

            /*
             
             Il sistema deve consentire:

                Aggiungere corso
                Aggiungere lezioni ad un corso
                Aggiungere studenti ad un corso
                Segnare gli assenti ad una lezione

            Il sistema deve consentire le seguenti stampe a video:

                Elenco Corsi
                Elenco delle lezioni di un corso
                Elenco degli iscritti a un corso
                Scheda riassuntiva di una lezione
                Elenco dei presenti ad una lezione
                Media dei presenti ad una lezione
                Media dei presenti ad un corso (media tra le lezioni)
             
             */

        }
    }
}
