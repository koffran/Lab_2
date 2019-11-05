using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarate.Franco._2D.TP3
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        #region CONSTRUCTORES
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            :this(nombre,apellido,0,nacionalidad)
        {
            
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            :this(nombre,apellido, dni.ToString(),nacionalidad)
        {
            
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
            this.Dni = dni;

        }
        #endregion

        #region Propiedades
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
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
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
        public string StringToDNI
        {
            set
            {
                this.dni = int.Parse(value);
            }
        }
        #endregion

        #region METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"NOMBRE COMPLETO:{this.Apellido}, {this.Nombre}");
            return sb.ToString();
        }
        #endregion

        /*Clase Persona:
         Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y
        89999999 y Extranjero entre 90000000 y 99999999. Caso contrario, se lanzará la excepción
        NacionalidadInvalidaException.
         Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará
        DniInvalidoException.
         Sólo se realizarán las validaciones dentro de las propiedades.
         Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se
        cargará.
         ToString retornará los datos de la Persona.*/
    }
}
