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
    public partial class PuntoAltoPuntoBajo : Form
    {
        public PuntoAltoPuntoBajo()
        {
            InitializeComponent();
        }

        double costosmax = 0;
        double costosmin = 0;
        double horasMax = 0;
        double horasMin = 0;

        List<double> COSTOS = new List<double>();


        List<double> HORAS = new List<double>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (Validar() == "")
            {




                ListViewItem fila = new ListViewItem(txtCostos.Text);
                fila.SubItems.Add(txtHoras.Text);
                lvDetalle.Items.Add(fila);


                for (int i = 0; i < lvDetalle.Items.Count; i++)
                {
                    COSTOS.Add(double.Parse(lvDetalle.Items[i].SubItems[0].Text));

                }
                for (int i = 0; i < lvDetalle.Items.Count; i++)
                {
                    HORAS.Add(double.Parse(lvDetalle.Items[i].SubItems[1].Text));

                }



                HORAS.Reverse();
                COSTOS.Reverse();

                costosmax = COSTOS.First();
                costosmin = COSTOS.Last();
                horasMax = HORAS.First();
                horasMin = HORAS.Last();


                Limpiar();

            }
            else
            {
                MessageBox.Show(Validar(), "Advertencia", MessageBoxButtons.OK);
            }

        }

        private void Limpiar()
        {
            txtCostos.Clear();
            txtHoras.Clear();

        }



        private string Validar()
        {
            if (txtCostos.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if (txtHoras.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }

            return "";
        }

        private double CalculoB()
        {
            return (costosmax - costosmin) / (horasMax - horasMin);
        }



        private double CVT()
        {
            return CalculoB() * horasMax;
        }

        private double CFT()
        {
            return costosmax - CVT();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            txtCostosTotales.Text = costosmax.ToString();
            txtCostosFijos.Text = CFT().ToString();
            txtCostosVariables.Text = CVT().ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Punto Alto y Punto Alto",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
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

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 9;

            if (txtHoras.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        
    }
}
