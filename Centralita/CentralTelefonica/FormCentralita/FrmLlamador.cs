using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FormCentralita
{
    public partial class FrmLlamador : Form
    {
        public Centralita central;

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.central = c;

        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {

        }

        /*FrmLlamador tendrá una propiedad de sólo lectura que expondrá dicha Centralita, a
        fin de volver a ser leída por el formulario de menú una vez terminada la acción.*/
        public Centralita Central
        {
            get
            {
                return this.Central;
            }
        }
    }
}
