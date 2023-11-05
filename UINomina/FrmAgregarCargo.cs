using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UINomina
{
    public partial class FrmAgregarCargo : Form
    {
        public FrmAgregarCargo()
        {
            InitializeComponent();
        }

        private void txtCargo_Enter(object sender, EventArgs e)
        {
            if (txtCargo.Text == "Nombre de cargo")
                txtCargo.Text = "";
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
                txtCargo.Text = "Nombre de caro";
        }
    }
}
