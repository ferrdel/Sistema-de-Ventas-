using CapaNegocio;
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
    public partial class FormUser : Form
    {
        UserLogic userLogic = new UserLogic();

        //DateTime thisDay = DateTime.Today;

        public FormUser()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        private void MostrarDataGrid(object o)
        {
            DGUsuarios.DataSource = null;
            DGUsuarios.DataSource = o;
        }

        private void ListarUsuarios()
        {
            try
            {
                MostrarDataGrid(userLogic.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }
        

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            TxtApellido.Clear();
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtPassw.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)){
                e.Handled = false;
            }else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTguardaMod_Click(object sender, EventArgs e)
        {
            if (ValidarCamposUser())
            {
                MessageBox.Show("Usuario Creado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Campos Erroneos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ValidarCamposUser()
        {
            bool res = true;
            if (TxtApellido.Text == "")
            {
                lbApellido.BackColor = Color.LightCoral;
                res = false;
            }
            if (TxtNombre.Text == "")
            {
                lbNombre.BackColor = Color.LightCoral;
                res = false;
            }
            if (TxtUsuario.Text == "")
            {
                lbUser.BackColor = Color.LightCoral;
                res = false;
            }
            if (TxtPassw.Text == "")
            {
                lbPassw.BackColor = Color.LightCoral;
                res = false;
            }
            if (txtPassRep.Text == "")
            {
                lbPassRep.BackColor = Color.LightCoral;
                res = false;
            }
            if (txtTelefono.Text == "")
            {
                lbPassRep.BackColor = Color.LightCoral;
                res = false;
            }
            if (txtEmail.Text == "")
            {
                lbPassRep.BackColor = Color.LightCoral;
                res = false;
            }

            return res;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
