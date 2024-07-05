using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comensal
    {
        private sbyte idMesa;

        public Comensal()
        { }

        public Comensal(int dni, string nombre, string pasword, bool usaEstacionanmiento, sbyte idMesa, byte puntaje, eMedioDePago medioDePago)
            : base()
        {
            this.idMesa = idMesa;
        }
    }
}
