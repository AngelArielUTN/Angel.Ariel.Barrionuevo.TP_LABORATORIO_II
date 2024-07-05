using System;

namespace Entidades
{
    public class Cocinero : Usuario
    {
        private Usuario usuarioAux_nuevo;
        public Usuario UsuarioAux_
        {
            set
            {
                this.usuarioAux_nuevo = value;
            }
            get
            {
                return this.usuarioAux_nuevo;
            }
        }

        public Cocinero()
        {

        }

        public Cocinero(int dni, string apellido, string nombre)
           : base(dni, apellido, nombre)
        { }
        public Cocinero(string idUsuario, string pasword, int dni, string apellido, string nombre)
            : base(idUsuario, pasword, dni, apellido, nombre)
        {

        }

        public Cocinero(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular)
        : base(idUsuario, pasword, dni, apellido, nombre, telefonoCelular)
        {

        }
        public Cocinero(string usuario, string pasword, Usuario p)
            : base(p.Dni, p.Apellido, p.Nombre, p.TelefonoCelular)
        {
            this.IdUsuario = usuario;
            this.Pasword = pasword;
        }
        public override void MenuDeOpciones()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("1_Cargar un Plato");
            Console.WriteLine("2_Modificar plato");
            Console.WriteLine("3_Eliminar plato");
            Console.WriteLine("-------------------");
            Console.WriteLine("CONSULTAS");
            Console.WriteLine("-------------------");
            Console.WriteLine("4_LISTA de platos por Producto(mayor a menor catidad de ese producto)");
            Console.WriteLine("5_LISTA de platos no disponibles");
            Console.WriteLine("-------------------");
            Console.WriteLine("6_SALIR");
            Console.WriteLine("-------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
        }
        public override void MenuDeUsuario(int opcion, Usuario u)
        {

            switch (opcion)
            {
                case 1:  //COCINERO
                    Console.Clear();

                    Console.WriteLine("-------------------");
                    Console.WriteLine("1_Cargar un Plato");
                    Console.WriteLine("-------------------");

                    break;
                case 2:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("2_Modificar plato");
                    Console.WriteLine("-------------------");

                    break;
                case 3:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("3_Eliminar plato");
                    Console.WriteLine("-------------------");

                    break;
                case 4:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");

                    Console.WriteLine("-------------------");
                    Console.WriteLine("4_LISTA de platos por Producto(mayor a menor catidad de ese producto)");
                    Console.WriteLine("-------------------");
                    break;
                case 5:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("5_LISTA de platos no disponibles");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("----------------------------------------------------------");
                    break;
                case 6:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("SALIR");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("6_Esta a punto de abandonar la Aplicacion");
                    Console.WriteLine("-------------------");

                    Console.WriteLine("-------------------");
                    Console.WriteLine("----------------------------------------------------------");

                    break;
            }
        }
    }
}
