using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class AdministracionDeUsuarios
    {
        private static List<Usuario> usuarios;
        public static Usuario usuarioAux;


        public static Encargado nuevoUsuarioEncargado;
        public static Cocinero nuevoUsuarioCocinero;
        public static Mesero nuevoUsuarioMesero;
        public static Delivery nuevoUsuarioDelibery;

        public static List<Usuario> Usuarios
        {
            get
            {
                return AdministracionDeUsuarios.usuarios;
            }
            set
            {
                AdministracionDeUsuarios.usuarios = value;
            }
        }

        static AdministracionDeUsuarios()
        {
            usuarios = new List<Usuario>();
            cargarUsuariosHardcodeados();
        }

        public static void cargarUsuariosHardcodeados()
        {
            Usuario nuevoUsuario = new Usuario();

            Encargado nuevoUsuarioEncargado = new Encargado();
            Cocinero nuevoUsuarioCocinero = new Cocinero();
            Mesero nuevoUsuarioMesero = new Mesero();
            Delivery nuevoUsuarioDelivery = new Delivery();

            // PERSONAL TURNO MAÑANA
            Encargado e1 = new Encargado("1", "1", 11, "Angel", "Ariel", "1-123456");

            Cocinero c1 = new Cocinero("2", "2", 22, "COCINERO", "Flocko", "2-123456");

            Mesero m1 = new Mesero("3", "3", 33, "MESERO", "Brownie", "3-123456");
            Mesero m2 = new Mesero("4", "4", 44, "MESERO", "Timoteo", "4-123456");
            Mesero m3 = new Mesero("5", "5", 55, "MESERO", "Mario", "5-123456");

            Delivery d1 = new Delivery("6", "6", 66, "DELIVERY", "Chelow", "6-123456");

            AdministracionDeUsuarios.Usuarios.Add(e1);
            AdministracionDeUsuarios.Usuarios.Add(c1);
            AdministracionDeUsuarios.Usuarios.Add(m1);
            AdministracionDeUsuarios.Usuarios.Add(m2);
            AdministracionDeUsuarios.Usuarios.Add(m3);
            AdministracionDeUsuarios.Usuarios.Add(d1);

            AdministracionDeUsuarios.Usuarios.Add(m1);

            // PERSONAL TUNO TARDE
            e1.CrearUsuario("11", "11", 1111, "ENCARGADO", "Tom", "22-123456", out nuevoUsuarioEncargado);
            e1.AgregarNuevo(nuevoUsuarioEncargado);
            e1.CrearUsuario("22", "22", 2222, "COCINERO", "Sheyla", "22-123456", out nuevoUsuarioCocinero);
            e1.AgregarNuevo(nuevoUsuarioCocinero);
            e1.CrearUsuario("33", "33", 3333, "MESERO", "Mariano", "33-123456", out nuevoUsuarioMesero);
            e1.AgregarNuevo(nuevoUsuarioMesero);
            e1.CrearUsuario("44", "44", 4444, "MESERO", "Saya", "44-123456", out nuevoUsuarioMesero);
            e1.AgregarNuevo(nuevoUsuarioMesero);
            e1.CrearUsuario("55", "55", 5555, "MESERO", "Leon", "55-123456", out nuevoUsuarioMesero);
            e1.AgregarNuevo(nuevoUsuarioMesero);
            e1.CrearUsuario("66", "66", 6666, "DELIVERY", "Alejandro", "66-123456", out nuevoUsuarioDelivery);
            e1.AgregarNuevo(nuevoUsuarioDelivery);


            //TURNO NOCHE
            e1.AgregarNuevo(e1.CrearUsuario("111", "111", 111111111, "ENCARGADO", "Tom", "111-123456", new Encargado()));

            e1.AgregarNuevo(e1.CrearUsuario("222", "222", 222222222, "COCINERO", "Sheyla", "222-123456", new Cocinero()));

            e1.AgregarNuevo(e1.CrearUsuario("333", "333", 333333333, "MESERO", "Mariano", "333-123456", new Mesero()));
            e1.AgregarNuevo(e1.CrearUsuario("444", "444", 444444444, "MESERO", "Saya", "444-123456", new Mesero()));
            e1.AgregarNuevo(e1.CrearUsuario("555", "555", 555555555, "MESERO", "Leon", "555-123456", new Mesero()));

            e1.AgregarNuevo(e1.CrearUsuario("666", "666", 666666666, "DELIVERY", "Leon", "666-123456", new Delivery()));

            e1.AgregarNuevo(new Cocinero("222", "222", 222222222, "COCINERO", "", "222-123456"));


            //FRANQUEROS
            e1.AgregarNuevo(new Encargado("1111", "1111", 123456789, "ENCARGADO", "Ariel", "1111-123456"));

            e1.AgregarNuevo(new Cocinero("2222", "2222", 234567891, "COCINERO", "Ivan", "2222-123456"));

            e1.AgregarNuevo(new Mesero("3333", "3333", 345678910, "MESERO", "Ilia", "3333-12345676"));
            e1.AgregarNuevo(new Mesero("4444", "4444", 456789101, "MESERO", "Andrei", "4444-123456"));
            e1.AgregarNuevo(new Mesero("5555", "5555", 567891011, "MESERO", "Ian", "5555-123456"));

            e1.AgregarNuevo(new Delivery("6666", "6666", 678910111, "DELIVERY", "Sergio", "6666-123456"));
        }

        //TODO: CrearNuevoUsuario
        public static Usuario CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                                           string apellido, string nombre, string telefonoCelular)
        {
            Usuario nuevoUsuario;

            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new Usuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return nuevoUsuario;
            }
            else
            {
                return null;
            }
        }

        public static Usuario CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                                     string apellido, string nombre, string telefonoCelular, Usuario nuevoUsuario)
        {
            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new Mesero(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return nuevoUsuario;
            }
            else
            {
                return null;
            }
        }

        public static bool CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                                  string apellido, string nombre, string telefonoCelular, out Usuario nuevoUsuario)
        {
            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return true;
            }
            else
            {
                nuevoUsuario = null;
                return false;
            }
        }

        public static bool CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                                string apellido, string nombre, string telefonoCelular, out Encargado nuevoUsuario)
        {
            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new Encargado(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return true;
            }
            else
            {
                nuevoUsuario = null;
                return false;
            }
        }

        public static bool CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                               string apellido, string nombre, string telefonoCelular, out Cocinero nuevoUsuario)
        {
            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new Cocinero(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return true;
            }
            else
            {
                nuevoUsuario = null;
                return false;
            }
        }

        public static bool CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                              string apellido, string nombre, string telefonoCelular, out Mesero nuevoUsuario)
        {
            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new Mesero(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return true;
            }
            else
            {
                nuevoUsuario = null;
                return false;
            }
        }

        public static bool CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                              string apellido, string nombre, string telefonoCelular, out Delivery nuevoUsuario)
        {
            if (ValidacionDeUsusario.ValidarDatosDeUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular))
            {
                nuevoUsuario = new Delivery(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
                return true;
            }
            else
            {
                nuevoUsuario = null;
                return false;
            }                                                 
        }

        //TODO: BuscarUsuario
        public static Usuario BuscarLuegoRetornarUsuarioSiExiste(string usuario)
        {
            if (!(Validacion.ValidarCadena(usuario))) //si la cadena NO ES VALIDA??  
            {
                return null;
            }
            else
            {
                if (AdministracionDeUsuarios.Usuarios.Count == 0)
                {
                    return null;
                }
                else
                {
                    foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
                    {
                        if (item is not null)
                        {
                            if (usuario.Trim().ToUpper() == item.IdUsuario.Trim().ToUpper())
                            {
                                return item;
                            }
                        }
                    }
                    return null;
                }
            }

        }
        public static bool BuscarPorUsuario(string usuario)
        {
            return ValidacionDeUsusario.ValidarSiUsuarioExiste(usuario);
        }

        public static Usuario BuscarLuegoRetornarUsuarioSiExiste(int dni)
        {
            if (!(Validacion.ValidarNumero(dni.ToString(), out int dniValidado))) //si el numero NO ES VALIDO??  
            {
                return null;
            }
            else
            {
                if (AdministracionDeUsuarios.Usuarios.Count == 0)
                {
                    return null;
                }
                else
                {
                    foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
                    {
                        if (item is not null)
                        {
                            if (dniValidado == item.Dni)
                            {
                                return item;
                            }
                        }
                    }
                    return null;
                }
            }

        }
        public static bool BuscarUsuarioPorDni(string dni)
        {
            return ValidacionDeUsusario.ValidarSiDNIdeUsuarioExiste(dni);
        }

        //TODO: AgregarUsuario
        public static void AgregarNuevoUsuario(string usuario)
        {
            //if (AdministracionDeUsuarios.BuscarPorUsuario(usuario))
            //{
            AdministracionDeUsuarios.Usuarios.Add(BuscarLuegoRetornarUsuarioSiExiste(usuario));
            //return true;
            //}
            //else
            //{
            //    return false;
            //}

        }
        public static void AgregarNuevoUsuario(int dni)
        {
            //if (AdministracionDeUsuarios.BuscarPorUsuario(usuario))
            //{
            AdministracionDeUsuarios.Usuarios.Add(BuscarLuegoRetornarUsuarioSiExiste(dni));
            //return true;
            //}
            //else
            //{
            //    return false;
            //}

        }
        public static bool AgregarNuevoUsuario(Usuario usuario)
        {
            //if (AdministracionDeUsuarios.BuscarUsuario(usuario.IdUsuario))
            //{
            //    AdministracionDeUsuarios.Usuarios.Add(usuario);
            //    return true;
            //}
            //else
            //{
            //   return false;
            //}
            if (usuario is null)
            {
                return false;
            }
            else if (AdministracionDeUsuarios.Usuarios.Count == 0)
            {
                AdministracionDeUsuarios.Usuarios.Add(usuario);
                return true;
            }
            else
            {
                foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
                {
                    if (item == usuario)
                    {
                        return false;
                    }
                }
                AdministracionDeUsuarios.Usuarios.Add(usuario);
                return true;

            }
        }

        //TODO: ModificarUsuario



        //TODO: BorrarUsuario   
        public static bool BajaDeUsuario(Usuario usuario)
        {
            foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
            {
                if (item == usuario)
                {
                    return false;
                }
            }
            AdministracionDeUsuarios.Usuarios.Remove(usuario);
            return true;
        }
        //public static bool BajaDeUsuario(int dni)
        //{
        //    foreach (Usuario item in AdministracionDeUsuarios.Usuarios)
        //    {
        //        if (item.Dni == dni)
        //        {
        //            AdministracionDeUsuarios.Usuarios.Remove(item);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public static void BajaDeUsuario(int dni)
        {
            Usuario u = new Usuario();

            u =BuscarLuegoRetornarUsuarioSiExiste(dni);
            if (u is not null)
            {
                AdministracionDeUsuarios.Usuarios.Remove(u);
            }
        }

        //TODO: ActualizarUsuario


        //TODO: GuardarUsuario


        //TODO: Mostrar Usuario
        public static string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Usuario item in AdministracionDeUsuarios.usuarios)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }
    }
}
