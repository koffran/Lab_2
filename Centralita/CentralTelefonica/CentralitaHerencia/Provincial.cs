using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroOrigen)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.duracion * 0.99f;
                case Franja.Franja_2:
                    return this.duracion * 1.25f;
                case Franja.Franja_3:
                    return this.duracion * 0.66f;
                default:
                    return 0;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("Costo Llamada: ");
            sb.AppendLine(this.CostoLlamada.ToString());
            sb.Append("Franja horaria: ");
            sb.AppendLine(this.franjaHoraria.ToString());
            return sb.ToString();
        }

        #region SOBRECARGAS
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
