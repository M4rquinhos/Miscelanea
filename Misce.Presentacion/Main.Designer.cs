namespace Misce.Presentacion
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.stusMain = new System.Windows.Forms.StatusStrip();
            this.tstrpUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sstripTipoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripListaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.stusMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stusMain
            // 
            this.stusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrpUsuario,
            this.toolStripStatusLabel1,
            this.sstripTipoUsuario});
            this.stusMain.Location = new System.Drawing.Point(0, 609);
            this.stusMain.Name = "stusMain";
            this.stusMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stusMain.Size = new System.Drawing.Size(1370, 22);
            this.stusMain.TabIndex = 2;
            this.stusMain.Text = "StatusStrip";
            // 
            // tstrpUsuario
            // 
            this.tstrpUsuario.Name = "tstrpUsuario";
            this.tstrpUsuario.Size = new System.Drawing.Size(39, 17);
            this.tstrpUsuario.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel1.Text = "//";
            // 
            // sstripTipoUsuario
            // 
            this.sstripTipoUsuario.Name = "sstripTipoUsuario";
            this.sstripTipoUsuario.Size = new System.Drawing.Size(39, 17);
            this.sstripTipoUsuario.Text = "Status";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEmpleados});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(77, 20);
            this.fileMenu.Text = "Empleados";
            // 
            // toolStripEmpleados
            // 
            this.toolStripEmpleados.Name = "toolStripEmpleados";
            this.toolStripEmpleados.Size = new System.Drawing.Size(180, 22);
            this.toolStripEmpleados.Text = "Lista de Empleados";
            this.toolStripEmpleados.Click += new System.EventHandler(this.toolStripEmpleados_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.fileMenu});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1370, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "MenuStrip";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripCategorias,
            this.ToolStripListaProductos});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ToolStripCategorias
            // 
            this.ToolStripCategorias.Name = "ToolStripCategorias";
            this.ToolStripCategorias.Size = new System.Drawing.Size(180, 22);
            this.ToolStripCategorias.Text = "Categorias";
            // 
            // ToolStripListaProductos
            // 
            this.ToolStripListaProductos.Name = "ToolStripListaProductos";
            this.ToolStripListaProductos.Size = new System.Drawing.Size(180, 22);
            this.ToolStripListaProductos.Text = "Lista de Productos";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 631);
            this.Controls.Add(this.stusMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.stusMain.ResumeLayout(false);
            this.stusMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip stusMain;
        private System.Windows.Forms.ToolStripStatusLabel tstrpUsuario;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sstripTipoUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripEmpleados;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCategorias;
        private System.Windows.Forms.ToolStripMenuItem ToolStripListaProductos;
    }
}



