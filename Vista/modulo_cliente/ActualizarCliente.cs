using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.EntityClient;
using SSAC;
using SSAC.Modelo.modulo_cliente;
using System.Data.Objects;





namespace SSAC
{
    public partial class ActualizarCliente : Form
    {
        
        public ActualizarCliente()
        {
            InitializeComponent();


            //PAIS
            using (var context = new SSACEntities())
            {

           IQueryable<PAIS> paises= context.PAIS;
           paises.Load();
           comboBoxPaises.DataSource = paises.ToList();
           comboBoxPaises.DisplayMember = "Descripcion";
           comboBoxPaises.ValueMember = "Codigo";


           IQueryable<ZONA> zonas = context.ZONA;
           zonas.Load();
           comboBoxZonas.DataSource = zonas.ToList();
           comboBoxZonas.DisplayMember = "Descripcion";
           comboBoxZonas.ValueMember = "Codigo";



           IQueryable<LOCALIDAD> localidades = context.LOCALIDAD;
           localidades.Load();
           comboBoxLocalidades.DataSource = localidades.ToList();
           comboBoxLocalidades.DisplayMember = "Descripcion";
           comboBoxLocalidades.ValueMember = "Codigo";

                

                


            

            }
           

        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'modClientesDataSet.LOCALIDAD' Puede moverla o quitarla según sea necesario.


        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level == 0)
            {

                if (treeView1.SelectedNode.IsSelected == true)
                {
                    groupBoxEstablecimientos.Visible = true;
                }
                else

                { groupBoxEstablecimientos.Visible = false; }
            }
            else if
                (treeView1.SelectedNode.Level == 1)
            {

                if (treeView1.SelectedNode.IsSelected == true)
                {
                    groupBoxLotes.Visible = true;
                }
                else
                { groupBoxLotes.Visible = false; }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Uno");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

          

            SSACEntities clictx = new SSACEntities();
         
            //TestClientes cliotro = new TestClientes();
            //cliotro.nombre = "Marcelo";
            //cliotro.id = 432;

            CLIENTE cli = new CLIENTE();
            cli.NombreFantasia = txtNomFantasia.Text;
            cli.CUIT = txtCuit.Text;
            cli.CBU = txtCbu.Text;
            cli.CondicionGanancia = Convert.ToInt32(txtCondGanancia.Text);
            cli.NumeroGanancia = txtNumGanacia.Text;
            cli.CondicionIngBru = Convert.ToInt32(txtCondIngBruto.Text);
            cli.NumeroIngBru = txtNumIngBruto.Text;         
            cli.FechaVtoGanancia = dateFechaVtoGanancia.Value;
           
            cli.CondicionIVA = Convert.ToInt32(txtCondicionIva.Text);
            cli.NumeroJubilacion = txtNumJubilacion.Text;
            cli.GananciaCodigo = txtGanaciaCodigo.Text;
            cli.Domicilio = txtDomicilio.Text;
            cli.NroDomicilio = Convert.ToInt32(txtNumDomicilio.Text);

            // Los codigos son en este formato 1001-00 = Capital federal. Hacer un select con LINQ.
            cli.Localidad = Convert.ToString(comboBoxLocalidades.SelectedValue);

            //Los codigos zona (FK) son en formato 045 = cordoba. Hacer un select con LINQ.
            cli.Zona = Convert.ToString(comboBoxZonas.SelectedValue);
            //Codigo pais (FK) formato AR = argentina. Hacer select con linq combobox.

           


            cli.Pais = Convert.ToString(comboBoxPaises.SelectedValue);
            cli.Telefono = txtTelefono.Text;
            cli.Fax = txtFax.Text;
            cli.EMail = txtEmail.Text;
            cli.Observacion = txtObservaciones.Text;
            // la parte de arriba. VER CON MARCELO 
            cli.Cuenta = txtCuenta.Text;
            cli.Estado = Convert.ToInt32(txtEstado.Text);
            cli.Nombre = txtNombre.Text;

            clictx.CLIENTE.Add(cli);
            clictx.SaveChanges();

            MessageBox.Show("Cliente Agregado a la bd ");




         //   clictx.TestClientes.Add(cliotro);
           // clictx.SaveChanges();
            //MessageBox.Show("Agregado a la bd");
            


        }

        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
