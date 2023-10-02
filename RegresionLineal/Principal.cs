using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegresionLineal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnPuntoAlto_Click(object sender, EventArgs e)
        {

            PuntoAltoPuntoBajo p = new();
            p.ShowDialog();

        }

        private void btnRegresion_Click(object sender, EventArgs e)
        {
            RegresionLineal r = new RegresionLineal();
            r.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Opciones",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
