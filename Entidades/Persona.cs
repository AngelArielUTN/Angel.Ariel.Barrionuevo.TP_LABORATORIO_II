namespace Entidades
{
    public abstract class Persona
    {

        protected int dni;
        protected string apellido;
        protected string nombre;
        protected string domicilio;
        protected string telefonoCelular;
       
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return this.domicilio;
            }
            set
            {
                this.domicilio = value;
            }
        }
        public string TelefonoCelular
        {
            get
            {
                return this.telefonoCelular;
            }
            set
            {
                this.TelefonoCelular = value;
            }
        }

        public Persona()
        { }

        public Persona(int dni, string apellido, string nombre):this()
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public Persona(int dni, string apellido, string nombre, string telefonoCelular)
            : this(dni, apellido, nombre)
        {
            this.telefonoCelular = telefonoCelular;
        }

        public Persona(int dni, string apellido, string nombre, string domicilio, string telefonoCelular)
            : this(dni, apellido, nombre, telefonoCelular)
        {
            this.domicilio = domicilio;
        }

        public Persona(int dni, string apellido, string nombre, string domicilio, string telefonoCelular, string telefonoFijo)
            : this(dni, apellido, nombre, domicilio, telefonoCelular)
        {
            this.domicilio = domicilio;
            this.telefonoCelular = telefonoCelular;
        }

        //public static bool operator ==(Persona p1, Persona p2)
        //{
        //    return p1.dni == p2.dni;
        //}
        //public static bool operator !=(Persona p1, Persona p2)
        //{
        //    return !(p1 == p2);
        //}
        //public abstract void MenuDeOpciones(out int opcion, Usuario u);
    }
}
