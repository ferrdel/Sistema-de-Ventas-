
using CapaEntities;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CartaPresentacion
{
    public partial class FormInicio : Form
    {
        //variable para indicar el usuario actual
        private static usuarios userActual;

        private static IconMenuItem menuActivo = null;
        private static Form formActivo = null;
        public FormInicio(usuarios objUser)
        {
            InitializeComponent();
        }

        public FormInicio()
        {
        }

        private void Inicio_Load(object sender, EventArgs e)
        {   //se muestra el nombre del usuario logueado
            //lbUser.Text = userActual.Nombre;

        }

        private void AbrirForm(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.AliceBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuUser_Click(object sender, EventArgs e)
        {
            AbrirForm((IconMenuItem)sender, new FormUser());
        }
    }
}
