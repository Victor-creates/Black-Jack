using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack.Clases
{
    public class Cartas
    {
        public int Id {  get; set; }
        public int Valor { get; set; }
        public string Palo { get; set; }

        public Cartas(int id, int valor, string palo)
        {
            this.Id = id;
            this.Valor = valor;
            this.Palo = palo;
        }
    }
}
