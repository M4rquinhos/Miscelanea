using Misce.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Misce.Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        
        private void Acceder()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Acceder(txtUsuario.Text.Trim(), txtClave.Text.Trim(), "Activo");
                if (tabla.Rows.Count <= 0 )
                {
                    MessageBox.Show($"Usuario no encontrado", $"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Usuario no encontrado", $"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Acceder();
        }
    }
}
