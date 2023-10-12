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
        Queue<double> QcantidadSaldos = new Queue<double>();
        Queue<double> QValorSaldos = new Queue<double>();
        List<double> LsCantidad = new List<double>();
        List<double> LsValorUnidad = new List<double>();
        Stack cantidadSaldos = new Stack();
        Stack ValorSaldos = new Stack();

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
                    else if(double.Parse(txtCantidad.Text)> valor11)
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
                        saldo2.SubItems.Add((aux2*convervalor2).ToString());
                        lvSaldos.Items.Add(saldo2);

                        QcantidadSaldos.Clear();

                        QcantidadSaldos.Enqueue(aux2);

                        QValorSaldos.Clear();

                        QValorSaldos.Enqueue(convervalor2);

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
