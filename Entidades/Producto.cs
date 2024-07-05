using System;
using System.Text;
using System.Collections.Generic;
namespace Entidades
{
    //public abstract class Producto
    public class Producto
    {
        public int idProducto;
        public eTipoDeProducto tipoDeProducto;
        public string nombreProducto;

        public Enum unidadDeMedida;

        public float precio;
        public int cantidadEnExistencia;
        public Proveedor proveedor;

        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }

        public eTipoDeProducto TipoDeProducto
        {
            get
            {
                return this.tipoDeProducto;
            }
            set
            {
                this.tipoDeProducto = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
            set
            {
                this.nombreProducto = value;
            }
        }
        //public abstract Enum UnidadDeMedida 
        //{ get; set; }

        public virtual Enum UnidadDeMedida
        {
            get
            {
                return this.unidadDeMedida;
            }
            set
            {
                this.unidadDeMedida = value;
            }
        }


        protected float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
       public int CantidadEnExistencia
        {
            get
            {
                return this.cantidadEnExistencia;
            }
            set
            {
                this.cantidadEnExistencia = value;
            }
        }
        public Proveedor Proveedor
        {
            get
            {
                return this.proveedor;
            }
            set
            {
                this.proveedor = value;
            }
        }

        public Producto()
        {
            this.proveedor = new Proveedor();
        }
        public Producto(int idProducto,eTipoDeProducto tipoDeProducto, string nombreProducto) 
            :this()
        {
            this.idProducto = idProducto;
            this.tipoDeProducto = tipoDeProducto;
            this.nombreProducto = nombreProducto;                                                                                     
        }

        public Producto(int idProducto, eTipoDeProducto tipoDeProducto, string nombreProducto, float precio, int cantidadEnExistencia)
           : this(idProducto, tipoDeProducto, nombreProducto)
        {
            this.precio = precio;
            this.cantidadEnExistencia = cantidadEnExistencia;
        }

        public Producto(int idProducto,eTipoDeProducto tipoDeProducto, string nombreProducto, float precio, int cantidadEnExistencia, Proveedor proveedor)
            : this(idProducto,tipoDeProducto, nombreProducto, precio,cantidadEnExistencia)
        {
            this.proveedor = proveedor;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if ((p1 is null) || (p2 is null))
            {
                return false;
            }

            return (p1.idProducto == p2.idProducto);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public  virtual string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.IdProducto.ToString());
            sb.AppendLine(p.TipoDeProducto.ToString());
            sb.AppendLine(p.NombreProducto.ToString());
            //sb.AppendLine(p.UnidadDeMedida.ToString());

            //sb.AppendLine(p.precio.ToString());
            //sb.AppendLine(p.CantidadEnExistencia.ToString());

            //sb.AppendLine(p.listaDeProveedores.ToString());
            
            return sb.ToString();
        }
    }
}
