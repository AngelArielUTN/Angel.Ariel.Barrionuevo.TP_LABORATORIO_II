using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Insumo :Producto
    {
        private ePesoInsumo pesoDeInsumo; 
        public override Enum UnidadDeMedida 
        {
            get
            {
               return this.pesoDeInsumo;
            }
            set
            {
                this.pesoDeInsumo = (ePesoInsumo)value;
            }    
        }

        public Insumo():base()
        { }
        public Insumo(Producto p,ePesoInsumo pesoInsumo)
        {
            this.pesoDeInsumo = pesoInsumo;
        }
        public Insumo(int idProducto, eTipoDeProducto tipoDeProducto, string nombreProducto)
          : base(idProducto, tipoDeProducto, nombreProducto)
        { }
        public Insumo(Insumo i, ePesoInsumo pesoInsumo) : this(i.idProducto, i.tipoDeProducto, i.nombreProducto)
        {
            this.pesoDeInsumo= pesoInsumo;
        }
        
        public override string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar(p));
            sb.AppendLine(this.UnidadDeMedida.ToString());
            sb.AppendLine(this.precio.ToString());
            sb.AppendLine(this.cantidadEnExistencia.ToString());
            sb.AppendLine(this.Proveedor.ToString());
            return sb.ToString();
        }
    }
}
