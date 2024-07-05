using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mesero:Usuario
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

        public Mesero():base()
        {

        }

        public Mesero(int dni, string apellido, string nombre)
           : base(dni, apellido, nombre)
        { }
        public Mesero(string idUsuario, string pasword, int dni, string apellido, string nombre)
            : base(idUsuario, pasword, dni, apellido, nombre)
        {

        }

        public Mesero(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular)
        : base(idUsuario, pasword, dni, apellido, nombre, telefonoCelular)
        {

        }
        public Mesero(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular, float sueldo)
       : base(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, sueldo)
        {

        }
        public Mesero(string usuario, string pasword, Usuario p)
            : base(p.Dni, p.Apellido, p.Nombre, p.TelefonoCelular)
        {
            this.IdUsuario = usuario;
            this.Pasword = pasword;
        }

        public override void MenuDeOpciones()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("1_Abrir mesa");
            Console.WriteLine("2_Modificar mesa");
            Console.WriteLine("3_Cobrar mesa");
            Console.WriteLine("4_Cerrar mesa");
            Console.WriteLine("-------------------");
            Console.WriteLine("CONSULTAS");
            Console.WriteLine("-------------------");
            Console.WriteLine("4_LISTA de tickets");
            Console.WriteLine("5_LISTA de consumos");
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
                    Console.WriteLine("1_Abrir mesa");
                    Console.WriteLine("-------------------");

                    break;
                case 2:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("2_Modificar mesa");
                    Console.WriteLine("-------------------");

                    break;
                case 3:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("3_Cobrar mesa");
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


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }
    }
}
