using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida:Producto
    {
        private eTipoBebida tipoBebida;
        private eVolumenBotella volumenDeBotella;

        public eTipoBebida TipoBebida
        {
            get
            {
                return this.tipoBebida;
            }
            set
            {
                this.tipoBebida = value;
            }
        }

        public override Enum UnidadDeMedida
        {
            get
            {
                return this.volumenDeBotella;
            }
            set
            {
                this.volumenDeBotella = (eVolumenBotella)value;
            }
        }

        public Bebida():base()
        { }

        public Bebida(int idProducto, eTipoDeProducto tipoDeProducto, string nombreProducto) 
            : base(idProducto, tipoDeProducto,nombreProducto)
        { }
        public Bebida(Bebida b, eVolumenBotella volumenBotella):this(b.idProducto,b.tipoDeProducto,b.nombreProducto)
        {
            this.volumenDeBotella = volumenBotella;
        }

        public Bebida(Bebida b, eVolumenBotella volumenBotella, float precioUnitario, int cantidadEnExistencia) 
            : this(b, volumenBotella)
        {
            this.precio = precioUnitario;
            this.cantidadEnExistencia = cantidadEnExistencia;
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
