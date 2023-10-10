using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;

namespace RegresionLineal
{
    public partial class RegresionLineal : Form
    {
        private List<Registro> registros = new List<Registro>();

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
            string cantidad = txtCantidad.Text;
            string costo = txtCostos.Text;

            dataGridView1.Rows.Add(cantidad, costo);
            registros.Add(new Registro { Cantidad = cantidad, Costo = costo });
        }

        private string Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                return "No puede dejar espacios en blanco en Cantidad";
            }
            else if (string.IsNullOrWhiteSpace(txtCostos.Text))
            {
                return "No puede dejar espacios en blanco en Costos";
            }

            return "";
        }

        private double SumatoriaX()
        {
            double sumatoriax = 0;

            foreach (var registro in registros)
            {
                if (double.TryParse(registro.Cantidad, out double valorX))
                {
                    sumatoriax += valorX;
                }
            }

            return sumatoriax;
        }

        private double SumatoriaY()
        {
            double sumatoriay = 0;

            foreach (var registro in registros)
            {
                if (double.TryParse(registro.Costo, out double valorY))
                {
                    sumatoriay += valorY;
                }
            }

            return sumatoriay;
        }

        private double SumatoriaXY()
        {
            double producto = 0;

            foreach (var registro in registros)
            {
                if (double.TryParse(registro.Cantidad, out double valorX) &&
                    double.TryParse(registro.Costo, out double valorY))
                {
                    producto += valorX * valorY;
                }
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

            foreach (var registro in registros)
            {
                if (double.TryParse(registro.Cantidad, out double valorX))
                {
                    valorx += Math.Pow(valorX, 2);
                }
            }

            return valorx;
        }

        private double ValorA()
        {
            return ((SumatoriaY() * SumatoriadeXCuadrada()) - (SumatoriaX() * SumatoriaXY()))
                / ((n * SumatoriadeXCuadrada()) - SumatoriaXAlCuadrado());
        }

        private double ValorB()
        {
            return ((n * SumatoriaXY()) - (SumatoriaX() * SumatoriaY()))
                / ((n * SumatoriadeXCuadrada()) - (SumatoriaXAlCuadrado()));
        }

        private double Resultado()
        {
            if (double.TryParse(txtQ.Text, out double Q))
            {
                return ValorA() + (ValorB() * Q);
            }
            return 0;
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
            if (string.IsNullOrWhiteSpace(txtQ.Text))
            {
                return "No puede dejar espacios en blanco en Q";
            }

            if (!double.TryParse(txtQ.Text, out _))
            {
                return "Q debe ser un número válido.";
            }

            return "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Regresión Lineal",
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

        private class Registro
        {
            public string Cantidad { get; set; }
            public string Costo { get; set; }
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
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                    }
                }
                objHoja.Cells[dataGridView1.Rows.Count + 3, 1] = "Valor de A:";
                objHoja.Cells[dataGridView1.Rows.Count + 3, 2] = txtA.Text;

                objHoja.Cells[dataGridView1.Rows.Count + 4, 1] = "Valor de B:";
                objHoja.Cells[dataGridView1.Rows.Count + 4, 2] = txtB.Text;

                objHoja.Cells[dataGridView1.Rows.Count + 5, 1] = "Valor de Y:";
                objHoja.Cells[dataGridView1.Rows.Count + 5, 2] = txtY.Text;

                objLibro.SaveAs2(filePath);
                objAplicacion.Quit();

                MessageBox.Show("Datos exportados exitosamente a Excel en: " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
