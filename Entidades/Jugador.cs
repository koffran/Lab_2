using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        #region PROPIEDADES
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Altura: ");
            sb.AppendLine(this.Altura.ToString());
            sb.Append("Peso: ");
            sb.AppendLine(this.Peso.ToString());
            sb.Append("Posicion: ");
            sb.AppendLine(this.Posicion.ToString());

            return sb.ToString();
        }

         public bool ValidarEstadoFisico()
        {
            double imc = peso / Math.Pow((double)Altura, 2);
            return (imc >= 18.5 && imc <= 25);
        }

        public override bool ValidarAptitud()
        {
            return (this.Edad <= 40 && this.ValidarEstadoFisico());
        }
    }
}
