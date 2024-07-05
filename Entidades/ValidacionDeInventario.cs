namespace Entidades
{
    public class ValidacionDeInventario
    {
        public static Insumo nuevoInsumo;
        public static Bebida nuevaBebida;

        public static bool ValidarTipoDeProducto(eTipoDeProducto tipoDeProducto)
        {
            if (tipoDeProducto == eTipoDeProducto.Carnes || tipoDeProducto == eTipoDeProducto.Lacteos ||
                tipoDeProducto == eTipoDeProducto.Legumbres || tipoDeProducto == eTipoDeProducto.Pastas || tipoDeProducto == eTipoDeProducto.Verduras)
            {
                return true;
            }
            return false;
        }

        public static bool BuscarProductoPorNombre(string nombreProducto, out Producto p)
        {
            p = new Producto();

            if (!(Validacion.ValidarCadena(nombreProducto))) //ES NULO??  
            {
                return false;
            }

            foreach (Producto item in AdministracionInventario.ListaDeProductos)
            {
                if (item != null)
                {
                    if (nombreProducto.Trim().ToUpper() == item.NombreProducto.Trim().ToUpper())
                    {
                        p = item;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool BuscarProductoPorIdProducto(string idProducto, out Producto p)
        {
            p = new Producto();

            if (!(Validacion.ValidarCadena(idProducto))) //ES NULO??  
            {
                //u = null;
                return false;
            }

            foreach (Producto item in AdministracionInventario.ListaDeProductos)
            {
                if (item != null)
                {
                    if (item.IdProducto.ToString().ToUpper() == idProducto.Trim().ToUpper())
                    {
                        p = item;
                        return true;
                    }
                }
            }
            p = null;
            return false;
        }
     
        public static bool ValidarSiIdDeProductoEstaDisponible(string idProducto,out int numeroIdProducto)
        {

            if (Validacion.ValidarNumero(idProducto, out numeroIdProducto))
            {
                foreach (Producto item in AdministracionInventario.ListaDeProductos)
                {
                    if (item != null)
                    {
                        if (item.IdProducto == numeroIdProducto)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public static bool ValidarDatosDeProducto(string idProducto,out int numIdProducto, eTipoDeProducto tipoDeProducto, string nombreProducto)
        {
            numIdProducto = 0;

            if ((Validacion.ValidarCadena(idProducto) == true) && (ValidarSiIdDeProductoEstaDisponible(idProducto,out numIdProducto)==true) 
                && (ValidarTipoDeProducto(tipoDeProducto)== true) && (Validacion.ValidarCadena(nombreProducto) == true))
            {
                return true;
            }
            return false;
        }
        public static bool ValidarDatosDeProducto(string idProducto, out int numIdProducto, eTipoDeProducto tipoDeProducto, string nombreProducto,
            string precio, string cantidadEnExistencia)
        {
            numIdProducto = 0;

            if ((Validacion.ValidarCadena(idProducto) == true) && (ValidarSiIdDeProductoEstaDisponible(idProducto, out numIdProducto) == true)
                && (ValidarTipoDeProducto(tipoDeProducto) == true) && (Validacion.ValidarCadena(nombreProducto) == true)&&
                )
            {
                return true;
            }
            return false;
        }
    }
}
