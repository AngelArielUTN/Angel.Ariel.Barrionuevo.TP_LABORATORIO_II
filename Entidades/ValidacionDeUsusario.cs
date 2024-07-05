using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static  class ValidacionDeUsusario
    {
        public static Cocinero nuevoUsuarioCocinero;
        public static Mesero nuevoUsuarioMesero;


        public static bool ValidarSiUsuarioExiste(string usuario)
        {

            if (!(Validacion.ValidarCadena(usuario))) //ES NULO??  
            {
                return false;
            }

            foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
            {
                if (item != null)
                {
                    if (usuario.Trim().ToUpper() == item.IdUsuario.Trim().ToUpper())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool ValidarSiUsuarioExiste(string usuario, out Usuario u)
        {
            u = new Usuario();

            if (!(Validacion.ValidarCadena(usuario))) //ES NULO??  
            {
                //u = null;
                return false;
            }

            foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
            {
                if (item != null)
                {
                    if (usuario.Trim().ToUpper() == item.IdUsuario.Trim().ToUpper())
                    {
                        u = item;
                        return true;
                    }
                }
            }
            u = null;
            return false;
        }
        public static bool ValidarPasword(string pasword)
        {
            //if (string.IsNullOrEmpty(pasword.Trim()))
            //{
            //    return false;
            //}
            if (!(Validacion.ValidarCadena(pasword))) //si la cadena NO ES VALIDA??  
            {
                return false;
            }
            foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
            {
                if (item != null)
                {
                    if (pasword.Trim().ToUpper() == item.Pasword.Trim().ToUpper())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ValidarSiUsuarioEstaDisponible(string usuario)
        {
            foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
            {
                if (item != null)
                {
                    if (usuario.Trim().ToUpper() == item.IdUsuario.Trim().ToUpper())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool ValidarSiDNIdeUsuarioExiste(string dni)
        {

            Validacion.ValidarNumero(dni, out int numeroDNI);

            foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
            {
                if (item != null)
                {
                    if (numeroDNI == item.Dni)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

          public static bool ValidarDatosDeUsuario(string idUsuario, string pasword)
        {
            if ((Validacion.ValidarCadena(idUsuario) == true) && (ValidarSiUsuarioEstaDisponible(idUsuario)&& (Validacion.ValidarCadena(pasword) == true)
                && (Validacion.ValidarNumero(pasword,out int numPass) == true) && (Validacion.ValidarNumero(pasword, out int numUsuario) == true)))
            {
                return true;
            }
            return false;
        }
        public static bool ValidarDatosDeUsuario(string idUsuario, string pasword,int dni,
                                                 string apellido, string nombre, string telefonoCelular)
        {
            if ((Validacion.ValidarCadena(idUsuario) == true) && (ValidarSiUsuarioEstaDisponible(idUsuario)
                && (Validacion.ValidarCadena(pasword) == true) && (Validacion.ValidarNumero(dni.ToString(), out dni) == true)
               && (Validacion.ValidarCadena(apellido) == true)
                && (Validacion.ValidarCadena(nombre) == true)))
            {
                return true;
            }
            return false;
        }

        
    }
}
