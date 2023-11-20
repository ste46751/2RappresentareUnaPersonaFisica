using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _2RappresentareUnaPersonaFisica
{
    internal class Program
    {
        public class Dati
        {
            protected int codice;
            protected string congome;
            protected string nome;
            protected bool registrato;

            public Dati(int codice, string congome, string nome, bool registrato)
            {
                this.codice = codice;
                this.congome = congome;
                this.nome = nome;
                this.registrato = registrato;
            }

        }
        public void ControlloReg()
        {
            Console.WriteLine("Vuoi registrare? (sì, no)");
            string c=Console.ReadLine();

            if(c== "si" || c=="sì")
            {
                
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
