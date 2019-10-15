using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #region PROPIEDADES
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                    this.directorTecnico = value;
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

        #region OPERADORES
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();            sb.Append("Nombre del equipo: ");            sb.AppendLine(e.Nombre);            if(e.directorTecnico == null)
            {
                sb.AppendLine("Sin DT asignado ");
            }            else
            {
                sb.AppendLine("Director tecnico: ");
                sb.AppendLine(e.directorTecnico.Mostrar());
            }            sb.AppendLine("Jugadores: ");            foreach (Jugador j in e.jugadores)
            {
                
                sb.AppendLine(j.Mostrar());
            }            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            return (e.jugadores.Contains(j));
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
                e.jugadores.Add(j);
            return e;
        }
        #endregion
        public static bool ValidarEquipo(Equipo e)
        {
            int contArquero=0;
            int contDelantero=0;
            int contDefensor=0;
            int contCentral=0;

            foreach (Jugador j in e.jugadores)
            {
                switch (j.Posicion)
                {
                    case Posicion.Arquero:
                        contArquero++;
                        break;
                    case Posicion.Delantero:
                        contDelantero++;
                        break;
                    case Posicion.Defensor:
                        contDefensor++;
                        break;
                    case Posicion.Central:
                        contCentral++;
                        break;
                }
            }

            if (e.directorTecnico != null && contArquero == 1 && contDelantero>0 && contDefensor>0 && contCentral>0 && e.jugadores.Count == cantidadMaximaJugadores)
            {
                return true;
            }
            return false;
        }
    }
}
