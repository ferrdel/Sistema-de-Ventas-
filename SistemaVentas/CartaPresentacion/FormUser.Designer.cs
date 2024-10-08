
namespace CartaPresentacion
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TabDatos = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BTbuscaUs = new System.Windows.Forms.Button();
            this.TBbuscar = new System.Windows.Forms.TextBox();
            this.BTEditar = new System.Windows.Forms.Button();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.BTElimina = new System.Windows.Forms.Button();
            this.TabFormUsuario = new System.Windows.Forms.TabPage();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.txtPassRep = new System.Windows.Forms.TextBox();
            this.lbPassRep = new System.Windows.Forms.Label();
            this.BTvolver = new System.Windows.Forms.Button();
            this.BTguardaMod = new System.Windows.Forms.Button();
            this.LBtipoPerfil = new System.Windows.Forms.Label();
            this.CBtipoPerfil = new System.Windows.Forms.ComboBox();
            this.CBestado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BTcancel = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPassw = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPassw = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.TabDatos.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.TabFormUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Usuarios";
            // 
            // TabDatos
            // 
            this.TabDatos.Controls.Add(this.TabPage1);
            this.TabDatos.Controls.Add(this.TabFormUsuario);
            this.TabDatos.Location = new System.Drawing.Point(40, 50);
            this.TabDatos.Name = "TabDatos";
            this.TabDatos.SelectedIndex = 0;
            this.TabDatos.Size = new System.Drawing.Size(666, 398);
            this.TabDatos.TabIndex = 10;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.TabPage1.Controls.Add(this.label6);
            this.TabPage1.Controls.Add(this.label3);
            this.TabPage1.Controls.Add(this.radioButton3);
            this.TabPage1.Controls.Add(this.radioButton2);
            this.TabPage1.Controls.Add(this.BtnNuevo);
            this.TabPage1.Controls.Add(this.BTbuscaUs);
            this.TabPage1.Controls.Add(this.TBbuscar);
            this.TabPage1.Controls.Add(this.BTEditar);
            this.TabPage1.Controls.Add(this.DGUsuarios);
            this.TabPage1.Controls.Add(this.BTElimina);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(658, 372);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Listado";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(166, 19);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(460, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lista de Usuarios";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filtrar por:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(35, 180);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton3.Size = new System.Drawing.Size(63, 19);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Estado";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(35, 157);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2.Size = new System.Drawing.Size(112, 19);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tipo de Usuario";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnNuevo.Location = new System.Drawing.Point(270, 312);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 28);
            this.BtnNuevo.TabIndex = 16;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // BTbuscaUs
            // 
            this.BTbuscaUs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTbuscaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTbuscaUs.ForeColor = System.Drawing.Color.Black;
            this.BTbuscaUs.Location = new System.Drawing.Point(46, 69);
            this.BTbuscaUs.Name = "BTbuscaUs";
            this.BTbuscaUs.Size = new System.Drawing.Size(65, 27);
            this.BTbuscaUs.TabIndex = 13;
            this.BTbuscaUs.Text = "Buscar";
            this.BTbuscaUs.UseVisualStyleBackColor = false;
            // 
            // TBbuscar
            // 
            this.TBbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TBbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBbuscar.Location = new System.Drawing.Point(13, 102);
            this.TBbuscar.Name = "TBbuscar";
            this.TBbuscar.Size = new System.Drawing.Size(134, 20);
            this.TBbuscar.TabIndex = 14;
            // 
            // BTEditar
            // 
            this.BTEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditar.ForeColor = System.Drawing.Color.Gold;
            this.BTEditar.Location = new System.Drawing.Point(390, 312);
            this.BTEditar.Name = "BTEditar";
            this.BTEditar.Size = new System.Drawing.Size(75, 28);
            this.BTEditar.TabIndex = 11;
            this.BTEditar.Text = "Editar";
            this.BTEditar.UseVisualStyleBackColor = false;
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.AllowUserToOrderColumns = true;
            this.DGUsuarios.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DGUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsuarios.Location = new System.Drawing.Point(170, 69);
            this.DGUsuarios.MultiSelect = false;
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.ReadOnly = true;
            this.DGUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGUsuarios.Size = new System.Drawing.Size(446, 191);
            this.DGUsuarios.TabIndex = 10;
            // 
            // BTElimina
            // 
            this.BTElimina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTElimina.ForeColor = System.Drawing.Color.Tomato;
            this.BTElimina.Location = new System.Drawing.Point(516, 312);
            this.BTElimina.Name = "BTElimina";
            this.BTElimina.Size = new System.Drawing.Size(75, 28);
            this.BTElimina.TabIndex = 12;
            this.BTElimina.Text = "Eliminar";
            this.BTElimina.UseVisualStyleBackColor = false;
            // 
            // TabFormUsuario
            // 
            this.TabFormUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.TabFormUsuario.Controls.Add(this.dtFecha);
            this.TabFormUsuario.Controls.Add(this.txtEmail);
            this.TabFormUsuario.Controls.Add(this.lbEmail);
            this.TabFormUsuario.Controls.Add(this.txtTelefono);
            this.TabFormUsuario.Controls.Add(this.lbTelefono);
            this.TabFormUsuario.Controls.Add(this.lbFechaNac);
            this.TabFormUsuario.Controls.Add(this.txtPassRep);
            this.TabFormUsuario.Controls.Add(this.lbPassRep);
            this.TabFormUsuario.Controls.Add(this.BTvolver);
            this.TabFormUsuario.Controls.Add(this.BTguardaMod);
            this.TabFormUsuario.Controls.Add(this.LBtipoPerfil);
            this.TabFormUsuario.Controls.Add(this.CBtipoPerfil);
            this.TabFormUsuario.Controls.Add(this.CBestado);
            this.TabFormUsuario.Controls.Add(this.lbEstado);
            this.TabFormUsuario.Controls.Add(this.TxtUsuario);
            this.TabFormUsuario.Controls.Add(this.BTcancel);
            this.TabFormUsuario.Controls.Add(this.TxtNombre);
            this.TabFormUsuario.Controls.Add(this.TxtPassw);
            this.TabFormUsuario.Controls.Add(this.lbUser);
            this.TabFormUsuario.Controls.Add(this.lbPassw);
            this.TabFormUsuario.Controls.Add(this.lbNombre);
            this.TabFormUsuario.Controls.Add(this.TxtApellido);
            this.TabFormUsuario.Controls.Add(this.lbApellido);
            this.TabFormUsuario.Location = new System.Drawing.Point(4, 22);
            this.TabFormUsuario.Name = "TabFormUsuario";
            this.TabFormUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.TabFormUsuario.Size = new System.Drawing.Size(658, 372);
            this.TabFormUsuario.TabIndex = 1;
            this.TabFormUsuario.Text = "Datos";
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Location = new System.Drawing.Point(118, 84);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(179, 20);
            this.dtFecha.TabIndex = 48;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(347, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 47;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(319, 115);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 16);
            this.lbEmail.TabIndex = 46;
            this.lbEmail.Text = "Email *";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(347, 84);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(179, 20);
            this.txtTelefono.TabIndex = 45;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.ForeColor = System.Drawing.Color.Black;
            this.lbTelefono.Location = new System.Drawing.Point(319, 65);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(80, 16);
            this.lbTelefono.TabIndex = 44;
            this.lbTelefono.Text = "Telefono *";
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.ForeColor = System.Drawing.Color.Black;
            this.lbFechaNac.Location = new System.Drawing.Point(90, 65);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(133, 16);
            this.lbFechaNac.TabIndex = 42;
            this.lbFechaNac.Text = "Fecha Nacimiento";
            // 
            // txtPassRep
            // 
            this.txtPassRep.Location = new System.Drawing.Point(347, 182);
            this.txtPassRep.Name = "txtPassRep";
            this.txtPassRep.Size = new System.Drawing.Size(178, 20);
            this.txtPassRep.TabIndex = 41;
            // 
            // lbPassRep
            // 
            this.lbPassRep.AutoSize = true;
            this.lbPassRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassRep.ForeColor = System.Drawing.Color.Black;
            this.lbPassRep.Location = new System.Drawing.Point(319, 166);
            this.lbPassRep.Name = "lbPassRep";
            this.lbPassRep.Size = new System.Drawing.Size(93, 13);
            this.lbPassRep.TabIndex = 40;
            this.lbPassRep.Text = "Repetir Clave *";
            // 
            // BTvolver
            // 
            this.BTvolver.BackColor = System.Drawing.Color.DarkKhaki;
            this.BTvolver.Location = new System.Drawing.Point(577, 302);
            this.BTvolver.Name = "BTvolver";
            this.BTvolver.Size = new System.Drawing.Size(75, 27);
            this.BTvolver.TabIndex = 39;
            this.BTvolver.Text = "Volver";
            this.BTvolver.UseVisualStyleBackColor = false;
            // 
            // BTguardaMod
            // 
            this.BTguardaMod.BackColor = System.Drawing.Color.YellowGreen;
            this.BTguardaMod.Location = new System.Drawing.Point(161, 286);
            this.BTguardaMod.Name = "BTguardaMod";
            this.BTguardaMod.Size = new System.Drawing.Size(136, 43);
            this.BTguardaMod.TabIndex = 38;
            this.BTguardaMod.Text = "Guardar";
            this.BTguardaMod.UseVisualStyleBackColor = false;
            this.BTguardaMod.Click += new System.EventHandler(this.BTguardaMod_Click);
            // 
            // LBtipoPerfil
            // 
            this.LBtipoPerfil.AutoSize = true;
            this.LBtipoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtipoPerfil.ForeColor = System.Drawing.Color.Black;
            this.LBtipoPerfil.Location = new System.Drawing.Point(90, 213);
            this.LBtipoPerfil.Name = "LBtipoPerfil";
            this.LBtipoPerfil.Size = new System.Drawing.Size(98, 16);
            this.LBtipoPerfil.TabIndex = 37;
            this.LBtipoPerfil.Text = "Tipo Usuario";
            // 
            // CBtipoPerfil
            // 
            this.CBtipoPerfil.FormattingEnabled = true;
            this.CBtipoPerfil.Items.AddRange(new object[] {
            "Admin",
            "Gerente",
            "Vendedor"});
            this.CBtipoPerfil.Location = new System.Drawing.Point(117, 232);
            this.CBtipoPerfil.Name = "CBtipoPerfil";
            this.CBtipoPerfil.Size = new System.Drawing.Size(178, 21);
            this.CBtipoPerfil.TabIndex = 36;
            // 
            // CBestado
            // 
            this.CBestado.FormattingEnabled = true;
            this.CBestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBestado.Location = new System.Drawing.Point(346, 232);
            this.CBestado.Name = "CBestado";
            this.CBestado.Size = new System.Drawing.Size(179, 21);
            this.CBestado.TabIndex = 35;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.Black;
            this.lbEstado.Location = new System.Drawing.Point(317, 213);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(57, 16);
            this.lbEstado.TabIndex = 34;
            this.lbEstado.Text = "Estado";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(118, 134);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(179, 20);
            this.TxtUsuario.TabIndex = 31;
            // 
            // BTcancel
            // 
            this.BTcancel.BackColor = System.Drawing.Color.IndianRed;
            this.BTcancel.Location = new System.Drawing.Point(347, 286);
            this.BTcancel.Name = "BTcancel";
            this.BTcancel.Size = new System.Drawing.Size(136, 43);
            this.BTcancel.TabIndex = 29;
            this.BTcancel.Text = "Cancelar";
            this.BTcancel.UseVisualStyleBackColor = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(346, 38);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(179, 20);
            this.TxtNombre.TabIndex = 17;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtPassw
            // 
            this.TxtPassw.Location = new System.Drawing.Point(118, 182);
            this.TxtPassw.Name = "TxtPassw";
            this.TxtPassw.Size = new System.Drawing.Size(178, 20);
            this.TxtPassw.TabIndex = 25;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.Black;
            this.lbUser.Location = new System.Drawing.Point(90, 115);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(72, 16);
            this.lbUser.TabIndex = 22;
            this.lbUser.Text = "Usuario *";
            // 
            // lbPassw
            // 
            this.lbPassw.AutoSize = true;
            this.lbPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassw.ForeColor = System.Drawing.Color.Black;
            this.lbPassw.Location = new System.Drawing.Point(90, 166);
            this.lbPassw.Name = "lbPassw";
            this.lbPassw.Size = new System.Drawing.Size(48, 13);
            this.lbPassw.TabIndex = 24;
            this.lbPassw.Text = "Clave *";
            this.lbPassw.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Black;
            this.lbNombre.Location = new System.Drawing.Point(326, 19);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 16);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Nombre *";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(118, 38);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(179, 20);
            this.TxtApellido.TabIndex = 15;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.Black;
            this.lbApellido.Location = new System.Drawing.Point(90, 19);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(76, 16);
            this.lbApellido.TabIndex = 0;
            this.lbApellido.Text = "Apellido *";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.TabDatos);
            this.Controls.Add(this.label1);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.TabDatos.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.TabFormUsuario.ResumeLayout(false);
            this.TabFormUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TabControl TabDatos;
        internal System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        internal System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.Button BTbuscaUs;
        internal System.Windows.Forms.TextBox TBbuscar;
        internal System.Windows.Forms.Button BTEditar;
        internal System.Windows.Forms.DataGridView DGUsuarios;
        internal System.Windows.Forms.Button BTElimina;
        internal System.Windows.Forms.TabPage TabFormUsuario;
        internal System.Windows.Forms.Button BTvolver;
        internal System.Windows.Forms.Button BTguardaMod;
        internal System.Windows.Forms.Label LBtipoPerfil;
        internal System.Windows.Forms.ComboBox CBtipoPerfil;
        internal System.Windows.Forms.ComboBox CBestado;
        internal System.Windows.Forms.Label lbEstado;
        internal System.Windows.Forms.TextBox TxtUsuario;
        internal System.Windows.Forms.Button BTcancel;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.TextBox TxtPassw;
        internal System.Windows.Forms.Label lbUser;
        internal System.Windows.Forms.Label lbPassw;
        internal System.Windows.Forms.Label lbNombre;
        internal System.Windows.Forms.TextBox TxtApellido;
        internal System.Windows.Forms.Label lbApellido;
        internal System.Windows.Forms.TextBox txtPassRep;
        internal System.Windows.Forms.Label lbPassRep;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label lbEmail;
        internal System.Windows.Forms.TextBox txtTelefono;
        internal System.Windows.Forms.Label lbTelefono;
        internal System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}