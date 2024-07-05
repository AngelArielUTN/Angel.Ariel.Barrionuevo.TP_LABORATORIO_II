using System;
using System.Text;

namespace Entidades
{
    public class Restaurante
    {
        Restaurante()
        { }

        public static string MenuInicial()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------------------------");
            sb.AppendLine("Administracion General de Restaurante");
            sb.AppendLine("---------------------------------------");
            sb.AppendLine();
            sb.AppendLine("1_Log int");
            sb.AppendLine("     Ingrese Usuario");
            sb.AppendLine("     Ingrese Contraseña");
            sb.AppendLine();
            sb.AppendLine("2_Salir");
            sb.AppendLine();
            sb.AppendLine("---------------------------------------");

            sb.AppendLine("---------------------------------------");
            return sb.ToString();
        }

        public static void MenuLoguear(out int usuario, out int contrasenia, out Usuario u)
        {
            u = new Usuario();
            string cadena = "";
            contrasenia = 0;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("LOG IN DE USUARIO");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Ingrese Usuario");
            cadena = Console.ReadLine();

            if (Validacion.ValidarTresIntentos(cadena, out usuario))
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Usuario correcto");
                Console.WriteLine("-------------------");
                Console.WriteLine("Ingrese Contraseña");

                cadena = Console.ReadLine();

                if (Validacion.ValidarTresIntentos(cadena, out contrasenia))
                {
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Contraseña correcta");
                    Console.WriteLine("-------------------");
                    cadena = Console.ReadLine();
                    u = Registrarse(usuario, contrasenia, out u);
                }
            }
            u = Registrarse(usuario, contrasenia, out u);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("---------------------------------------");
        }

        /// <summary>
        /// validar usuario y  pasword   y devolvuelve el usuario logueado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasenia"></param>
        /// <param name="u">Usuario logueado</param>
        /// <returns></returns>
        public static Usuario Registrarse(int usuario, int contrasenia, out Usuario u)
        {
            u = new Usuario();
            if ((ValidacionDeUsusario.ValidarSiUsuarioExiste(usuario.ToString(), out u)) && (ValidacionDeUsusario.ValidarPasword(contrasenia.ToString())))
            {
                return u;
            }
            return null;
        }

        public static int MenuDeOpcionesDeIngreso(int opcion, Usuario u)
        {
            switch (u.GetType().Name)
            {
                case "Encargado":
                    opcion = 1;

                    break;
                case "Cocinero":
                    opcion = 2;
                    break;
                case "Mesero":
                    opcion = 3;
                    break;
                case "Delivery":
                    opcion = 4;
                    break;
            }
            return opcion;
        }

        public static string MensajeDeBienvenida(Usuario u)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"Bienvendo { u.GetType().Name} {u.Nombre} {u.Apellido} a la Aplicacion RESTAURANTE.");

            sb.AppendLine("Ingrese un numero de Opcion");
            sb.AppendLine("----------------------------------------------------------");
            return sb.ToString();
        }

        public static void MenuDeOpciones(Usuario u)
        {
            int opcion = 0;
            string cadena = "";
            opcion = MenuDeOpcionesDeIngreso(opcion, u);

            switch (opcion)
            {
                case 1:  //ENCARGADO
                    Console.Clear();

                    //Encargado e = new Encargado();                         //sin polimorfismo
                    //e = (Encargado)u;                          
                    //u.MenuDeOpciones(out opcion, e);

                    Console.WriteLine(Restaurante.MensajeDeBienvenida(u));   // con polimorfismo
                    u.MenuDeOpciones();         

                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ingrese un numero de Opcion");
                    Console.WriteLine("-------------------");
                    cadena = Console.ReadLine();
                    Validacion.ValidarNumero(cadena, out opcion);
                    if (Validacion.ValidarTresIntentos(cadena, out opcion))
                    {
                        Console.Clear();
                        u.MenuDeUsuario(opcion, u);
                    }

                    break;
                case 2: //COCINERO
                    Console.Clear();
                     
                    Console.WriteLine(Restaurante.MensajeDeBienvenida(u));   // con polimorfismo
                    u.MenuDeOpciones();

                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ingrese un numero de Opcion");
                    Console.WriteLine("-------------------");
                    cadena = Console.ReadLine();
                    Validacion.ValidarNumero(cadena, out opcion);
                    if (Validacion.ValidarTresIntentos(cadena, out opcion))
                    {
                        Console.Clear();
                        u.MenuDeUsuario(opcion, u);
                    }
                    break;
                case 3:  //MESERO
                    Console.Clear();

                    Console.WriteLine(Restaurante.MensajeDeBienvenida(u));   // con polimorfismo
                    u.MenuDeOpciones();

                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ingrese un numero de Opcion");
                    Console.WriteLine("-------------------");
                    cadena = Console.ReadLine();
                    Validacion.ValidarNumero(cadena, out opcion);
                    if (Validacion.ValidarTresIntentos(cadena, out opcion))
                    {
                        Console.Clear();
                        u.MenuDeUsuario(opcion, u);
                    }
                    break;
                case 4: //DELIVERY
                    Console.Clear();
                    MensajeDeBienvenida(u);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Ingrese un numero de Opcion");
                    Console.WriteLine("-------------------");
                    cadena = Console.ReadLine();
                    Validacion.ValidarNumero(cadena, out opcion);
                    if (Validacion.ValidarTresIntentos(cadena, out opcion))
                    {
                        Console.Clear();
                        u.MenuDeUsuario(opcion, u);
                    }

                    break;
            }
        }
        public static void Salir(out bool salir)
        {
            salir = true;

            string cadena = "";
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Esta seguro que desea salir?");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Ingrese la letra S para salir");
            Console.WriteLine("Ingrese la letra N para continuar en la aplicacion");
            Console.WriteLine("---------------------------------------------------");
            cadena = Console.ReadLine();
            if (Validacion.ValidarCadena(cadena) && Validacion.ValidarChar(cadena))
            {
                salir = false;
            }

        }
    
    }
}

