using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace VeterinariaCompleto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbTodos.Checked = true;
        }

        private void CargarAnimales()
        {
            string sql;

            if (rbTodos.Checked)
            {
                sql = $@"select 
                        Animales.IdAnimal,
                        Animales.Nombre, 
                        Especies.IdEspecie,
                        Especies.Especie, 
                        Animales.Raza, 
                        Animales.FechaNac, 
                        Animales.Sexo, 
                        Animales.Activo 
                       from Animales 
                       join Especies on Animales.IdEspecie = Especies.IdEspecie
                       order by Nombre asc";
            }
            else if (rbActivos.Checked)
            {
                sql = $@"select 
                        Animales.IdAnimal,
                        Animales.Nombre, 
                        Especies.IdEspecie,
                        Especies.Especie, 
                        Animales.Raza, 
                        Animales.FechaNac, 
                        Animales.Sexo, 
                        Animales.Activo 
                       from Animales 
                       join Especies on Animales.IdEspecie = Especies.IdEspecie
                       where Animales.Activo = {1}
                       order by Nombre asc";
            }
            else
            {
                sql = $@"select 
                        Animales.IdAnimal,
                        Animales.Nombre, 
                        Especies.IdEspecie,
                        Especies.Especie, 
                        Animales.Raza, 
                        Animales.FechaNac, 
                        Animales.Sexo, 
                        Animales.Activo 
                       from Animales 
                       join Especies on Animales.IdEspecie = Especies.IdEspecie
                       where Animales.Activo = {0}
                       order by Nombre asc";
            }

            DataTable dt = new DataTable();
            dt = Libreria.Recuperar(sql);
            dgvAnimales.DataSource = dt;
            dgvAnimales.AllowUserToAddRows = false;
            dgvAnimales.AllowUserToDeleteRows = false;
            dgvAnimales.ReadOnly = true;
            dgvAnimales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimales.Columns["IdAnimal"].Visible = false;
            dgvAnimales.Columns["IdEspecie"].Visible = false;
        }
        private void CargarIntervenciones()
        {
            int id = int.Parse(dgvAnimales.CurrentRow.Cells["IdAnimal"].Value.ToString());
            string sql = $@"select 
                            Intervenciones.IdAnimal,
                            Intervenciones.FechaHora,
                            Intervenciones.Tipo,
                            Intervenciones.Descripcion,
                            Doctores.Apellido + ', ' + Doctores.Nombre as Doctor
                          from Intervenciones
                          join Doctores on Intervenciones.IdDoctor = Doctores.IdDoctor
                          where IdAnimal = {id}";
            DataTable dt = new DataTable();
            dt = Libreria.Recuperar(sql);
            dgvIntervencion.DataSource = dt;
            dgvIntervencion.AllowUserToAddRows = false;
            dgvIntervencion.AllowUserToDeleteRows = false;
            dgvIntervencion.ReadOnly = true;
            dgvIntervencion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIntervencion.Columns["IdAnimal"].Visible = false;

            string nombre = $"{dgvAnimales.CurrentRow.Cells["Nombre"].Value.ToString()}";
            string especie = $"{dgvAnimales.CurrentRow.Cells["Especie"].Value.ToString()}";
            lblAnimal.Text = nombre + ", " + especie;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            CargarAnimales();
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarAnimales();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarAnimales();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            CargarAnimales();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarIntervenciones();
        }

        private void eXPORTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cadena;
            
            FileStream archivo = new FileStream("Archivo.csv",FileMode.Create);
            StreamWriter contenido = new StreamWriter(archivo);

            foreach (DataGridViewRow fila in dgvIntervencion.Rows)
            {
                cadena = string.Empty;
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    cadena += celda.Value.ToString() + ";";
                }
                contenido.WriteLine(cadena);
            }
            MessageBox.Show("Se exportó correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            contenido.Close();
            archivo.Close();
        }

        private void mOSTRARDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAnimales.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql;
                int id = int.Parse(dgvAnimales.CurrentRow.Cells["IdAnimal"].Value.ToString());
                bool activo = Convert.ToBoolean(dgvAnimales.CurrentRow.Cells["Activo"].Value.ToString());

                if (activo)
                {
                    sql = $"update Animales set Activo = {0} where IdAnimal = {id}";
                }
                else
                {
                    sql = $"update Animales set Activo = {1} where IdAnimal = {id}";
                }

                Libreria.Ejecutar(sql);
                CargarAnimales();
            }
            
        }

        private void vERDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.Id = int.Parse(dgvAnimales.CurrentRow.Cells["IdAnimal"].Value.ToString());
            datos.ShowDialog();
        }
    }
}
