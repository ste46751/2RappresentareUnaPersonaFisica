using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static _2RappresentareUnaPersonaFisica.Program;

namespace _2RappresentareUnaPersonaFisica
{
    internal class Program
    {
        public class Dati
        {
            protected int codice;
            protected string cognome;
            protected string nome;
            protected bool registrato;

            public Dati()
            {
                codice = 0303030;
                cognome = "Morandi";
                nome = "Gianni";
                registrato = false;
            }

            public void ControlloReg()
            {
                Console.WriteLine("Vuoi registrare? (sì, no)");
                string c = Console.ReadLine();

                if (c == "si" || c == "sì")
                {
                    registrato = true;
                }
                else
                {
                    registrato = false;
                }
            }

            public void stamp()
            {
                
                Console.WriteLine(codice);
                Console.WriteLine(cognome);
                Console.WriteLine(nome);

                Console.WriteLine(registrato? "si":"no");
            }
        }

        static void Main(string[] args)
        {

            Dati d = new Dati();
            d.stamp();
            d.ControlloReg();
            d.stamp();
        }
    }
}