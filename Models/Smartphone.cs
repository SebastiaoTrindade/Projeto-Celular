using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private int Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação...");
        }

        public void MostrarNumero()
        {
            Console.WriteLine(this.Numero);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
