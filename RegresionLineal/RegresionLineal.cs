using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objExcel = Microsoft.Office.Interop.Excel;

namespace RegresionLineal
{
    public partial class RegresionLineal : Form
    {
        public RegresionLineal()
        {
            InitializeComponent();
            btnExportar.Enabled = false;
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
                btnExportar.Enabled = true;
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
        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Guardar archivo de Excel";
            saveFileDialog.FileName = "ExcelPrueba.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                objExcel.Application objAplicacion = new objExcel.Application();
                Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

                objAplicacion.Visible = false;
                for (int i = 1; i <= lvDetalle.Columns.Count; i++)
                {
                    objHoja.Cells[1, i].Value = lvDetalle.Columns[i - 1].Text;
                }
                for (int i = 0; i < lvDetalle.Items.Count; i++)
                {
                    for (int j = 0; j < lvDetalle.Columns.Count; j++)
                    {
                        objHoja.Cells[i + 2, j + 1].Value = lvDetalle.Items[i].SubItems[j].Text;
                    }
                }
                int rowIndex = lvDetalle.Items.Count + 3;
                objHoja.Cells[rowIndex, 1].Value = "Valor de A:";
                objHoja.Cells[rowIndex, 2].Value = txtA.Text;
                objHoja.Cells[rowIndex + 1, 1].Value = "Valor de B:";
                objHoja.Cells[rowIndex + 1, 2].Value = txtB.Text;
                objHoja.Cells[rowIndex + 2, 1].Value = "Valor de Y:";
                objHoja.Cells[rowIndex + 2, 2].Value = txtY.Text;
                objLibro.SaveAs2(filePath);
                objAplicacion.Quit();

                MessageBox.Show("Datos exportados exitosamente a Excel en: " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}