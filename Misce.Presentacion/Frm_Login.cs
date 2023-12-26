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

        private void MensajeError(string mensaje)
        {
            MessageBox.Show($"{mensaje}", $"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeExito(string mensaje)
        {
            MessageBox.Show($"{mensaje}", $"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void VerificarCampos()
        {

        }

        private void Acceder()
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NUsuario.Acceder(txtUsuario.Text.Trim(), txtClave.Text.Trim());
                if (tabla.Rows.Count <= 0)
                {
                    this.MensajeError($"Error al intentar iniciar sesión.\n" +
                                      $"Revise:\n" +
                                      $"- Usuario\n" +
                                      $"- Clave\n" +
                                      $"- Estado dentro del sistema");
                }
                else
                {

                    //MessageBox.Show($"", $"Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main();
                    main.nombre = $"Usuario: {Convert.ToString(tabla.Rows[0]["Nombre"])} " +
                                  $"{Convert.ToString(tabla.Rows[0]["Apellido_Paterno"])} " +
                                  $"{Convert.ToString(tabla.Rows[0]["Apellido_Materno"])}";
                    main.tipoUsuario = Convert.ToString(tabla.Rows[0]["Tipo_Usuario"]);
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
            if (txtUsuario.Text == string.Empty || txtClave.Text == string.Empty)
            {
                this.MensajeError($"Campo vacio. Revise la informacion");
            }
            else
            {
                this.Acceder();

            }
        }
    }
}
