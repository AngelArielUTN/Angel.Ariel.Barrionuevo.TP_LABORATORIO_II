using System.Collections.Generic;

namespace Entidades
{
    public static class AdministracionInventario
    {
        private static List<Producto> listaDeProductos;
        private static List<Proveedor> listaDeProveedores;

        public static List<Producto> ListaDeProductos
        {
            get
            {
                return AdministracionInventario.listaDeProductos;
            }
            set
            {
                AdministracionInventario.listaDeProductos=value;
            }

        }
        public static List<Proveedor> ListaDeProveedores
        {
            get
            {
                return AdministracionInventario.listaDeProveedores;
            }
            set
            {
                AdministracionInventario.listaDeProveedores= value;
            }
        }

        static AdministracionInventario()
        {
            AdministracionInventario.listaDeProductos = new List<Producto>();
            AdministracionInventario.listaDeProveedores = new List<Proveedor>();

            AdministracionInventario.Lista_HARDCODEADA_DeProductosConfeccionadaPorLaCocina();
        }

        public static void Lista_HARDCODEADA_DeProductosConfeccionadaPorLaCocina()
        {
            AdministracionInventario.ListaDeProductos.Add(new Insumo(1,eTipoDeProducto.Lacteos,"Leche Entera"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(2,eTipoDeProducto.Lacteos,"Queso Fresco"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(3,eTipoDeProducto.Lacteos,"Manteca"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(4,eTipoDeProducto.Lacteos,"Yogurth Entero"));

            AdministracionInventario.ListaDeProductos.Add(new Insumo(5,eTipoDeProducto.Carnes,"Bife de Chorizo"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(6,eTipoDeProducto.Carnes,"Bola de Lomo"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(7,eTipoDeProducto.Carnes,"Suprema de Pollo"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(8,eTipoDeProducto.Carnes,"Filet de Merluza"));

            AdministracionInventario.ListaDeProductos.Add(new Insumo(9, eTipoDeProducto.Legumbres, "Lentejas"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(10, eTipoDeProducto.Legumbres, "Garbanzos"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(11, eTipoDeProducto.Legumbres, "Arbejas"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(12, eTipoDeProducto.Legumbres, "Porotos Negros"));

            AdministracionInventario.ListaDeProductos.Add(new Insumo(13, eTipoDeProducto.Legumbres, "Lentejas"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(14, eTipoDeProducto.Legumbres, "Garbanzos"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(15, eTipoDeProducto.Legumbres, "Arbejas"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(16, eTipoDeProducto.Legumbres, "Porotos Negros"));

            AdministracionInventario.ListaDeProductos.Add(new Insumo(17, eTipoDeProducto.Pastas,"Fideos Spaguetti"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(18, eTipoDeProducto.Pastas,"Fideos Mostachol"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(19, eTipoDeProducto.Pastas,"Lasagna"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(20, eTipoDeProducto.Pastas,"Rabioles"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(21, eTipoDeProducto.Pastas,"Ñoquis"));

            AdministracionInventario.ListaDeProductos.Add(new Insumo(22, eTipoDeProducto.Verduras, "Tomate"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(23, eTipoDeProducto.Verduras, "Morron Rojo"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(24, eTipoDeProducto.Verduras, "Morron verde"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(25, eTipoDeProducto.Verduras, "Cebolla"));
            AdministracionInventario.ListaDeProductos.Add(new Insumo(26, eTipoDeProducto.Verduras, "Ajo"));
        }

        public static Insumo crearInsumo(int idProducto, eTipoDeProducto tipoDeProducto, string nombreProducto)
        {
            //validaciones
            Insumo insumo = new Insumo(idProducto,tipoDeProducto,nombreProducto); ;
            AdministracionInventario.ListaDeProductos.Add(insumo);
            return insumo;
        }

    }
}
