using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre,apellido,edad,dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Años de experiencia: ");
            sb.AppendLine(this.AñosExperiencia.ToString());

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            return (this.edad < 65 && this.añosExperiencia >= 2);
        }
    }
}
