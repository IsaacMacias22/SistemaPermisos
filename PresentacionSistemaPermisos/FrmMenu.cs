﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionSistemaPermisos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            optPermisos.Visible = false;
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios formUsuarios = new FrmUsuarios();
            formUsuarios.ShowDialog();
            formUsuarios.MdiParent = this;
        }

        private void optPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos frmPermisos = new FrmPermisos();
            frmPermisos.ShowDialog();
            frmPermisos.MdiParent = this;
        }
    }
}
