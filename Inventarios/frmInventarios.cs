using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventarios
{
    public partial class frmInventarios : Form
    {
        public frmInventarios()
        {
            InitializeComponent();
        }

        string[] tipoInv = { "UEPS", "PEPS", "Promedio" };
        string[] Movimiento = { "Entrada", "Salida" };

        private void frmInventarios_Load(object sender, EventArgs e)
        {

            cboInventario.DataSource = tipoInv;
            cboMovimiento.DataSource = Movimiento;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cboInventario.SelectedItem == "UEPS")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {

                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {

                }



            }
            else if (cboInventario.SelectedItem == "PEPS")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {

                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {

                }



            }
            else if (cboInventario.SelectedItem == "Promedio")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {

                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {

                }



            }

        }
    }
}
