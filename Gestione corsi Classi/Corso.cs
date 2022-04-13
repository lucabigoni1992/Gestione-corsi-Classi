using System;
using System.Collections.Generic;
using System.Text;

namespace Gestione_corsi_Classi
{
    public class Corso
    {

        public string nome { get; set; }
        public int numero { get; set; }
        public List<Studenti> ListStudenti { get; set; }
        public List<Lezione> Listlezioni { get; set; }

        public Corso(string nome, int numero, List<Studenti> listStudenti, List<Lezione> listlezioni)
        {
            this.nome = nome;
            this.numero = numero;
            ListStudenti = listStudenti;
            Listlezioni = listlezioni;
        }
        public Corso(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
            ListStudenti = new List<Studenti>();
            Listlezioni = new List<Lezione>();
        }
        public int GetNumeroStudenti()
        {
            return ListStudenti.Count;
        }
        public void AddStudenti(Studenti s)
        {
             ListStudenti.Add(s);
        }
        public void AddLezioni(Lezione l)
        {
            Listlezioni.Add(l);
        }
    }
}
