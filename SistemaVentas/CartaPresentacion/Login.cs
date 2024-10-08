using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                FormInicio form = new FormInicio();

                form.Show();
                this.Hide(); //para ocultar el form login

                form.FormClosing += form_closing;
            }
            else
            {
                MessageBox.Show("Ingrese Usuario Valido");
            }
            
        }

        //Metodo para volver a mostar el form de login cuando se cierra el de inicio
        private void form_closing(object sender,FormClosingEventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";

            this.Show(); // para mostrar el form login que se encuentra oculto
        }

        private bool ValidarCampos()
        {
            bool res = true;
            if ((txtUser.Text == "") && (txtPassword.Text == ""))
            {
                txtUser.BackColor = Color.LightCoral;
                txtPassword.BackColor = Color.LightCoral;
                res = false;
            }
            else if (txtUser.Text == "")
            {
                txtUser.BackColor = Color.LightCoral;
                res = false;
            }
            else if (txtPassword.Text == "")
            {
                txtPassword.BackColor = Color.LightCoral;
                res = false;
            }

            return res;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
