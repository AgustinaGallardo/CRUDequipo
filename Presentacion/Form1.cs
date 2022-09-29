using CRUDequipo.Servicios.Implementacion;
using CRUDequipo.Servicios.Intefaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDequipo
{
    public partial class AltaForm : Form
    {
        private IServicio gestor;
        public AltaForm()
        {
            InitializeComponent();
            gestor = new Servicio();
        }

        private void AltaForm_Load(object sender, EventArgs e)
        {
            ObtenerProximo();

        }

        private void ObtenerProximo()
        {
            int next = gestor.ObtenerProximo();
            if(next > 0)
            {
               lblNext.Text = "Nro Equipo " + next.ToString();
            }
            else
            {
                MessageBox.Show("No se puede obtener el proximo equipo ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
