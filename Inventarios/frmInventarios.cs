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
        Queue<double> cantidadSaldos = new Queue<double>();
        Queue<double> ValorSaldos = new Queue<double>();
        List<double> LsCantidad = new List<double>();
        List<double> LsValorUnidad = new List<double>();

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
                    double total = double.Parse(txtValorUnit.Text) * double.Parse(txtCantidad.Text);

                    ValorSaldos.Enqueue(double.Parse(txtValorUnit.Text));
                    cantidadSaldos.Enqueue(double.Parse(txtCantidad.Text));

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

                    if (cantidadSaldos.Count > 0)
                    {
                        if (cantidadSaldos.Count > 0)
                        {
                            Queue<double> copiaCantidad = new Queue<double>(cantidadSaldos);
                            Queue<double> copiaValor = new Queue<double>(ValorSaldos);

                            string converCantidad1 = copiaCantidad.Dequeue().ToString();
                            double conver11 = double.Parse(converCantidad1);

                            string converCantidad2 = copiaCantidad.Dequeue().ToString();
                            double conver2 = double.Parse(converCantidad2);

                            string converValor1 = copiaValor.Dequeue().ToString();
                            double conver22 = double.Parse(converValor1);

                            string converValor2 = copiaValor.Dequeue().ToString();
                            double convervalor2 = double.Parse(converValor2);

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
                                double SumaDosUltimos = conver11 + conver2;

                                if (double.Parse(txtCantidad.Text) < SumaDosUltimos)
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

                                    double cantidad2 = SumaDosUltimos - double.Parse(txtCantidad.Text);
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
                        else
                        {
                            MessageBox.Show("No hay suficiente saldo para la salida.");
                        }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quieres salir del programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            { 
                this.Close();
            }
        }
    }
}
