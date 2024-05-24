using proyectosql.data.datacces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectosql
{
    public partial class Form1 : Form
    {
        private personajesdbz personaje;
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };
        public Form1()
        {
            InitializeComponent();
            personaje = new personajesdbz();
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
           if (personaje.probarconexion())
            {
                MessageBox.Show("si pudo conectarse chato");
            }
            else
            {
                MessageBox.Show("no se pudo conectar");
            }
        }

        private void botoncargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            personajes.DataSource = dt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            string raza = comboBoxraza.Text;
            int nivelpoder = (int)numericUpDown1.Value;
            DateTime FechaCreacion = dateTimePicker1.Value;
            string historia = textBoxHistoria.Text;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelpoder, FechaCreacion, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("creado con exito");
                personajes.DataSource = personaje.LeerPersonajes();

            }
            else
            {
                MessageBox.Show("la cagaste en algo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxraza.Items.AddRange(razasDragonBall);
        }

        private void Buscarporid()
        {
            int idpersonajebuscar = int.Parse(textboxid.Text);
            DataTable personajeencontrado = personaje.BuscarPersonajePorId(idpersonajebuscar);
            if (personajeencontrado.Rows.Count > 0)
            {
                string nombre = personajeencontrado.Rows[0]["nombre"].ToString();
                string raza = personajeencontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeencontrado.Rows[0]["nivel_poder"].ToString());
                DateTime FechaCreacion = DateTime.Parse(personajeencontrado.Rows[0]["Fecha_Creacion"].ToString());
                string historia = personajeencontrado.Rows[0]["Historia"].ToString();
                textBoxnombre.Text = nombre;
                comboBoxraza.Text = raza;
                numericUpDown1.Value = nivelPoder;
                dateTimePicker1.Value = FechaCreacion;
                textBoxHistoria.Text = historia;
            }

            else
            {
                MessageBox.Show("no se encontro el codigo");
            }
        }
        private void BuscarNombre()
        {
            string nombrePersonajeBuscar = textBoxnombre.Text;
            DataTable nombreEncontrado = personaje.NombreBuscar(nombrePersonajeBuscar);

            if (nombreEncontrado.Rows.Count > 0)
            {
                int Id = int.Parse(nombreEncontrado.Rows[0]["id"].ToString());
                string raza = nombreEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(nombreEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime FechaCreacion = DateTime.Parse(nombreEncontrado.Rows[0]["Fecha_Creacion"].ToString());
                string historia = nombreEncontrado.Rows[0]["Historia"].ToString();
                textboxid.Text = Id.ToString();
                comboBoxraza.Text = raza;
                numericUpDown1.Value = nivelPoder;
                dateTimePicker1.Value = FechaCreacion;
                textBoxHistoria.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontró el nombre.");
            }
        }
        private void Botonbuscar_Click(object sender, EventArgs e)
        {
            Buscarporid();
           
        }

        private void comboBoxraza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxraza.Text = " ";
            textBoxHistoria.Text = "";
            textboxid.Text = "";
            numericUpDown1.Value = numericUpDown1.Minimum;
            textBoxnombre.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textboxid.Text);
            string nombre = textBoxnombre.Text;
            string raza = comboBoxraza.Text;
            int nivelPoder = (int)numericUpDown1.Value;
            string historia = textBoxHistoria.Text;
            int respuesta = personaje.ActualizarPersonaje(id, nombre, raza, nivelPoder, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("se actualizo con exito el personaje");
                personajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("ha ocurrido un error en la actualizcion");
            }
        }
    }
 }

