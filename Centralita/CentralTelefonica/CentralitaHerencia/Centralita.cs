using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #region PROPIEDADES
        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }


        #endregion

        #region METODOS
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            Local local = llamada as Local;
                            retorno += local.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            Provincial provincial = llamada as Provincial;
                            retorno += provincial.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            Local local = llamada as Local;
                            retorno += local.CostoLlamada;
                        }
                        if (llamada is Provincial)
                        {
                            Provincial provincial = llamada as Provincial;
                            retorno += provincial.CostoLlamada;
                        }
                    }
                    break;
            }

            return retorno;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        #endregion

        #region SOBRECARGAS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Razon social: ");
            sb.AppendLine(this.razonSocial);
            sb.Append("Ganancia total: ");
            sb.AppendLine(this.GananciaPorTotal.ToString());
            sb.Append("Ganancia por llamadas locales: ");
            sb.AppendLine(this.GananciaPorLocal.ToString());
            sb.Append("Ganancia por llamadas Provinciales: ");
            sb.AppendLine(this.GananciaPorProvincial.ToString());
            sb.Append("\t\tLlamadas: \n");
            foreach (Llamada ll in this.listaDeLlamadas)
            {
                sb.AppendLine(ll.ToString());
            }
            sb.Append("\t\t------------------- \n");

            return sb.ToString();
        }
        
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada l in c.listaDeLlamadas)
            {
                if(l == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (!(c == nuevaLlamada))
                c.AgregarLlamada(nuevaLlamada);
            return c;
        }
        #endregion
    }
}

