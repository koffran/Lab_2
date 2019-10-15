using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected int dni;
        protected int edad;
        protected string nombre;

        public Persona(string nombre, string apellido,int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        #region PROPIEDADES
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Metodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Apellido: ");
            sb.AppendLine(this.Apellido);
            sb.Append("Nombre: ");
            sb.AppendLine(this.Nombre);
            sb.Append("Dni: ");
            sb.AppendLine(this.Dni.ToString());
            sb.Append("Edad: ");
            sb.AppendLine(this.Edad.ToString());

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        #endregion
    }
}
