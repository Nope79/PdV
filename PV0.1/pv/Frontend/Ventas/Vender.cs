using pv.Backend;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using pv.Backend;

namespace pv.Frontend.Ventas
{
    public partial class Vender : Form
    {
        private int id;
        private int id_empleado;
        private string nombre_empleado;
        private string fecha;
        private string descripcion;
        private string met_pago;
        private double importe;
        private double subtotal = 0.00;
        private double iva;
        private double total = 0.00;
        private double impuestos = 0.0;

        private Timer timer;
        public Vender()
        {
            var xid = Application.UserAppDataRegistry.GetValue("ID");
            var xuser = Application.UserAppDataRegistry.GetValue("User");
            InitializeComponent();
            InicializarTimer();
            lblcajero.Text = $"Cajero: {xuser}";
            Console.WriteLine(x.Item1);
        }

        private void InicializarTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(ActualizarHoraLabel);
            timer.Start();
        }

        private void ActualizarHoraLabel(object sender, EventArgs e)
        {
            lblfecha.Text = "Fecha: ";
            lblfecha.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres regresar?\nUna vez hecho, no se guardarán los datos de esta venta.");
                if (confirmed)
                {
                    main m = new main();
                    m.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {
            btnadd.Enabled = !string.IsNullOrWhiteSpace(tbcod.Text);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.Match(tbcod.Text, @"^\d{13}$").Success)
                {
                    MessageBox.Show("El código debe contener solo dígitos y exactamente 13.");
                }
                else
                {
                    bool band = false;

                    foreach (DataGridViewRow row in dtventa.Rows)
                    {
                        if (row.Cells["cod"].Value != null)
                        {
                            if (row.Cells["cod"].Value.ToString() == tbcod.Text.Trim())
                            {
                                band = true;
                                break;
                            }
                        }
                    }

                    if (band)
                    {
                        MessageBox.Show("El producto ya ha sido añadido en la lista.");
                    }
                    else
                    {
                        Productos p = new Productos();
                        DataRow producto = p.select_productos(tbcod.Text);
                        if (producto != null)
                        {
                            dtventa.Rows.Add(producto["ID"], producto["Nombre"], producto["Precio"], producto["Cantidad"], producto["Subtotal"], producto["Iva"], producto["Impuesto"], producto["Cod"]);
                            MessageBox.Show("Producto añadido.");
                        }
                        else
                        {
                            MessageBox.Show("Ese producto no existe.");
                        }
                    }

                    tbcod.Text = "";

                    ActualizarTotales();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dtventa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dtventa.Columns["Cantidad"].Index)
                {
                    var cantidadText = e.FormattedValue.ToString();
                    int cantidad;
                    if (!int.TryParse(cantidadText, out cantidad) || cantidad <= 0)
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.");
                        e.Cancel = true; 
                        return; 
                    }

                    var precioText = dtventa.Rows[e.RowIndex].Cells["PrecioU"].Value?.ToString(); 
                    var ivaText = dtventa.Rows[e.RowIndex].Cells["IVA"].Value?.ToString();

                    double precio = 0, iva = 0;
                    bool precioValido = double.TryParse(precioText, out precio);
                    bool ivaValido = double.TryParse(ivaText, out iva);

                    if (!precioValido || precio <= 0)
                    {
                        MessageBox.Show("El precio unitario debe ser un número válido y mayor que cero.");
                        e.Cancel = true;
                        return;
                    }

                    if (!ivaValido || iva < 0)
                    {
                        MessageBox.Show("El IVA debe ser un número válido y mayor o igual a cero.");
                        e.Cancel = true;
                        return;
                    }

                    var subtotal = cantidad * precio;
                    var impuesto = subtotal * iva / 100;

                    dtventa.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;
                    dtventa.Rows[e.RowIndex].Cells["Impuesto"].Value = impuesto;
                }

                ActualizarTotales();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ActualizarTotales()
        {
            try
            {
                subtotal = 0.00;
                iva = 0.00;
                impuestos = 0.00;

                for (int i = 0; i < dtventa.Rows.Count; i++)
                {
                    var cantidad = Convert.ToInt32(dtventa.Rows[i].Cells["Cantidad"].Value);
                    var precio = Convert.ToDouble(dtventa.Rows[i].Cells["PrecioU"].Value);
                    var ivaProducto = Convert.ToDouble(dtventa.Rows[i].Cells["IVA"].Value);
                    var impuestosProducto = Convert.ToDouble(dtventa.Rows[i].Cells["Impuesto"].Value);
                    var subtotalProducto = cantidad * precio;

                    subtotal += subtotalProducto;
                    impuestos += impuestosProducto;
                }

                total = subtotal + impuestos;

                lblsubtotal.Text = "Subtotal: " + subtotal.ToString("F2");
                lblimpuestos.Text = "Impuestos: " + impuestos.ToString("F2");
                lbltotal.Text = "TOTAL: " + total.ToString("F2");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        int selectedRowIndex = 0;
        private (int, string) x;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbpago.SelectedItem == null || cbpago.SelectedItem.ToString() == "Efectivo")
                {
                    tbpaga.Visible = true;
                    lblpaga.Text = "Paga: 0.0";
                }
                else
                {
                    importe = total;
                    tbpaga.Visible = false;
                    tbpaga.Text = "Ingrese la cantidad";
                    lblpaga.Text = "Paga: " + total.ToString("F2");
                }

                ActualizarEstadoBotonVenta();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void tbpaga_Enter(object sender, EventArgs e)
        {
            tbpaga.Text = "";
        }

        private void dtventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedRowIndex = e.RowIndex;

                    dtventa.Rows[e.RowIndex].Selected = true;

                    btndelete.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRowIndex >= 0)
                {
                    dtventa.Rows.RemoveAt(selectedRowIndex);
                    selectedRowIndex = -1;
                    btndelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void tbpaga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() == "Efectivo")
                {
                    double paga = 0.0;
                    double.TryParse(tbpaga.Text, out paga);
                    btnventa.Enabled = paga >= total && dtventa.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            try
            {
                bool aux = true;
                if(cbpago.SelectedItem.ToString() == "Efectivo")
                {
                    if (!Regex.Match(tbpaga.Text, @"^\d+(\.\d{1,2})?$").Success)
                    {
                        MessageBox.Show("Debes ingresar un formato válido para el pago.");
                        aux = false;
                    }
                    else if (importe < total)
                    {
                        MessageBox.Show("El importe no puede ser menor al precio total de la venta.");
                        aux = false;
                    }
                }

                if (aux)
                {
                    met_pago = cbpago.SelectedItem.ToString();
                    Venta v = new Venta(met_pago, importe, subtotal, total);
                    bool x = v.GuardarVentaConDetalles(dtventa, v);

                    if (x)
                    {
                        this.Hide();
                        main m = new main();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar la venta. Inténtelo más tarde.");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void ActualizarEstadoBotonVenta()
        {
            try
            {
                if ((dtventa.Rows.Count > 0 && cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() != "Efectivo") || (dtventa.Rows.Count > 0 && cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() == "Efectivo" && tbpaga.Text != ""))
                {
                    btnventa.Enabled = true;
                }
                else
                {
                    btnventa.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                lbltotal.Text = "TOTAL: " + total.ToString("F2");
                lblimpuestos.Text = "Impuestos: " + impuestos.ToString("F2");
                lblsubtotal.Text = "Subtotal: " + subtotal.ToString("F2");
                lblpaga.Text = "Paga: 0.00";

                dtventa.Columns.Add("ID", "ID");
                dtventa.Columns.Add("Producto", "Producto");
                dtventa.Columns.Add("PrecioU", "Precio");
                dtventa.Columns.Add("Cantidad", "Cantidad");
                dtventa.Columns.Add("Subtotal", "Subtotal");
                dtventa.Columns.Add("IVA", "IVA");
                dtventa.Columns.Add("Impuesto", "Impuesto");
                dtventa.Columns.Add("Cod", "Código");

                foreach (DataGridViewColumn col in dtventa.Columns)
                {
                    col.ReadOnly = true;
                }
                dtventa.Columns["Cantidad"].ReadOnly = false;

                ActualizarEstadoBotonVenta();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dtventa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cbpago.Visible = dtventa.Rows.Count > 0;
            ActualizarTotales();
            ActualizarEstadoBotonVenta();
        }

        private void dtventa_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cbpago.Visible = dtventa.Rows.Count > 0;
            cbpago.SelectedItem = (dtventa.Rows.Count > 0) ? cbpago.SelectedItem : null;
            tbpaga.Visible = dtventa.Rows.Count > 0;
            ActualizarTotales();
            ActualizarEstadoBotonVenta();
        }

        private void cbpago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() == "Efectivo")
            {
                tbpaga.Visible = true;
                tbpaga.Text = "Ingrese la cantidad";
            }
            ActualizarEstadoBotonVenta();
        }

        private void tbpaga_MouseEnter(object sender, EventArgs e)
        {
            tbpaga.Text = "";
        }

        private void tbpaga_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                importe = Convert.ToDouble(tbpaga.Text);
            }
            catch (Exception ex)
            {
                importe = 0;
            }
            finally
            {
                lblpaga.Text = "Paga: " + importe.ToString("F2");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
