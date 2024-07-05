using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Delivery : Usuario
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

        public Delivery() : base()
        {

        }

        public Delivery(int dni, string apellido, string nombre)
           : base(dni, apellido, nombre)
        { }
        public Delivery(string idUsuario, string pasword, int dni, string apellido, string nombre)
            : base(idUsuario, pasword, dni, apellido, nombre)
        {

        }

        public Delivery(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular)
        : base(idUsuario, pasword, dni, apellido, nombre, telefonoCelular)
        {

        }
        public Delivery(string usuario, string pasword, Usuario p)
            : base(p.Dni, p.Apellido, p.Nombre, p.TelefonoCelular)
        {
            this.IdUsuario = usuario;
            this.Pasword = pasword;
        }

        public override void MenuDeOpciones()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("1_Cargar PAGO");
            Console.WriteLine("2_Suspender pedido");
            Console.WriteLine("3_Postergar pedido");
            Console.WriteLine("-------------------");
            Console.WriteLine("CONSULTAS");
            Console.WriteLine("-------------------");
            Console.WriteLine("4_LISTA de Pedidos");
            Console.WriteLine("5_LISTA de pagos");
            Console.WriteLine("----------------------------------------------------------");
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
                case 1:  //MESERO
                    Console.Clear();

                    Console.WriteLine("-------------------");
                    Console.WriteLine("1_Cargar PAGO");
                    Console.WriteLine("-------------------");

                    break;
                case 2:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("2_Suspender pedido");
                    Console.WriteLine("-------------------");

                    break;
                case 3:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("3_Postergar pedido");
                    Console.WriteLine("-------------------");

                    break;
                case 4:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");

                    Console.WriteLine("-------------------");
                    Console.WriteLine("4_LISTA de Pedidos");
                    Console.WriteLine("-------------------");
                    break;
                case 5:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("5_LISTA de pagos");
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
