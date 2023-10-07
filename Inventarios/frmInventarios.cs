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
        List<double> cantidad = new List<double>();
        List<double> valorUnit = new List<double>();
        List<double> ValorTotal = new List<double>();

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
            else if (cboInventario.SelectedItem=="PEPS")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {
                    cantidad.Add(double.Parse(txtCantidad.Text));
                    valorUnit.Add(double.Parse(txtValorUnit.Text));

                    double aux1 = cantidad.First();
                    double aux2 = valorUnit.First();
                    double valorTotal = aux1 * aux2;

                    ValorTotal.Add(valorTotal);

                    ListViewItem fila = new ListViewItem(txtCantidad.Text);
                    fila.SubItems.Add(txtValorUnit.Text);
                    fila.SubItems.Add(valorTotal.ToString());

                    lvEntradas.Items.Add(fila);

                    ListViewItem fila2 = new ListViewItem(txtCantidad.Text);
                    fila2.SubItems.Add(txtValorUnit.Text);
                    fila2.SubItems.Add(valorTotal.ToString());

                    lvSaldos.Items.Add(fila2);

                    ListViewItem fila3 = new ListViewItem("-------");
                    fila3.SubItems.Add("-------");
                    fila3.SubItems.Add("-------");
                    lvSalidas.Items.Add(fila3);




                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {
                    double aux1 = valorUnit.First();
                    double aux2 = double.Parse(txtCantidad.Text) * aux1;

                    ListViewItem fila = new ListViewItem(txtCantidad.Text);
                    fila.SubItems.Add(aux1.ToString());
                    fila.SubItems.Add(aux2.ToString());
                    lvSalidas.Items.Add(fila);

                    double aux3 = cantidad.First();
                    double aux4 = aux3 - double.Parse(txtCantidad.Text);
                    double aux5 = valorUnit.First();
                    double aux6 = aux4 * aux5;

                    ListViewItem fila2 = new ListViewItem(txtCantidad.Text);
                    fila2.SubItems.Add(aux5.ToString());
                    fila2.SubItems.Add(aux6.ToString());
                    lvSaldos.Items.Add(fila2);

                    ListViewItem fila3 = new ListViewItem("-------");
                    fila3.SubItems.Add("-------");
                    fila3.SubItems.Add("-------");
                    lvSalidas.Items.Add(fila3);

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
