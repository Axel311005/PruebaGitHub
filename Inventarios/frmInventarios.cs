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
        Stack cantidadSaldos = new Stack();
        Stack ValorSaldos = new Stack();
        List<double> LsCantidad = new List<double>();
        List<double> LsValorUnidad = new List<double>();
        List<double> lsTotal = new List<double>();




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


                }
                else if (cboMovimiento.SelectedItem == "Salida")
                {

                }



            }
            else if (cboInventario.SelectedItem == "Promedio")
            {

                if (cboMovimiento.SelectedItem == "Entrada")
                {
                    
                    LsCantidad.Add(double.Parse(txtCantidad.Text));
                    LsValorUnidad.Add(double.Parse(txtValorUnit.Text));
                    ListViewItem Cantidad = new ListViewItem(txtCantidad.Text);
                    Cantidad.SubItems.Add(txtValorUnit.Text);

                    double result;
                    
                    result= double.Parse(txtCantidad.Text) * double.Parse(txtValorUnit.Text);
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
                    double result2= 0;
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
    }
}
