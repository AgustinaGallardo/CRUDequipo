using CRUDequipo.Datos;
using CRUDequipo.Dominio;
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
        private Equipo nuevo;
        public AltaForm()
        {
            InitializeComponent();
            gestor = new Servicio();
            nuevo = new Equipo();   
        }
        private void AltaForm_Load(object sender, EventArgs e)
        {
            ObtenerProximo();
            ObtenerPersonas();
            ObtenerTipos();
        }

        private void ObtenerTipos()
        {
            cboPosiciones.ValueMember ="IdTipoPosicion";
            cboPosiciones.DisplayMember="NombreTipo";
            cboPosiciones.DataSource = gestor.ObtenerTipos();
            cboPosiciones.DropDownStyle=ComboBoxStyle.DropDownList;
        }

        private void ObtenerPersonas()
        {
            cboPersonas.ValueMember="IdPersona";
            cboPersonas.DisplayMember="NombreCompleto";
            cboPersonas.DataSource = gestor.ObtenerPersonas();
            cboPersonas.DropDownStyle=ComboBoxStyle.DropDownList;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cboPosiciones.SelectedIndex ==-1)
            {
                MessageBox.Show("Tiene que elegir una posicion ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            if(cboPersonas.SelectedIndex == -1)
            {
                MessageBox.Show("Tiene que elegir una persona", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            if(txtCamiseta.Text == string.Empty)
            {
                MessageBox.Show("Tiene que elegir una camiseta", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            Persona p = (Persona)cboPersonas.SelectedItem;

            TipoPosicion tp = (TipoPosicion)cboPosiciones.SelectedItem;

            string camiseta = txtCamiseta.Text;

            Jugador j = new Jugador(p, tp, camiseta);

            nuevo.AgregarJugador(j);

            dgvEquipo.Rows.Add( j.Persona.IdPersona,j.Persona.NombreCompleto,tp.NombreTipo,j.Camiseta);
               
           txtTotal.Text =  nuevo.CalcularTotal().ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombreDirector.Text == string.Empty)
            {
                MessageBox.Show("Tiene que elegir un director tecnico", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            if(txtNombreEquipo.Text == string.Empty)
            {
                MessageBox.Show("Tiene que elegir un nombre de equipo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            GuardarEquipo();
        }

        private void GuardarEquipo()
        {            
            nuevo.DirectorTecnico = txtNombreDirector.Text;
            nuevo.Nombre = txtNombreEquipo.Text;

            if(Helper.ObtenerInstancia().ConfirmarEquipo(nuevo))
            {
                MessageBox.Show("Se inserto con exito el equipo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo insertar el equipo", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        
        }
    }
}
