using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using objExcel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

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
        Stack cantidadSaldos = new Stack();
        Stack ValorSaldos = new Stack();
        List<double> LsCantidad = new List<double>();
        List<double> LsValorUnidad = new List<double>();
        List<double> lsTotal = new List<double>();
        Queue<double> QcantidadSaldos = new Queue<double>();
        Queue<double> QValorSaldos = new Queue<double>();




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

                    double total = double.Parse(txtValorUnit.Text) * double.Parse(txtCantidad.Text);

                    ValorSaldos.Push(double.Parse(txtValorUnit.Text));
                    cantidadSaldos.Push(double.Parse(txtCantidad.Text));

                    ListViewItem entrada = new ListViewItem(txtCantidad.Text);
                    entrada.SubItems.Add(txtValorUnit.Text);
                    entrada.SubItems.Add(total.ToString());
                    lvEntradas.Items.Add(entrada);


                    ListViewItem saldos = new ListViewItem(txtCantidad.Text);
                    saldos.SubItems.Add(txtValorUnit.Text);
                    saldos.SubItems.Add(total.ToString());
                    lvSaldos.Items.Add(saldos);

                    ListViewItem salida = new ListViewItem("-------");
                    salida.SubItems.Add("--------");
                    salida.SubItems.Add("--------");
                    lvSalidas.Items.Add(salida);

                    DateTime fecha = DateTime.Now;

                    ListViewItem time = new ListViewItem(fecha.ToString());
                    lvFecha.Items.Add(time);


                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {



                    Stack CopiaCantidad = new Stack();
                    Stack CopiaValor = new Stack();

                    CopiaCantidad = (Stack)cantidadSaldos.Clone();
                    CopiaValor = (Stack)ValorSaldos.Clone();



                    string converCantidad1 = CopiaCantidad.Pop().ToString();
                    double conver11 = double.Parse(converCantidad1);

                    string converCantidad2 = CopiaCantidad.Pop().ToString();
                    double conver2 = double.Parse(converCantidad2);

                    string converValor1 = CopiaValor.Pop().ToString();
                    double conver22 = double.Parse(converValor1);

                    string ConverValor2 = CopiaValor.Pop().ToString();
                    double convervalor2 = double.Parse(ConverValor2);


                    if (double.Parse(txtCantidad.Text) <= conver11)
                    {

                        double op1 = conver11 - double.Parse(txtCantidad.Text);
                        double op3 = double.Parse(txtCantidad.Text) * conver22;

                        ListViewItem salida = new ListViewItem(txtCantidad.Text);
                        salida.SubItems.Add(conver22.ToString());
                        salida.SubItems.Add(op3.ToString());
                        lvSalidas.Items.Add(salida);

                        double totalSaldo1 = conver22 * op1;

                        ListViewItem saldos = new ListViewItem(op1.ToString());
                        saldos.SubItems.Add(conver22.ToString());
                        saldos.SubItems.Add(totalSaldo1.ToString());
                        lvSaldos.Items.Add(saldos);

                        ListViewItem entrada = new ListViewItem("-------");
                        entrada.SubItems.Add("-------");
                        entrada.SubItems.Add("-------");
                        lvEntradas.Items.Add(entrada);

                        DateTime fecha = DateTime.Now;

                        ListViewItem time = new ListViewItem(fecha.ToString());
                        lvFecha.Items.Add(time);


                    }


                    if (double.Parse(txtCantidad.Text) > conver11)
                    {


                        double SumaDosUlltimos = conver11 + conver2;



                        if (double.Parse(txtCantidad.Text) < SumaDosUlltimos)
                        {

                            double Total1 = conver11 * conver22;

                            ListViewItem salida = new ListViewItem(conver11.ToString());
                            salida.SubItems.Add(conver22.ToString());
                            salida.SubItems.Add(Total1.ToString());
                            lvSalidas.Items.Add(salida);

                            double aux1 = double.Parse(txtCantidad.Text) - conver11;
                            double aux2 = aux1 * convervalor2;

                            ListViewItem salida2 = new ListViewItem(aux1.ToString());
                            salida2.SubItems.Add(convervalor2.ToString());
                            salida2.SubItems.Add(aux2.ToString());
                            lvSalidas.Items.Add(salida2);

                            ListViewItem saldos = new ListViewItem("-------");
                            saldos.SubItems.Add("-------");
                            saldos.SubItems.Add("-------");
                            lvSaldos.Items.Add(saldos);

                            double cantidad2 = SumaDosUlltimos - double.Parse(txtCantidad.Text);

                            double aux3 = convervalor2 * cantidad2;

                            ListViewItem saldos2 = new ListViewItem(cantidad2.ToString());
                            saldos2.SubItems.Add(convervalor2.ToString());
                            saldos2.SubItems.Add(aux3.ToString());
                            lvSaldos.Items.Add(saldos2);

                            ListViewItem entrada = new ListViewItem("-------");
                            entrada.SubItems.Add("-------");
                            entrada.SubItems.Add("-------");
                            lvEntradas.Items.Add(entrada);


                            ListViewItem entrada2 = new ListViewItem("-------");
                            entrada2.SubItems.Add("-------");
                            entrada2.SubItems.Add("-------");
                            lvEntradas.Items.Add(entrada2);

                            DateTime fecha = DateTime.Now;

                            ListViewItem time = new ListViewItem(fecha.ToString());
                            lvFecha.Items.Add(time);



                            ListViewItem time2 = new ListViewItem("-------");
                            lvFecha.Items.Add(time2);

                        }



                    }


                }






            }
            else if (cboInventario.SelectedItem == "PEPS")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {

                    txtValorUnit.Enabled = true;
                    double total = double.Parse(txtValorUnit.Text) * double.Parse(txtCantidad.Text);

                    QValorSaldos.Enqueue(double.Parse(txtValorUnit.Text));
                    QcantidadSaldos.Enqueue(double.Parse(txtCantidad.Text));

                    ListViewItem entrada = new ListViewItem(txtCantidad.Text);
                    entrada.SubItems.Add(txtValorUnit.Text);
                    entrada.SubItems.Add(total.ToString());
                    lvEntradas.Items.Add(entrada);

                    ListViewItem saldos = new ListViewItem(txtCantidad.Text);
                    saldos.SubItems.Add(txtValorUnit.Text);
                    saldos.SubItems.Add(total.ToString());
                    lvSaldos.Items.Add(saldos);

                    ListViewItem salida = new ListViewItem("-------");
                    salida.SubItems.Add("--------");
                    salida.SubItems.Add("--------");
                    lvSalidas.Items.Add(salida);

                    DateTime fecha = DateTime.Now;

                    ListViewItem time = new ListViewItem(fecha.ToString());
                    lvFecha.Items.Add(time);

                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {
                    txtValorUnit.Enabled = false;

                    Queue<double> copiaCantidad = new Queue<double>(QcantidadSaldos);
                    Queue<double> copiaValor = new Queue<double>(QValorSaldos);


                    string converValor1 = copiaValor.Dequeue().ToString();
                    double conver22 = double.Parse(converValor1);


                    string valor1 = QcantidadSaldos.Dequeue().ToString();
                    double valor11 = double.Parse(valor1);
                    if (double.Parse(txtCantidad.Text) <= valor11)
                    {
                        double aux1 = valor11 - double.Parse(txtCantidad.Text);
                        double aux2 = conver22 * aux1;

                        ListViewItem Saldos = new ListViewItem(aux1.ToString());
                        Saldos.SubItems.Add(conver22.ToString());
                        Saldos.SubItems.Add(aux2.ToString());
                        lvSaldos.Items.Add(Saldos);

                        double aux3 = double.Parse(txtCantidad.Text) * conver22;

                        ListViewItem salida = new ListViewItem(txtCantidad.Text);
                        salida.SubItems.Add(conver22.ToString());
                        salida.SubItems.Add(aux3.ToString());
                        lvSalidas.Items.Add(salida);

                        QcantidadSaldos.Clear();

                        QcantidadSaldos.Enqueue(aux1);

                        QValorSaldos.Clear();

                        QValorSaldos.Enqueue(conver22);



                        ListViewItem entrada = new ListViewItem("--------");
                        entrada.SubItems.Add("--------");
                        entrada.SubItems.Add("---------");
                        lvEntradas.Items.Add(entrada);

                        DateTime fecha = DateTime.Now;

                        ListViewItem time = new ListViewItem(fecha.ToString());
                        lvFecha.Items.Add(time);



                    }
                    else if (double.Parse(txtCantidad.Text) > valor11)
                    {



                        string converCantidad2 = QcantidadSaldos.Dequeue().ToString();
                        double conver2 = double.Parse(converCantidad2);

                        string converValor2 = copiaValor.Dequeue().ToString();
                        double convervalor2 = double.Parse(converValor2);




                        ListViewItem salida = new ListViewItem(valor11.ToString());
                        salida.SubItems.Add(conver22.ToString());
                        salida.SubItems.Add((valor11 * conver22).ToString());
                        lvSalidas.Items.Add(salida);

                        double aux1 = double.Parse(txtCantidad.Text) - valor11;

                        ListViewItem salida2 = new ListViewItem(aux1.ToString());
                        salida2.SubItems.Add(convervalor2.ToString());
                        salida2.SubItems.Add((aux1 * convervalor2).ToString());
                        lvSalidas.Items.Add(salida2);

                        ListViewItem saldo = new ListViewItem("-----------");
                        saldo.SubItems.Add("---------");
                        saldo.SubItems.Add("---------");
                        lvSaldos.Items.Add(saldo);

                        ListViewItem entrada = new ListViewItem("-----------");
                        entrada.SubItems.Add("---------");
                        entrada.SubItems.Add("---------");
                        lvEntradas.Items.Add(entrada);

                        ListViewItem entrada2 = new ListViewItem("-----------");
                        entrada2.SubItems.Add("---------");
                        entrada2.SubItems.Add("---------");
                        lvEntradas.Items.Add(entrada2);

                        double aux2 = conver2 - aux1;

                        ListViewItem saldo2 = new ListViewItem(aux2.ToString());
                        saldo2.SubItems.Add(convervalor2.ToString());
                        saldo2.SubItems.Add((aux2 * convervalor2).ToString());
                        lvSaldos.Items.Add(saldo2);

                        QcantidadSaldos.Clear();

                        QcantidadSaldos.Enqueue(aux2);

                        QValorSaldos.Clear();

                        QValorSaldos.Enqueue(convervalor2);

                    }

                }



            }
            else if (cboInventario.SelectedItem == "Promedio")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {
                    txtValorUnit.Enabled = true;

                    LsCantidad.Add(double.Parse(txtCantidad.Text));
                    LsValorUnidad.Add(double.Parse(txtValorUnit.Text));
                    ListViewItem Cantidad = new ListViewItem(txtCantidad.Text);
                    Cantidad.SubItems.Add(txtValorUnit.Text);

                    double result;

                    result = double.Parse(txtCantidad.Text) * double.Parse(txtValorUnit.Text);
                    lsTotal.Add(result);

                    Cantidad.SubItems.Add(result.ToString());

                    lvEntradas.Items.Add(Cantidad);
                    DateTime fecha = DateTime.Now;

                    ListViewItem time = new ListViewItem(fecha.ToString());
                    lvFecha.Items.Add(time);

                    ListViewItem entrada = new ListViewItem("--------");
                    entrada.SubItems.Add("--------");
                    entrada.SubItems.Add("--------");
                    lvSalidas.Items.Add(entrada);

                    double result1 = 0;
                    double result2 = 0;
                    result1 = LsCantidad.Sum();
                    result2 = lsTotal.Sum();

                    double Result3 = 0;
                    Result3 = result2 / result1;



                    if (cantidadSaldos.Count == 1)
                    {

                        ListViewItem Saldo = new ListViewItem(txtCantidad.Text);
                        Saldo.SubItems.Add(txtValorUnit.Text);
                        Saldo.SubItems.Add(result.ToString());
                        lvSaldos.Items.Add(Saldo);
                    }
                    else
                    {
                        ListViewItem saldo2 = new ListViewItem(result1.ToString());
                        saldo2.SubItems.Add(Result3.ToString("0.00"));
                        saldo2.SubItems.Add(result2.ToString("0.00"));
                        lvSaldos.Items.Add(saldo2);


                    }




                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {
                    txtValorUnit.Enabled = false;

                    ListViewItem Salida = new ListViewItem(txtCantidad.Text);
                    double SumaCant = 0;
                    double SumaTotal = 0;
                    SumaCant = LsCantidad.Sum();
                    SumaTotal = lsTotal.Sum();

                    double ValorUnit = 0;

                    ValorUnit = SumaTotal / SumaCant;

                    double Total = 0;
                    Total = ValorUnit * double.Parse(txtCantidad.Text);


                    Salida.SubItems.Add(ValorUnit.ToString("0.00"));
                    Salida.SubItems.Add(Total.ToString("0.00"));
                    lvSalidas.Items.Add(Salida);


                    double CantidadSaldo = SumaCant - double.Parse(txtCantidad.Text);
                    ListViewItem Saldo3 = new ListViewItem(CantidadSaldo.ToString());
                    Saldo3.SubItems.Add(ValorUnit.ToString("0.00"));

                    double TSaldo = CantidadSaldo * ValorUnit;
                    Saldo3.SubItems.Add(TSaldo.ToString("0.00"));
                    lvSaldos.Items.Add(Saldo3);

                    ListViewItem Entrada = new ListViewItem("--------------");
                    Entrada.SubItems.Add("-----------");
                    Entrada.SubItems.Add("-----------");
                    lvEntradas.Items.Add(Entrada);

                    LsCantidad.Clear();
                    LsCantidad.Add(CantidadSaldo);

                    lsTotal.Clear();
                    lsTotal.Add(TSaldo);



                }



                // ....................................................................






            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quieres salir del programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 8;

            if (txtCantidad.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtValorUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboMovimiento.SelectedItem == "Salida")
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                int maxLength = 0;

                if (txtValorUnit.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }

            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                int maxLength = 6;

                if (txtValorUnit.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
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
                Microsoft.Office.Interop.Excel.Application objAplicacion = new Microsoft.Office.Interop.Excel.Application();
                Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);

                string seleccion = cboInventario.SelectedItem.ToString();
                Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;
                objHoja.Name = seleccion;

                objAplicacion.Visible = false;

                AgregarEncabezados(objHoja, seleccion);
                ExportarListViewAExcel(lvFecha, lvEntradas, lvSalidas, lvSaldos, objHoja, 4, 1);
                objLibro.SaveAs2(filePath);
                objAplicacion.Quit();

                MessageBox.Show("Datos exportados exitosamente a Excel en: " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportarListViewAExcel(System.Windows.Forms.ListView fechaListView, System.Windows.Forms.ListView entradasListView, System.Windows.Forms.ListView salidasListView, System.Windows.Forms.ListView saldosListView, Worksheet objHoja, int inicioRow, int inicioColumn)
        {
            objHoja.Cells[inicioRow, inicioColumn].Value = "Fechas";
            objHoja.Cells[inicioRow, inicioColumn + 3].Value = "Entradas";
            objHoja.Cells[inicioRow, inicioColumn + 6].Value = "Salidas";
            objHoja.Cells[inicioRow, inicioColumn + 9].Value = "Saldos";
            int rowActual = inicioRow + 1;

            for (int i = 0; i < fechaListView.Items.Count; i++)
            {
                objHoja.Cells[rowActual, inicioColumn].Value = fechaListView.Items[i].Text;

                for (int col = 0; col < 3; col++)
                {
                    objHoja.Cells[rowActual, inicioColumn + 2 + col].Value = entradasListView.Items[i].SubItems[col].Text;
                    objHoja.Cells[rowActual, inicioColumn + 5 + col].Value = salidasListView.Items[i].SubItems[col].Text;
                    objHoja.Cells[rowActual, inicioColumn + 8 + col].Value = saldosListView.Items[i].SubItems[col].Text;
                }

                rowActual++;
            }
        }
            private void AgregarEncabezados(Worksheet objHoja, string metodo)
            {
                objHoja.Cells[1, 1].Value = "Método: " + metodo;
             }
    }
}