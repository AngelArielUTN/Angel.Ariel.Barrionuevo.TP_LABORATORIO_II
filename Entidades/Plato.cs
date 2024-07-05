using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Plato
    {
        public enum ETipoPlato
        {
            DesayunoMerienda,
            AlmuerzoCena
        }

        protected SByte idPlato;
        protected ETipoPlato tipoPlato;

        public Plato()
        { }
        public Plato(SByte idPlato, ETipoPlato tipoPlato)
        {
            this.idPlato = idPlato;
            this.tipoPlato = tipoPlato;
        }

        public static bool operator ==(Plato p1, Plato p2)
        {
            if ((p1 != null) && (p2 != null))
            {
                return p1.idPlato == p2.idPlato;
            }
            return false;
        }
        public static bool operator !=(Plato p1, Plato p2)
        {
            return !(p1 == p2);
        }
        public abstract string Mostrar();
    }
}
