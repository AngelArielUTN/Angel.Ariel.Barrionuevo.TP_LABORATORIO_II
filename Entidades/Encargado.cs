using System;
using System.Text;

namespace Entidades
{
    public class Encargado : Usuario
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

        public Encargado()
        {

        }

        public Encargado(int dni, string apellido, string nombre)
           : base(dni, apellido, nombre)
        { }
        public Encargado(string idUsuario, string pasword, int dni, string apellido, string nombre)
            : base(idUsuario, pasword, dni, apellido, nombre)
        {

        }

        public Encargado(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular)
        : base(idUsuario, pasword, dni, apellido, nombre, telefonoCelular)
        {

        }
        public Encargado(string idUsuario, string pasword, int dni, string apellido, string nombre, string telefonoCelular, float sueldo)
       : base(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, sueldo)
        {

        }
        public Encargado(string usuario, string pasword, Usuario p)
            : base(p.Dni, p.Apellido, p.Nombre, p.TelefonoCelular)
        {
            this.IdUsuario = usuario;
            this.Pasword = pasword;
        }
        //public virtual bool AgregarNuevo(Usuario usuario)
        //{
        //    if (AdministracionDeInscripciones.Usuarios.Count == 0)
        //    {
        //        AdministracionDeInscripciones.Usuarios.Add(usuario);
        //        return true;
        //    }
        //    else
        //    {
        //        foreach (Usuario item in AdministracionDeInscripciones.Usuarios)
        //        {
        //            if (item == usuario)
        //            {
        //                return false;
        //            }
        //        }
        //        AdministracionDeInscripciones.Usuarios.Add(usuario);
        //        return true;
        //    }
        //}
        //public virtual bool BajaDeUsuario(Usuario usuario)
        //{
        //    foreach (Usuario item in AdministracionDeInscripciones.Usuarios)
        //    {
        //        if (item == usuario)
        //        {
        //            return false;
        //        }
        //    }
        //    AdministracionDeInscripciones.Usuarios.Remove(usuario);
        //    return true;
        //}
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }

        ///// <summary>
        ///// Para agregar un turno
        ///// primero lo busca entre los turno que existen
        ///// si no esta cargado
        ///// Agrega el turno e inicializa la lista de ciclos de ese turno
        ///// caso contrario devueve false.
        ///// </summary>
        ///// <param name="t">Turno a agregar</param>
        ///// <param name="cantidadDeCiclos">Ciclos que hay en este turno</param>
        ///// <returns></returns>
        ///// 
        //public virtual bool AgregarTurno(ETurno t)
        //{
        //    //Turno nuevoTurno = new Turno(t);

        //foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //{
        //    if (item == nuevoTurno)
        //    {
        //        return false;
        //    }
        //}
        //AdministracionDeInscripciones.Turnos.Add(nuevoTurno);
        //return true;
        //    return AdministracionDeEspaciosAcademicos.AgregarTurno(t);
        //}
        ///// <summary>
        ///// Para agregar un turno y sus ciclos
        ///// primero lo busca entre los turno que existen
        ///// si no esta cargado
        ///// Agrega el turno y la cantidad de ciclos de ese turno
        ///// caso contrario devueve false.
        ///// </summary>
        ///// <param name="t"></param>
        ///// <param name="cantidadDeCiclos"></param>
        ///// <returns></returns>
        //public virtual bool AgregarTurno(ETurno t, int cantidadDeCiclos)
        //{
        //    Turno nuevoTurno = new Turno(t, cantidadDeCiclos);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        if (item == nuevoTurno)
        //        {
        //            return false;
        //        }
        //    }
        //    AdministracionDeInscripciones.Turnos.Add(nuevoTurno);
        //    return true;
        //}

        ///// <summary>
        ///// si existen turnos Agrega un MISMO CICLO EN TODOS LOS TURNOS, sin repetir
        ///// </summary>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //public virtual bool AgregarCiclo(ENivelSecundario c)
        //{
        //    int agrego = 0;

        //    Ciclo nuevoCiclo = new Ciclo(c);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int cicloYaExiste = 0;
        //        //if (item != null)

        //        //{
        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {
        //            if (itemCiclo == nuevoCiclo)
        //            {
        //                cicloYaExiste = 1;
        //            }
        //        }
        //        if (cicloYaExiste == 0)
        //        {
        //            item.Ciclos.Add(nuevoCiclo);
        //            agrego = 1;
        //        }
        //        //}   
        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        ///// <summary>
        ///// si existen turnos 
        ///// Agrega un MISMO CICLO EN TODOS LOS TURNOS, con una CANTIDAD DETERMINDA DE AÑOS sin repetir
        ///// PARA ESE CICLO.
        ///// </summary>
        ///// <param name="c"></param>
        ///// <param name="cantidadAnios"></param>
        ///// <returns></returns>
        //public virtual bool AgregarCiclo(ENivelSecundario c, int cantidadAnios)
        //{
        //    int agrego = 0;

        //    Ciclo nuevoCiclo = new Ciclo(c, cantidadAnios);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int cicloYaExiste = 0;
        //        //if (item != null)

        //        //{
        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {
        //            if (itemCiclo == nuevoCiclo)
        //            {
        //                cicloYaExiste = 1;
        //            }
        //        }
        //        if (cicloYaExiste == 0)
        //        {
        //            item.Ciclos.Add(nuevoCiclo);
        //            agrego = 1;
        //        }
        //        //}   
        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}



        ///// <summary>
        ///// Agrega en un Turno determinado, un ciclo determinado e inicializa la lista de los años pertenecientes a ese ciclo
        ///// </summary>
        ///// <param name="t"></param>
        ///// <param name="c"></param>
        ///// <param name="cantidadDeCursos"></param>
        ///// <returns></returns>
        //public virtual bool AgregarCiclo(Turno t, ENivelSecundario c)
        //{
        //    Ciclo nuevoCiclo = new Ciclo(c);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        if (item == t)
        //        {
        //            foreach (Ciclo itemCiclo in item.Ciclos)
        //            {
        //                if (itemCiclo.CicloAcademico == c)
        //                {
        //                    return false;
        //                }
        //            }
        //            item.Ciclos.Add(nuevoCiclo);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        ///// <summary>
        ///// Agrega en un Turno determinado, un ciclo determinado y la lista de los años pertenecientes a ese ciclo
        ///// </summary>
        ///// <param name="t"></param>
        ///// <param name="c"></param>
        ///// <param name="cantidadDeAniosDelCiclo"></param>
        ///// <returns></returns>
        //public virtual bool AgregarCiclo(ETurno turno, ENivelSecundario ciclo, int cantidadDeAniosDelCiclo)
        //{
        //    Ciclo nuevoCiclo = new Ciclo(c, cantidadDeAniosDelCiclo);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        if (item.ETurno == t)
        //        {
        //            foreach (Ciclo itemCiclo in item.Ciclos)
        //            {
        //                if (itemCiclo.CicloAcademico == c)
        //                {
        //                    return false;
        //                }
        //                item.Ciclos.Add(nuevoCiclo);
        //                return true;


        //            }
        //            item.Ciclos.Add(nuevoCiclo);

        //            return true;
        //        }
        //    }
        //return false;
        //    return AdministracionDeEspaciosAcademicos.AgregarCiclo(turno, ciclo, cantidadDeAniosDelCiclo);
        //}
        //public virtual bool AgregarCiclo(ETurno turno, ENivelSecundario ciclo, EOrientacion orientacion, int cantidadDeAniosDelCiclo)
        //{
        //    CicloSuperior nuevoCiclo = new CicloSuperior(c, cantidadDeAniosDelCiclo, o);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        if (item.ETurno == t)
        //        {
        //            //foreach (Ciclo itemCiclo in item.Ciclos)//CicloSuperior itemCiclo in item.Ciclos
        //            //{
        //            //    if (itemCiclo.CicloAcademico == c)
        //            //    {
        //            //        //if (itemCiclo.EOrientacion==o)
        //            //        //{

        //            //            return false;
        //            //        //}

        //            //    }
        //            //}
        //            item.Ciclos.Add(nuevoCiclo);//((CicloSuperior)nuevoCiclo).
        //            return true;
        //        }
        //    }
        //    //    return false;
        //    return AdministracionDeEspaciosAcademicos.AgregarCiclo(turno, ciclo, orientacion, cantidadDeAniosDelCiclo);
        //}

        ///// <summary>
        ///// Recorre un turno,luego entra en la lista de ciclos y 
        ///// busca un año dentro de un ciclo
        ///// si no esta
        ///// agrega un año a ese ciclo
        ///// si esta para de buscar y sale
        ///// </summary>
        ///// <param name="a"></param>
        ///// <returns></returns>
        //public virtual bool AgregarAnio(EAnio a)
        //{
        //    int agrego = 0;

        //    Anio nuevoAnio = new Anio(a);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int anioYaExiste = 0;

        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {
        //            foreach (Anio anio in itemCiclo.Anio)
        //            {
        //                if ((anio == nuevoAnio))
        //                {
        //                    anioYaExiste = 1;
        //                    break;
        //                }
        //            }
        //            if (anioYaExiste == 0)
        //            {
        //                itemCiclo.Anio.Add(nuevoAnio);
        //                agrego = 1;
        //                break;
        //            }
        //        }
        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        ///// <summary>
        ///// recorre un turno,luego entra en la lista de ciclos y 
        ///// busca un año dentro de un ciclo
        ///// 
        ///// si la lista de años de ese ciclo se recorrio toda y no se encuentra, pasa al siguiente ciclo
        ///// si la lista de años de ese ciclo no ha sido recorrida toda , busca un año
        ///// si no esta
        ///// agrega un año a ese ciclo
        ///// si esta para de buscar y sale
        ///// 
        ///// </summary>
        ///// <param name="a"></param>
        ///// <returns></returns>
        //public virtual bool AgregarAnio(ETurno turno, ENivelSecundario ciclo, EAnio anio, int cantidadDeCursos)
        //{
        //    int agrego = 0;

        //    Anio nuevoAnio = new Anio(a, cantidadDeCursos);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int anioYaExiste = 0;
        //        int salir = 0;

        //        if (item.ETurno == t)
        //        {
        //            foreach (Ciclo itemCiclo in item.Ciclos)
        //            {
        //                if (itemCiclo.CicloAcademico == c)
        //                {
        //                    if (itemCiclo.Anio.Count == itemCiclo.Capacidad)
        //                    {
        //                        break;
        //                    }
        //                    if (itemCiclo.Anio.Count == 0)
        //                    {
        //                        itemCiclo.Anio.Add(nuevoAnio);
        //                        agrego = 1;
        //                        salir = 1;
        //                        //Console.WriteLine($"salio del foreach anio y AGREGO EL AÑO AL CICLO,..{nuevoAnio.EAnio}");
        //                        //Console.ReadKey();

        //                        break;
        //                    }
        //                    else if (itemCiclo.Anio.Count < itemCiclo.Capacidad)
        //                    {
        //                        foreach (Anio anio in itemCiclo.Anio)
        //                        {
        //                            if ((anio == nuevoAnio))
        //                            {
        //                                anioYaExiste = 1;
        //                                break;
        //                            }

        //                            //Console.WriteLine("Esta en foreach año,..");
        //                            //Console.ReadKey();

        //                        }



        //                        if (anioYaExiste == 0)
        //                        {
        //                            itemCiclo.Anio.Add(nuevoAnio);
        //                            agrego = 1;
        //                            salir = 1;
        //                            //Console.WriteLine("salio del foreach anio y AGREGO EL AÑO AL CICLO,..");
        //                            //Console.ReadKey();

        //                            break;
        //                        }

        //                        //Console.WriteLine("salio del IF anioYaExiste==0 ");
        //                        //Console.ReadKey();

        //                    }
        //                    //Console.WriteLine("salio del ....else if (itemCiclo.Anio.Count < itemCiclo.Capacidad)");
        //                    //Console.ReadKey();

        //                    break;
        //                }

        //                //Console.WriteLine("salio del  IF (itemCiclo.CicloAcademico == c)  pero esta en foreach CICLOS");
        //                //Console.ReadKey();
        //            }

        //            //Console.WriteLine("salio del foreach CICLO,..pero esta en foreach TURNO");
        //            //Console.ReadKey();
        //            break;
        //        }

        //        //Console.WriteLine("salio del  IF(item.ETurno == t),..pero esta en foreach TURNO");
        //        //Console.ReadKey();


        //        if (salir == 1)
        //        {
        //            break;//.........sale del foreach ANTES DE ENTRAR AL SIGUIENTE TURNO
        //        }

        //    }


        //    //Console.WriteLine("salio del foreach turno,..");
        //    //Console.ReadKey();


        //    if (agrego == 0)
        //    {
        //        return false;
        //    }
        //    //    return true;
        //    return AdministracionDeEspaciosAcademicos.AgregarAnio(turno, ciclo, anio, cantidadDeCursos);
        //}

        //////ETurno t, ENivelSecundario c, EOrientacion o, int cantidadDeAniosDelCiclo
        //public virtual bool AgregarAnio(ETurno turno, ENivelSecundario ciclo, EOrientacion orientacion, EAnio anio, int cantidadDeCursos)
        //{
        //    int agrego = 0;

        //    Anio nuevoAnio = new Anio(a, cantidadDeCursos);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int anioYaExiste = 0;
        //        int salir = 0;

        //        if (item.ETurno == t)
        //        {
        //            foreach (Ciclo itemCiclo in item.Ciclos)
        //            {

        //                if (itemCiclo.CicloAcademico == c)
        //                {
        //                    if (itemCiclo.Anio.Count == itemCiclo.Capacidad)
        //                    {
        //                        break;
        //                    }
        //                    //if (itemCiclo.Anio.Count == 0)
        //                    //{
        //                    //    itemCiclo.Anio.Add(nuevoAnio);
        //                    //    agrego = 1;
        //                    //    salir = 1;
        //                    //    //Console.WriteLine($"salio del foreach anio y AGREGO EL AÑO AL CICLO,..{nuevoAnio.EAnio}");
        //                    //    //Console.ReadKey();

        //                    //    break;
        //                    //}
        //                    //else if (itemCiclo.Anio.Count < itemCiclo.Capacidad)
        //                    //{
        //                    //    foreach (Anio anio in itemCiclo.Anio)
        //                    //    {
        //                    //        if ((anio == nuevoAnio))
        //                    //        {
        //                    //            anioYaExiste = 1;
        //                    //            break;
        //                    //        }

        //                    //        //Console.WriteLine("Esta en foreach año,..");
        //                    //        //Console.ReadKey();

        //                    //    }



        //                    //    if (anioYaExiste == 0)
        //                    //    {
        //                    //        itemCiclo.Anio.Add(nuevoAnio);
        //                    //        agrego = 1;
        //                    //        salir = 1;
        //                    //        //Console.WriteLine("salio del foreach anio y AGREGO EL AÑO AL CICLO,..");
        //                    //        //Console.ReadKey();

        //                    //        break;
        //                    //    }

        //                    //    //Console.WriteLine("salio del IF anioYaExiste==0 ");
        //                    //    //Console.ReadKey();

        //                    //}
        //                    //Console.WriteLine("salio del ....else if (itemCiclo.Anio.Count < itemCiclo.Capacidad)");
        //                    //Console.ReadKey();

        //                    if (((CicloSuperior)itemCiclo).EOrientacion == o)
        //                    {
        //                        itemCiclo.Anio.Add(nuevoAnio);
        //                        agrego = 1;
        //                        salir = 1;


        //                        break;

        //                    }

        //                    //itemCiclo.Anio.Add(nuevoAnio);...
        //                    //agrego = 1;...
        //                    //salir = 1;...


        //                    //break;....

        //                }

        //                //Console.WriteLine("salio del  IF (itemCiclo.CicloAcademico == c)  pero esta en foreach CICLOS");
        //                //Console.ReadKey();
        //            }

        //            //Console.WriteLine("salio del foreach CICLO,..pero esta en foreach TURNO");
        //            //Console.ReadKey();
        //            break;
        //        }

        //        //Console.WriteLine("salio del  IF(item.ETurno == t),..pero esta en foreach TURNO");
        //        //Console.ReadKey();


        //        if (salir == 1)
        //        {
        //            break;//.........sale del foreach ANTES DE ENTRAR AL SIGUIENTE TURNO
        //        }

        //    }


        //    //Console.WriteLine("salio del foreach turno,..");
        //    //Console.ReadKey();


        //    if (agrego == 0)
        //    {
        //        return false;
        //    }
        //    //    return true;
        //    return AdministracionDeEspaciosAcademicos.AgregarAnio(turno, ciclo, orientacion, anio, cantidadDeCursos);
        //}


        //public virtual bool AgregarAnio(EAnio a, int cantidadDeCursos)
        //{
        //    int agrego = 0;

        //    Anio nuevoAnio = new Anio(a, cantidadDeCursos);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int anioYaExiste = 0;

        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {

        //            if (itemCiclo.Anio.Count == itemCiclo.Capacidad)
        //            {
        //                continue;
        //            }
        //            else if (itemCiclo.Anio.Count < itemCiclo.Capacidad)
        //            {
        //                foreach (Anio anio in itemCiclo.Anio)
        //                {
        //                    if ((anio == nuevoAnio))
        //                    {
        //                        anioYaExiste = 1;
        //                        break;
        //                    }
        //                }
        //                if (anioYaExiste == 0)
        //                {
        //                    itemCiclo.Anio.Add(nuevoAnio);
        //                    agrego = 1;
        //                    break;
        //                }
        //            }
        //            //break;   //con este break SOLO COMPLETARIA LOS CURSOS DEL CICLO BASICO
        //        }
        //        break;//.........SALE DEL FOR ANTES DE ENTRAR AL SIGUIENTE TURNO
        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}


        //public virtual bool AgregarCursos(EAnio eAnio, int cantidadAlumnos, int anio, int division)
        //{
        //    //    int agrego = 0;

        //    Curso nuevoCurso = new Curso(anio, division);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int cursoYaExiste = 0;

        //        foreach (Ciclo itemCiclo in item.Ciclos)
        //        {




        //            foreach (Anio anioCiclo in itemCiclo.Anio)
        //            {
        //                if (anioCiclo.EAnio == a)
        //                {






        //                    if (anioCiclo.Cursos.Count == 0)
        //                    {
        //                        anioCiclo.Cursos.Add(nuevoCurso);
        //                        agrego = 1;
        //                        break;
        //                    }
        //                    else if (anioCiclo.Cursos.Count < anioCiclo.Capacidad)
        //                    {
        //                        foreach (Curso anioCicloCurso in anioCiclo.Cursos)
        //                        {
        //                            if (anioCicloCurso == nuevoCurso)
        //                            {
        //                                cursoYaExiste = 1;
        //                                break;
        //                            }
        //                            if (cursoYaExiste == 0)
        //                            {
        //                                anioCiclo.Cursos.Add(nuevoCurso);
        //                                agrego = 1;
        //                                break;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }

        //    //    return true;
        //    return AdministracionDeEspaciosAcademicos.AgregarCursos(eAnio, cantidadAlumnos, anio, division);
        //}

        //public virtual bool AgregarCursoAunaOrientacion(ETurno turno, ENivelSecundario ciclo, EOrientacion orientacion, EAnio eAnio, int cantidadAlumnos, int anio, int division)
        //{
        //    //    int agrego = 0;

        //    Curso nuevoCurso = new Curso(anio, division);

        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int cursoYaExiste = 0;
        //        int salir = 0;

        //        if (item.ETurno == t)
        //        {
        //            foreach (Ciclo itemCiclo in item.Ciclos)
        //            {

        //                if (itemCiclo.CicloAcademico == c)
        //                {

        //                    if (((CicloSuperior)itemCiclo).EOrientacion == o)
        //                    {

        //                        foreach (Anio anioCiclo in itemCiclo.Anio)
        //                        {
        //                            if (anioCiclo.EAnio == a)
        //                            {
        //                                if (anioCiclo.Cursos.Count == 0)
        //                                {
        //                                    anioCiclo.Cursos.Add(nuevoCurso);
        //                                    agrego = 1;
        //                                    break;
        //                                }
        //                                else if (anioCiclo.Cursos.Count < anioCiclo.Capacidad)
        //                                {
        //                                    foreach (Curso anioCicloCurso in anioCiclo.Cursos)
        //                                    {
        //                                        if (anioCicloCurso == nuevoCurso)
        //                                        {
        //                                            cursoYaExiste = 1;
        //                                            break;
        //                                        }
        //                                    }
        //                                    if (cursoYaExiste == 0)
        //                                    {
        //                                        anioCiclo.Cursos.Add(nuevoCurso);
        //                                        agrego = 1;
        //                                        salir = 1;

        //                                        break;
        //                                    }

        //                                }
        //                                break;
        //                            }
        //                            break;
        //                        }
        //                        break;
        //                    }//
        //                    //break;  
        //                }

        //                //recorrido den la lista de cursos de un año
        //                //break;
        //            }
        //            break;
        //        }



        //        if (salir == 1)
        //        {
        //            break;//.........sale del foreach ANTES DE ENTRAR AL SIGUIENTE TURNO
        //        }

        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }
        //    return true;

        //    return AdministracionDeEspaciosAcademicos.AgregarCursoAunaOrientacion(turno, ciclo, orientacion, eAnio, cantidadAlumnos, anio, division);
        //}
        ///// <summary>
        ///// Se generan 
        ///// </summary>
        ///// <param name="t"></param>
        ///// <param name="c"></param>
        ///// <param name="a"></param>
        ///// <param name="cantidadAlumnos"></param>
        ///// <param name="anio"></param>
        ///// <param name="division"></param>
        ///// <param name="s"></param>
        ///// <returns></returns>
        ////public virtual bool GenerarInscripcionAlumnoACursoBasico(ETurno t, ENivelSecundario c, EAnio a,
        //    int cantidadAlumnos, Curso curso, int anio, int division, SolicitudDeInscripcion s)
        //{
        //    int agrego = 0;



        //    foreach (Turno item in AdministracionDeInscripciones.Turnos)
        //    {
        //        int solicitudYaExiste = 0;
        //        int salir = 0;

        //        if (item.ETurno == t)
        //        {
        //            foreach (Ciclo itemCiclo in item.Ciclos)
        //            {

        //                if (itemCiclo.CicloAcademico == c)
        //                {

        //                    foreach (Anio anioCiclo in itemCiclo.Anio)
        //                    {
        //                        if (anioCiclo.EAnio == a)
        //                        {


        //                            foreach (Curso anioCurso in anioCiclo.Cursos)
        //                            {
        //                                if (anioCurso == curso)
        //                                {
        //                                    if (anioCurso.Solicitudes.Count == 0)
        //                                    {
        //                                        anioCurso.Solicitudes.Add(s);
        //                                        agrego = 1;
        //                                        break;
        //                                    }
        //                                    else if (anioCurso.Solicitudes.Count < anioCurso.Capacidad)
        //                                    {
        //                                        foreach (SolicitudDeInscripcion itemSolicitud in anioCurso.Solicitudes)
        //                                        {
        //                                            if (itemSolicitud == s)
        //                                            {
        //                                                solicitudYaExiste = 1;
        //                                                break;
        //                                            }
        //                                        }
        //                                        if (solicitudYaExiste == 0)
        //                                        {
        //                                            anioCurso.Solicitudes.Add(s);
        //                                            agrego = 1;
        //                                            salir = 1;

        //                                            break;
        //                                        }

        //                                    }

        //                                    break;
        //                                }
        //                            }
        //                        }
        //                        break;
        //                    }
        //                    break;
        //                    //}//
        //                    //break;  
        //                }

        //                //recorrido den la lista de cursos de un año
        //                //break;
        //            }
        //            break;
        //        }



        //        if (salir == 1)
        //        {
        //            break;//.........sale del foreach ANTES DE ENTRAR AL SIGUIENTE TURNO
        //        }

        //    }

        //    if (agrego == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        public override Usuario CrearUsuario(string idUsuario, string pasword, int dni,
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
                                          string apellido, string nombre, string telefonoCelular, Cocinero c)
        {

            c = (Cocinero)AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
            return c;
        }
        public static Usuario CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                                          string apellido, string nombre, string telefonoCelular, Mesero m)
        {

            m = (Mesero)AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
            return m;
        }
        public static Usuario CrearNuevoUsuario(string idUsuario, string pasword, int dni,
                                          string apellido, string nombre, string telefonoCelular, Delivery d)
        {

            d = (Delivery)AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular);
            return d;
        }



        public Usuario CrearUsuario(string idUsuario, string pasword, int dni,
                                    string apellido, string nombre, string telefonoCelular, Encargado nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, nuevoUsuario);
        }
        public Usuario CrearUsuario(string idUsuario, string pasword, int dni,
                                     string apellido, string nombre, string telefonoCelular, Cocinero nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, nuevoUsuario);
        }
        public Usuario CrearUsuario(string idUsuario, string pasword, int dni,
                                  string apellido, string nombre, string telefonoCelular, Mesero nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, nuevoUsuario);
        }
        public Usuario CrearUsuario(string idUsuario, string pasword, int dni,
                                 string apellido, string nombre, string telefonoCelular, Delivery nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, nuevoUsuario);
        }



        public bool CrearUsuario(string idUsuario, string pasword, int dni,
                               string apellido, string nombre, string telefonoCelular, out Usuario nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, out nuevoUsuario);
        }
        public bool CrearUsuario(string idUsuario, string pasword, int dni,
                            string apellido, string nombre, string telefonoCelular, out Encargado nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, out nuevoUsuario);
        }
        public bool CrearUsuario(string idUsuario, string pasword, int dni,
                             string apellido, string nombre, string telefonoCelular, out Cocinero nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, out nuevoUsuario);
        }
        public bool CrearUsuario(string idUsuario, string pasword, int dni,
                            string apellido, string nombre, string telefonoCelular, out Mesero nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, out nuevoUsuario);
        }
        public bool CrearUsuario(string idUsuario, string pasword, int dni,
                             string apellido, string nombre, string telefonoCelular, out Delivery nuevoUsuario)
        {
            return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, out nuevoUsuario);
        }


        //public Usuario CrearUsuario(string idUsuario, string pasword,int dni,
        //                              string apellido, string nombre, string telefonoCelular, out Mesero nuevoUsuario)
        //{
        //    return AdministracionDeUsuarios.CrearNuevoUsuario(idUsuario, pasword, dni, apellido, nombre, telefonoCelular, out nuevoUsuario);
        //}
        public Insumo crearInsumo(int idProducto, eTipoDeProducto tipoDeProducto, string nombreProducto)
        {
            return AdministracionInventario.crearInsumo(idProducto, tipoDeProducto, nombreProducto);
        }

        public override void MenuDeOpciones()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("1_Cargar un Producto");
            Console.WriteLine("2_Consultar Stock a REPONER");
            Console.WriteLine("3_Asignar Precio a plato");
            Console.WriteLine("4_Pagar a Proveedores");
            Console.WriteLine("5_Emitir ticket");
            Console.WriteLine("6_Pago a empleados");
            Console.WriteLine("7_Quitar plato de la mesa");
            Console.WriteLine("-------------------");
            Console.WriteLine("CONSULTAS");
            Console.WriteLine("-------------------");
            Console.WriteLine("8_Consumo total)");
            Console.WriteLine("9_Consumo solo delivery");
            Console.WriteLine("10_Consumo por mesa a cobrar");
            Console.WriteLine("11_Registrar Consumo por medio de pago(individual)");
            Console.WriteLine("12_Consumo por mesero");
            Console.WriteLine("13_Top 3 de ventas");
            Console.WriteLine("-------------------");
            Console.WriteLine("14_SALIR");
            Console.WriteLine("-------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");   
        }

        public override void MenuDeUsuario(int opcion, Usuario u)
        {
           
            switch (opcion)
            {
                case 1:  //ENCARGADO
                    Console.Clear();

                    Console.WriteLine("-------------------");
                    Console.WriteLine("1_Cargar un Producto");
                    Console.WriteLine("-------------------");      

                    break;
                case 2:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("2_Consultar Stock a REPONER");
                    Console.WriteLine("-------------------");

                    break;
                case 3:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("3_Asignar Precio a plato");
                    Console.WriteLine("-------------------");

                    break;
                case 4:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("4_Pagar a Proveedores");
                    Console.WriteLine("-------------------");
                    break;
                case 5:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("5_Emitir ticket");
                    Console.WriteLine("-------------------");

                    break;
                case 6:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("6_Pago a empleados");
                    Console.WriteLine("-------------------");
                    break;
                case 7:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("7_Quitar plato de la mesa");
                    Console.WriteLine("-------------------");
                    break;
                case 8:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("8_Consumo total)");
                    Console.WriteLine("-------------------");
                    break;
                case 9:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("9_Consumo solo delivery");
                    Console.WriteLine("-------------------");
                    break;
                case 10:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("10_Consumo por mesa a cobrar");
                    Console.WriteLine("-------------------");
                    break;
                case 11:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("11_Registrar Consumo por medio de pago(individual)");
                    Console.WriteLine("-------------------");
                    break;
                case 12:

                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("12_Consumo por mesero");
                    Console.WriteLine("-------------------");
                    break;
                case 13:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CONSULTAS");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("13_Top 3 de ventas");
                    Console.WriteLine("-------------------");
                    break;
                case 14:
                    Console.WriteLine("-------------------");
                    Console.WriteLine("SALIR");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("14_Esta a punto de abandonar la Aplicacion");
                    Console.WriteLine("-------------------");

                    Console.WriteLine("-------------------");
                    Console.WriteLine("----------------------------------------------------------");

                    break;
            }

        }
    }
}
