using System;

namespace ConsoleApp2
{
    internal class Persona
    {
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public int Eta { get; set; }
        public Persona(string Nome, string Cognome, int Eta)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Eta = Eta;
        }

        public void GetNome()
        {
            Console.WriteLine("Inserire il nome: ");
            Nome = Console.ReadLine();
        }
        public void GetCognome()
        {
            Console.WriteLine("Inserire il cognome: ");
            Cognome = Console.ReadLine();
        }
        public void GetEta()
        {
            Console.WriteLine("Inserisci l'eta': ");
            Eta = int.Parse(Console.ReadLine());
        }
        public void GetDettagli()
        {
            Console.WriteLine($"La persona si chiama: {Nome}, il suo cognome e' {Cognome} e ha {Eta} anni.");
        }
    }
}