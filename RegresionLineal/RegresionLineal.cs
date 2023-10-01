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
    public partial class RegresionLineal : Form
    {
        public RegresionLineal()
        {
            InitializeComponent();
        }

        int n = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (Validar() == "")
            {

                Agregar();

                Limpiar();
                n++;

            }
            else
            {
                MessageBox.Show(Validar(), "Advertencia", MessageBoxButtons.OK);
            }


        }

        private void Limpiar()
        {
            txtCostos.Clear();
            txtCantidad.Clear();

        }

        private void Agregar()
        {
            ListViewItem fila = new ListViewItem(txtCantidad.Text);
            fila.SubItems.Add(txtCostos.Text);
            lvDetalle.Items.Add(fila);
        }

        private string Validar()
        {
            if (txtCantidad.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if (txtCostos.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }


            return "";
        }

        private double SumatoriaX()
        {
            double sumatoriax = 0;

            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {

                sumatoriax += double.Parse(lvDetalle.Items[i].SubItems[0].Text);

            }


            return sumatoriax;
        }

        private double SumatoriaY()
        {
            double sumatoriay = 0;

            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {

                sumatoriay += double.Parse(lvDetalle.Items[i].SubItems[1].Text);

            }


            return sumatoriay;
        }

        private double SumatoriaXY()
        {
            double valorx = 0;
            double valory = 0;
            double producto = 0;

            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {

                valorx = double.Parse(lvDetalle.Items[i].SubItems[0].Text);
                valory = double.Parse(lvDetalle.Items[i].SubItems[1].Text);


                producto += valorx * valory;

            }


            return producto;
        }

        private double SumatoriaXAlCuadrado()
        {
            double x = SumatoriaX();
            return Math.Pow(x, 2);
        }

        private double SumatoriadeXCuadrada()
        {
            double valorx = 0;

            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {

                valorx += Math.Pow(double.Parse(lvDetalle.Items[i].SubItems[0].Text), 2);


            }

            return valorx;
        }

        private double ValorA()
        {

            return ((SumatoriaY() * SumatoriadeXCuadrada()) - (SumatoriaX() * SumatoriaXY()))
                / ((n * SumatoriadeXCuadrada()) - SumatoriaXAlCuadrado());

        }


        public double ValorB()
        {
            return ((n * SumatoriaXY()) - (SumatoriaX() * SumatoriaY()))
                / ((n * SumatoriadeXCuadrada()) - (SumatoriaXAlCuadrado()));
        }

        private double Resultado()
        {
            double Q = double.Parse(txtQ.Text);

            return ValorA() + (ValorB() * Q);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidacionQ() == "")
            {
                txtA.Text = ValorA().ToString();
                txtB.Text = ValorB().ToString();
                txtY.Text = Resultado().ToString();
            }
            else
            {
                ValidacionQ();
            }


        }


        private string ValidacionQ()
        {
            if (txtQ.Text.Trim().Length == 0)
            {
                return MessageBox.Show("No puede dejar espacios en blanco", "Advertencia", MessageBoxButtons.OK).ToString();
            }

            return "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Regresion Lineal",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();


        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 9;

            if (txtCantidad.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCostos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 9;

            if (txtCostos.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 6;

            if (txtQ.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
