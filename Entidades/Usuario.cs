using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        protected string idUsuario;
        protected string pasword;
        protected float sueldo;

        protected Usuario usuarioAux;
        public Usuario UsuarioAux
        {
            get
            {
                return this.usuarioAux;
            }
            set
            {
                this.usuarioAux = value;
            }
        }


        public string IdUsuario
        {
            get
            {
                return this.idUsuario;
            }
            set
            {
                this.idUsuario = value;
            }
        }
        public string Pasword
        {
            get
            {
                return this.pasword;
            }
            set
            {
                this.pasword = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                this.sueldo = value;
            }
        }
        public Usuario() : base()
        {

        }
        public Usuario(int dni, string apellido, string nombre)
            : base(dni, apellido, nombre)
        {

        }
        public Usuario(string idUsuario, string pasword, int dni, string apellido, string nombre)
            : base(dni, apellido, nombre)
        {
            this.idUsuario = idUsuario;
            this.pasword = pasword;
        }


        public Usuario(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular)
            : this(idUsuario, pasword, dni, apellido, nombre)
        {
            this.telefonoCelular = telefonoCelular;
        }

        public Usuario(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular, float sueldo)
         : this(idUsuario, pasword, dni, apellido, nombre, telefonoCelular)
        {
            this.sueldo = sueldo;
        }

        public Usuario(int dni, string apellido, string nombre, string telefono)
          : base(dni, apellido, nombre, telefono)
        {

        }
        public Usuario(int dni, string apellido, string nombre, string domicilio, string telefono)
            : base(dni, apellido, nombre, domicilio, telefono)
        {
            this.domicilio = domicilio;
        }

        public Usuario(int dni, string apellido, string nombre, string domicilio, string telefonoCelular, string telefonoFijo)
            : base(dni, apellido, nombre, domicilio, telefonoCelular)
        {
            this.domicilio = domicilio;
            this.telefonoCelular = telefonoCelular;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            bool retorno = false;

            if ((u1 is not null) && (u2 is not null))
            //if ((u1 != null) && (u2 != null))
            {
                if ((u1.dni == u2.dni))//  || (u1.IdUsuario==u2.IdUsuario))
                {
                    retorno = true;
                }

            }
            if ((u1 is null) || (u2 is null))
            //if ((u1 == null) || (u2 == null))
            {
                retorno = false;
            }

            return retorno;
        }
        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        public bool ChequearContrasenia(string pasword)
        {
            return (this.Pasword == pasword);
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Soy un Usuario {this.GetType().Name}");

            sb.AppendLine($"Nombre :{this.Nombre}");
            sb.AppendLine($"Apellido :{this.Apellido}");
            sb.AppendLine($"DNI :{this.Dni}");
            sb.AppendLine($"Nombre :{this.TelefonoCelular}\n");
            sb.AppendLine($"Sueldo :{this.Sueldo}\n");

            return sb.ToString();

        }
        //public virtual string MostrarProductos()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine($"\n{item.ETurno.GetType().GetEnumName(item.ETurno)}\n");

        //    foreach (Producto item in AdministracionInventario.ListaDeProductos)
        //    {


        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {
        //            sb.AppendLine($"{itemCiclo.CicloAcademico.GetType().GetEnumName(itemCiclo.CicloAcademico)}");
        //        }
        //    }
        //    return sb.ToString();
        //}

        //public virtual string MostrarTurnoConCiclosAnio()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (Turno item in AdministracionDeEspaciosAcademicos.Turnos)
        //    {
        //        sb.AppendLine($"\n{item.ETurno.GetType().GetEnumName(item.ETurno)}\n");

        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {
        //            sb.AppendLine($"\n{itemCiclo.CicloAcademico.GetType().GetEnumName(itemCiclo.CicloAcademico)}\n");

        //            foreach (Anio itemCicloAnio in itemCiclo.Anio)
        //            {
        //                sb.AppendLine($"{itemCicloAnio.EAnio.GetType().GetEnumName(itemCicloAnio.EAnio)}");
        //            }
        //        }
        //    }
        //    return sb.ToString();
        //}

        //public virtual string MostrarTurnoConCiclosAnioCursos()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (Turno item in AdministracionDeEspaciosAcademicos.Turnos)
        //    {
        //        sb.AppendLine($"\n{item.ETurno.GetType().GetEnumName(item.ETurno)}\n");

        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {

        //            sb.AppendLine($"\n{itemCiclo.CicloAcademico.GetType().GetEnumName(itemCiclo.CicloAcademico)}\n");

        //            foreach (Anio itemCicloAnio in itemCiclo.Anio)
        //            {
        //                sb.AppendLine($"\n{itemCicloAnio.EAnio.GetType().GetEnumName(itemCicloAnio.EAnio)}\n");

        //                foreach (Curso itemCicloAnioCurso in itemCicloAnio.Cursos)
        //                {

        //                    sb.AppendLine($"{itemCicloAnioCurso.Anio}° {itemCicloAnioCurso.Division}°");
        //                }

        //            }
        //        }
        //    }
        //    return sb.ToString();
        //}

        //public virtual string MostrarTurnoConCiclosOrientacionesAnioCursos()
        //{
        //    StringBuilder sb = new StringBuilder();



        //    foreach (Turno item in AdministracionDeEspaciosAcademicos.Turnos)
        //    {
        //        int primeraVezBasico = 0;
        //        int primeraVezSuperior = 0;

        //        sb.AppendLine($"\n{item.ETurno.GetType().GetEnumName(item.ETurno)}\n");

        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {
        //            if (itemCiclo.CicloAcademico == ENivelSecundario.CicloBasico)
        //            {
        //                if (primeraVezBasico == 0)
        //                {
        //                    sb.AppendLine($"\n{itemCiclo.CicloAcademico.GetType().GetEnumName(itemCiclo.CicloAcademico)}\n");
        //                    primeraVezBasico = 1;
        //                }

        //            }
        //            //sb.AppendLine($"\n{itemCiclo.CicloAcademico.GetType().GetEnumName(itemCiclo.CicloAcademico)}\n");

        //            if (itemCiclo.CicloAcademico == ENivelSecundario.CicloSuperior)
        //            {
        //                if (primeraVezSuperior == 0)
        //                {
        //                    sb.AppendLine($"\n{itemCiclo.CicloAcademico.GetType().GetEnumName(itemCiclo.CicloAcademico)}\n");
        //                    primeraVezSuperior = 1;
        //                }

        //                sb.AppendLine($"\n{(((CicloSuperior)itemCiclo).EOrientacion).GetType().GetEnumName(((CicloSuperior)itemCiclo).EOrientacion)}\n");

        //            }
        //            foreach (Anio itemCicloAnio in itemCiclo.Anio)
        //            {
        //                sb.AppendLine($"\n{itemCicloAnio.EAnio.GetType().GetEnumName(itemCicloAnio.EAnio)}\n");

        //                foreach (Curso itemCicloAnioCurso in itemCicloAnio.Cursos)
        //                {

        //                    sb.AppendLine($"{itemCicloAnioCurso.Anio}° {itemCicloAnioCurso.Division}°");
        //                }

        //            }
        //        }
        //    }
        //    return sb.ToString();
        //}

        public virtual string Mostrar(Usuario u)
        {
            StringBuilder sb = new StringBuilder();
            if (u != null)
            {

                sb.AppendLine($"Soy un Usuario {u.GetType().Name}");

                sb.AppendLine($"Nombre :{u.Nombre}");
                sb.AppendLine($"Apellido :{u.Apellido}");
                sb.AppendLine($"DNI :{u.Dni}");
                //sb.AppendLine($"Nombre :{this.telefonoCelular}\n");
            }
            else
            {
                sb.AppendLine("No tiene permiso para cargar este tipo de ususario");
            }

            return sb.ToString();

        }

        public virtual Usuario CrearUsuario(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
        }

        public virtual bool AgregarNuevo(Usuario usuario)
        {
            return AdministracionDeUsuarios.AgregarNuevoUsuario(usuario);
        }
        public virtual bool BajaDeUsuario(Usuario usuario)
        {
            return AdministracionDeUsuarios.BajaDeUsuario(usuario);
        }

        public virtual void MenuDeOpciones()
        {
          
        }
        public virtual void MenuDeUsuario(int opcion, Usuario u)
        {
          
        }
    }
}
