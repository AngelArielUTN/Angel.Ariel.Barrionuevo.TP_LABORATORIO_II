using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static  class Validacion
    {
        public static bool ValidarCadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena.Trim()))
            {
                return false;
            }
            return true;
        }
        public static bool ValidarNumero(string cadena, out int numero)
        {
            return int.TryParse(cadena, out numero);
        }
        public static bool ValidarNumero(string cadena, out float numero)
        {
            return float.TryParse(cadena, out numero);
        }

        public static bool ValidarChar(string cadena)
        {
            char letra = ' ';
            cadena = cadena.Trim();
            letra = cadena[0];
            if (letra == 's' || letra == 'S')
            {
                return true;
            }
            return false;

        }
        public static bool ValidarTresIntentos(string cadena, out int numero)
        {
            //Console.Clear();
            int contador = 0;

            while (!(Validacion.ValidarNumero(cadena, out numero)) && contador < 3)
            {
                contador++;
                if (contador == 3)
                {
                    Console.WriteLine("Excedio los 3 intentos permitidos para ingresar.Intentelo mas tarde");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Error...Ingrese los datos segun corresponda");
                cadena = Console.ReadLine();
            }
            if (contador < 3)
            {
                return true;
            }
            return false;
        }
    }
}
