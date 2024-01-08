namespace Misce.Presentacion
{
    partial class Frm_Empleados
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleados));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPFiltros = new System.Windows.Forms.TabPage();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tabPInformacion = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCambiaEstado = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarUsuario = new System.Windows.Forms.ToolStripButton();
            this.tabPrincipal.SuspendLayout();
            this.tabPFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPFiltros);
            this.tabPrincipal.Controls.Add(this.tabPInformacion);
            this.tabPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.Location = new System.Drawing.Point(1, 75);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1159, 538);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPFiltros
            // 
            this.tabPFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
            this.tabPFiltros.Controls.Add(this.radGridView1);
            this.tabPFiltros.Controls.Add(this.radPanel1);
            this.tabPFiltros.Location = new System.Drawing.Point(4, 25);
            this.tabPFiltros.Name = "tabPFiltros";
            this.tabPFiltros.Padding = new System.Windows.Forms.Padding(3);
            this.tabPFiltros.Size = new System.Drawing.Size(1151, 509);
            this.tabPFiltros.TabIndex = 0;
            this.tabPFiltros.Text = "Busqueda";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(6, 183);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1139, 320);
            this.radGridView1.TabIndex = 1;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(215)))), ((int)(((byte)(90)))));
            this.radPanel1.Location = new System.Drawing.Point(6, 29);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1139, 134);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "ControlDefault";
            // 
            // tabPInformacion
            // 
            this.tabPInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
            this.tabPInformacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPInformacion.Location = new System.Drawing.Point(4, 25);
            this.tabPInformacion.Name = "tabPInformacion";
            this.tabPInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPInformacion.Size = new System.Drawing.Size(1449, 542);
            this.tabPInformacion.TabIndex = 1;
            this.tabPInformacion.Text = "Informacion";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnGuardar,
            this.btnCambiaEstado,
            this.btnEliminarUsuario});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1158, 51);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Size = new System.Drawing.Size(48, 48);
            this.btnAgregar.Text = "Agregar Empleado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Size = new System.Drawing.Size(48, 48);
            this.btnGuardar.Text = "Guardar Empleado";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCambiaEstado
            // 
            this.btnCambiaEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCambiaEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiaEstado.Image")));
            this.btnCambiaEstado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCambiaEstado.Name = "btnCambiaEstado";
            this.btnCambiaEstado.Padding = new System.Windows.Forms.Padding(2);
            this.btnCambiaEstado.Size = new System.Drawing.Size(48, 48);
            this.btnCambiaEstado.Text = "Cambiar Estado";
            this.btnCambiaEstado.Click += new System.EventHandler(this.btnCambiaEstado_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarUsuario.Image")));
            this.btnEliminarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Size = new System.Drawing.Size(48, 48);
            this.btnEliminarUsuario.Text = "Eliminar Empleado";
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // Frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1162, 610);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Empleados";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Frm_Empleados";
            this.Load += new System.EventHandler(this.Frm_Empleados_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPFiltros;
        private System.Windows.Forms.TabPage tabPInformacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminarUsuario;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCambiaEstado;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}