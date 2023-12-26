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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empleados));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPFiltros = new System.Windows.Forms.TabPage();
            this.tabPInformacion = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.tabPrincipal.SuspendLayout();
            this.tabPInformacion.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPFiltros);
            this.tabPrincipal.Controls.Add(this.tabPInformacion);
            this.tabPrincipal.Location = new System.Drawing.Point(1, 42);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1457, 604);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPFiltros
            // 
            this.tabPFiltros.Location = new System.Drawing.Point(4, 22);
            this.tabPFiltros.Name = "tabPFiltros";
            this.tabPFiltros.Padding = new System.Windows.Forms.Padding(3);
            this.tabPFiltros.Size = new System.Drawing.Size(1449, 491);
            this.tabPFiltros.TabIndex = 0;
            this.tabPFiltros.Text = "Filtros";
            this.tabPFiltros.UseVisualStyleBackColor = true;
            // 
            // tabPInformacion
            // 
            this.tabPInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
            this.tabPInformacion.Controls.Add(this.groupBox1);
            this.tabPInformacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPInformacion.Location = new System.Drawing.Point(4, 22);
            this.tabPInformacion.Name = "tabPInformacion";
            this.tabPInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPInformacion.Size = new System.Drawing.Size(1449, 578);
            this.tabPInformacion.TabIndex = 1;
            this.tabPInformacion.Text = "Informacion";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1458, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregar.Image")));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(36, 36);
            this.tsbAgregar.Text = "toolStripButton1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGridView1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1434, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(6, 122);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(1422, 437);
            this.radGridView1.TabIndex = 0;
            // 
            // Frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(1458, 647);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Empleados";
            this.Text = "Frm_Empleados";
            this.tabPrincipal.ResumeLayout(false);
            this.tabPInformacion.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPFiltros;
        private System.Windows.Forms.TabPage tabPInformacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}