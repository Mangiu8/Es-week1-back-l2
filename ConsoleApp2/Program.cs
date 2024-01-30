using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("", "", 0);
            persona.GetNome();
            persona.GetCognome();
            persona.GetEta();
            persona.GetDettagli();

            Console.WriteLine("Premere Invio per uscire");
            Console.ReadLine();
        }
    }
}
