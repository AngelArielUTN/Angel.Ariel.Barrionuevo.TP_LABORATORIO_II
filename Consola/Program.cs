using Entidades;
using System;

namespace Consola
{
    public class Program
    {
        static void Main(string[] args)
        {

            int usuario = 0;
            int contrasenia = 0;
            Usuario usuarioLogueado = new Usuario();
            int op = 0;
            string cadena = "";
            char rta = 's';
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(Restaurante.MenuInicial());
                //Console.ReadKey();
                Console.WriteLine("Ingrese un numero de opcion");
                cadena = Console.ReadLine();
                Validacion.ValidarNumero(cadena, out op);

                switch (op)
                {
                    case 1:
                        bool seguir = true;

                        Console.Clear();
                        Restaurante.MenuLoguear(out usuario, out contrasenia, out usuarioLogueado);
                        if (usuarioLogueado is null)
                        {
                            Console.WriteLine("Usuario o contraseña invalidos.Intentelo mas tarde");
                            Console.ReadKey();
                            break;
                        }
                        while (seguir)
                        {
                            Restaurante.MenuDeOpciones(usuarioLogueado);
                            Console.ReadKey();

                            Restaurante.Salir(out seguir);
                        }

                        break;
                    case 2:
                        Console.Clear();
                        seguir = true;
                        
                        while (continuar)
                        {
                            Restaurante.Salir(out continuar);
                        }
                        break;
                }
            }

            Console.WriteLine(AdministracionDeUsuarios.Mostrar());
            Console.ReadKey();

            Console.Clear();

            AdministracionDeUsuarios.BajaDeUsuario(11);
            Console.WriteLine(AdministracionDeUsuarios.Mostrar());
            Console.ReadKey();

        }
    }
}
