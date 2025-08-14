using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace VeterinariaCompleto
{
    public partial class Datos : Form
    {
        public int Id {  get; set; }
        public Datos()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Id = 0;
        }
        
        private void Datos_Load(object sender, EventArgs e)
        {
            string sql;

            if (this.Id != 0)
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
                       where IdAnimal = {this.Id}";

                DataTable dt = new DataTable();
                dt = Libreria.Recuperar(sql);

                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtEspecie.Text = dt.Rows[0]["Especie"].ToString();
                txtRaza.Text = dt.Rows[0]["Raza"].ToString();
                txtSexo.Text = dt.Rows[0]["Sexo"].ToString();
            }
        }
    }
}
