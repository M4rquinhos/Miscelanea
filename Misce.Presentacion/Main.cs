﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misce.Presentacion
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        //Variables barra de estado
        public string nombre;
        public string tipoUsuario;
    
        private void Main_Load(object sender, EventArgs e)
        {
            tstrpUsuario.Text = nombre;
            sstripTipoUsuario.Text = tipoUsuario;

        }

        private void toolStripEmpleados_Click(object sender, EventArgs e)
        {
            Frm_Empleados frmEmpleados = new Frm_Empleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
