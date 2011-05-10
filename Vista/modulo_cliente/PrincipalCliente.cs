using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSAC.Modelo.modulo_cliente;


using System.Data.Entity;
using System.Data.EntityClient;
using System.Data.Objects;

namespace SSAC
{
    public partial class PrincipalCliente : Form
    {
        public PrincipalCliente()
        {
            InitializeComponent();

            //CONSULTA LINQ PARA LLENAR DATAGRID PRINCIPAL - FALTA VER CLAVES FORANEAS Y QUE CAMPOS VAMOS A CARGAR.
            using (var context = new SSACEntities())
            {

                IQueryable<CLIENTE> cliente = context.CLIENTE;
                IQueryable<CLIENTEESTADO> clienteEstado = context.CLIENTEESTADO;

                cliente.Load();
                clienteEstado.Load();
                Array clientesArray = (from c in cliente join est in clienteEstado on c.Estado equals est.idEstadoCliente select new { c.Cuenta, c.Nombre, c.NombreFantasia, c.FechaUltVta, est.Descripcion }).ToArray();
                dataGridViewClientesPrincipal.DataSource = clientesArray;//cliente.ToList();
                dataGridViewClientesPrincipal.AllowUserToAddRows = false;
                dataGridViewClientesPrincipal.AllowUserToDeleteRows = false;
                dataGridViewClientesPrincipal.ReadOnly = true;
                dataGridViewClientesPrincipal.MultiSelect = false;
                dataGridViewClientesPrincipal.AutoSize = true;
                dataGridViewClientesPrincipal.AllowUserToOrderColumns = true;
                dataGridViewClientesPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'modClientesDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientePotencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form actClie = new ActualizarCliente();
            actClie.Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewClientes_Principal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientesPrincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            using (var context = new SSACEntities())
            {
                string cuenta = Convert.ToString(dataGridViewClientesPrincipal.CurrentRow.Cells[0].Value);
                CLIENTE cargarCliente = new CLIENTE();
                cargarCliente = context.CLIENTE.First(p => p.Cuenta == cuenta);


                Form actClie = new ActualizarCliente(cargarCliente);
                this.Visible = false;
                actClie.Show();
            }

        }
    }
}
