using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Desafio1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        public Telefono(string estado) 
        {
            this.estado = estado;
        }

        private string modelo, marca, numerotelefonico, estado;
        private int codigooperador;

        public string getModelo
        {
            get { return modelo; }
        }
        public string getMarca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numerotelefonico; }
            set { numerotelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigooperador;}
            set { if (value == 1)
                    codigooperador = 1;
                else if (value == 2)
                    codigooperador = 2;
                else if (value == 3)
                    codigooperador = 3;
                else codigooperador = 0;
                    codigooperador = value; }
        }
         public string Estado
        {
            get { return "El estado del telefono es: " + estado; }
            set { estado = value; }
        }
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
           return "LLamando a " + contacto;
        }


    }
}
