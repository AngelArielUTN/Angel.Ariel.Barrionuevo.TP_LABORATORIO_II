using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{                                                                          
    public class Proveedor
    {
        private int idProveedor;
        private string nombreProveedor;
        private eTipoDeProducto tipoDeProducto;
        private eMedioDePago medioDePago;
        private DateTime diaDeEntrega;
        private List<Producto> listaDeProductos;
    }
}
