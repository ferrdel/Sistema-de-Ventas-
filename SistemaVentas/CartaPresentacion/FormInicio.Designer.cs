
namespace CartaPresentacion
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.menuUser = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuClient = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.menuReport = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.RosyBrown;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuTitulo.Size = new System.Drawing.Size(841, 62);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sitema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 137);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(841, 437);
            this.contenedor.TabIndex = 3;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.RosyBrown;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(679, 31);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 15);
            this.labelUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(598, 20);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.RosyBrown;
            this.lbUser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUser.Location = new System.Drawing.Point(658, 20);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(48, 19);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "lbUser";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuUser
            // 
            this.menuUser.ForeColor = System.Drawing.Color.Black;
            this.menuUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuUser.IconColor = System.Drawing.Color.Black;
            this.menuUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUser.IconSize = 50;
            this.menuUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(64, 69);
            this.menuUser.Text = "Usuarios";
            this.menuUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click);
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.menuMantenimiento.ForeColor = System.Drawing.Color.Black;
            this.menuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenimiento.IconColor = System.Drawing.Color.Black;
            this.menuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenimiento.IconSize = 50;
            this.menuMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Size = new System.Drawing.Size(101, 69);
            this.menuMantenimiento.Text = "Mantenimiento";
            this.menuMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // menuVentas
            // 
            this.menuVentas.ForeColor = System.Drawing.Color.Black;
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(62, 69);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCompras
            // 
            this.menuCompras.ForeColor = System.Drawing.Color.Black;
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(67, 69);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuClient
            // 
            this.menuClient.ForeColor = System.Drawing.Color.Black;
            this.menuClient.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClient.IconColor = System.Drawing.Color.Black;
            this.menuClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClient.IconSize = 50;
            this.menuClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClient.Name = "menuClient";
            this.menuClient.Size = new System.Drawing.Size(62, 69);
            this.menuClient.Text = "Clientes";
            this.menuClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuProveedor
            // 
            this.menuProveedor.ForeColor = System.Drawing.Color.Black;
            this.menuProveedor.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.menuProveedor.IconColor = System.Drawing.Color.Black;
            this.menuProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedor.IconSize = 50;
            this.menuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedor.Name = "menuProveedor";
            this.menuProveedor.Size = new System.Drawing.Size(84, 69);
            this.menuProveedor.Text = "Proveedores";
            this.menuProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuReport
            // 
            this.menuReport.ForeColor = System.Drawing.Color.Black;
            this.menuReport.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReport.IconColor = System.Drawing.Color.Black;
            this.menuReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReport.IconSize = 50;
            this.menuReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(65, 69);
            this.menuReport.Text = "Reportes";
            this.menuReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUser,
            this.menuMantenimiento,
            this.menuVentas,
            this.menuCompras,
            this.menuClient,
            this.menuProveedor,
            this.menuReport});
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(841, 75);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 574);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUser;
        private FontAwesome.Sharp.IconMenuItem menuUser;
        private FontAwesome.Sharp.IconMenuItem menuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClient;
        private FontAwesome.Sharp.IconMenuItem menuProveedor;
        private FontAwesome.Sharp.IconMenuItem menuReport;
        private System.Windows.Forms.MenuStrip menu;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
    }
}

