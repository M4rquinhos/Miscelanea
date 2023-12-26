namespace Misce.Presentacion
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.pnlIcono = new Telerik.WinControls.UI.RadPanel();
            this.picIcono = new System.Windows.Forms.PictureBox();
            this.txtClave = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBoxControl();
            this.btnIniciar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIcono)).BeginInit();
            this.pnlIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(294, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Miscelanea";
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(78)))));
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Location = new System.Drawing.Point(1, 1);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(730, 62);
            this.radPanel1.TabIndex = 3;
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(218)))), ((int)(((byte)(213)))));
            this.radPanel2.Controls.Add(this.pnlIcono);
            this.radPanel2.Controls.Add(this.txtClave);
            this.radPanel2.Controls.Add(this.txtUsuario);
            this.radPanel2.Controls.Add(this.btnIniciar);
            this.radPanel2.Controls.Add(this.radLabel2);
            this.radPanel2.Controls.Add(this.radLabel1);
            this.radPanel2.Location = new System.Drawing.Point(55, 106);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(615, 247);
            this.radPanel2.TabIndex = 4;
            // 
            // pnlIcono
            // 
            this.pnlIcono.BackColor = System.Drawing.Color.Transparent;
            this.pnlIcono.Controls.Add(this.picIcono);
            this.pnlIcono.Location = new System.Drawing.Point(45, 36);
            this.pnlIcono.Name = "pnlIcono";
            this.pnlIcono.Size = new System.Drawing.Size(192, 163);
            this.pnlIcono.TabIndex = 5;
            // 
            // picIcono
            // 
            this.picIcono.Image = ((System.Drawing.Image)(resources.GetObject("picIcono.Image")));
            this.picIcono.Location = new System.Drawing.Point(35, 20);
            this.picIcono.Name = "picIcono";
            this.picIcono.Size = new System.Drawing.Size(128, 128);
            this.picIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIcono.TabIndex = 0;
            this.picIcono.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(397, 95);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(158, 22);
            this.txtClave.TabIndex = 6;
            this.txtClave.ThemeName = "ControlDefault";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(397, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(158, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.ThemeName = "ControlDefault";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(395, 135);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(160, 45);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.ThemeName = "ControlDefault";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(316, 99);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(35, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Clave:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(316, 56);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Usuario:";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(732, 397);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "Frm_Login";
            this.Text = ". : Iniciar Sesión : .";
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlIcono)).EndInit();
            this.pnlIcono.ResumeLayout(false);
            this.pnlIcono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl txtClave;
        private Telerik.WinControls.UI.RadTextBoxControl txtUsuario;
        private Telerik.WinControls.UI.RadButton btnIniciar;
        private Telerik.WinControls.UI.RadPanel pnlIcono;
        private System.Windows.Forms.PictureBox picIcono;
    }
}

