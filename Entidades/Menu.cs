using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Menu
    {
        private List<Plato> platos;

        public List<Plato> Platos
        {
            get
            {
                return this.platos;
            }
            set
            {
                this.platos = value;
            }
        }

        public Menu()
        {
            this.platos = new List<Plato>();
        }

        public static bool operator ==(Menu m, Plato p)
        {
            foreach (Plato item in m.Platos)
            {
                if (item != null && p != null)
                {
                    if (item == p)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public static bool operator !=(Menu m, Plato p)
        {
            return !(m == p);
        }

        public static Menu operator +(Menu m, Plato p)
        {
            if (m != p)
            {
                m.Platos.Add(p);
            }
            return m;
        }
        public static Menu operator -(Menu m, Plato p)
        {
            if (m != p)
            {
                m.Platos.Remove(p);
            }
            return m;
        }

        public static string mostrar(Menu m)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Plato item in m.Platos)
            {
                if (item != null)
                {
                    sb.AppendLine($"{item.Mostrar()}");
                }
            }
            return sb.ToString();
        }
    }
}
