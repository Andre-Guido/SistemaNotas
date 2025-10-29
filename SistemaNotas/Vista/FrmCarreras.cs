using SistemaNotas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas.Vista
{
    public partial class FrmCarreras : Form
    {
        CarreraController lista = new CarreraController();
        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lista.Agregar(tbNombre.Text, tbCodigo.Text);
            tbNombre.Clear();
            tbCodigo.Clear();
            tbNombre.Focus();
            Listar();
            
        }
        private void Listar()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista.GetCarreras();
            dgvRegistros.Refresh();
        }

        private void dgvRegistros_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRegistros.Rows[e.RowIndex];
                tbNombre.Text = fila.Cells[0].Value.ToString();
                tbCodigo.Text = fila.Cells[1].Value.ToString();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            lista.Eliminar(tbNombre.Text, tbCodigo.Text);
            Listar();
        }
    }
}
