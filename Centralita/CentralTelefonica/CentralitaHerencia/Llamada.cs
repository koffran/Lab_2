using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #region ATRIBUTOS
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region PROPS
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region PROPIEDADES
        public abstract float CostoLlamada { get;}

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion

        #region METODOS
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
                return 1;
            else if (llamada1.duracion == llamada2.duracion)
                return 0;
            else
                return -1;
        }

        public abstract string Mostrar2()

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nro Destino: ");
            sb.AppendLine(this.NroDestino.ToString());
            sb.Append("Nro Origen: ");
            sb.AppendLine(this.NroOrigen.ToString());
            sb.Append("Duracion: ");
            sb.AppendLine(this.Duracion.ToString());
            
            
            return sb.ToString();
        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l1.NroOrigen);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        #endregion

    }
}
