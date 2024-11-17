using pv.Backend;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            this.x = x;
            InitializeComponent();
            InicializarTimer();
            lblcajero.Text = "Cajero: " + nombre_empleado;
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
            if (!Regex.Match(tbcod.Text, @"^\d{13}$").Success)
            {
                MessageBox.Show("El código debe contener solo dígitos y exactamente 13.");
            }
            else
            {
                try
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        

        private void dtventa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dtventa.Columns["Cantidad"].Index)
                {
                    var cantidad = Convert.ToInt32(dtventa.Rows[e.RowIndex].Cells["Cantidad"].Value);
                    var precio = Convert.ToDouble(dtventa.Rows[e.RowIndex].Cells["PrecioU"].Value);
                    var iva = Convert.ToDouble(dtventa.Rows[e.RowIndex].Cells["IVA"].Value);

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

        private void dtventa_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Console.WriteLine("Inicio de edición en celda.");
        }

        int selectedRowIndex = 0;
        private (int, string) x;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            met_pago = cbpago.SelectedItem.ToString();
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

        private void tbpaga_Enter(object sender, EventArgs e)
        {
            tbpaga.Text = "";
        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }

        private void dtventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;

                dtventa.Rows[e.RowIndex].Selected = true;

                btndelete.Enabled = true;
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
            if (cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() == "Efectivo")
            {
                double paga = 0.0;
                double.TryParse(tbpaga.Text, out paga);
                btnventa.Enabled = paga >= total && dtventa.Rows.Count > 0;
            }
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            try
            {
                id_empleado = 1;
                // int id_empleado, string descripcion, string met_pago, double importe, double subtotal, double iva, double total
                Venta v = new Venta(id_empleado, met_pago, importe, subtotal, total);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar la venta: " + ex.Message);
            }
        }

        private void ActualizarEstadoBotonVenta()
        {
            if((dtventa.Rows.Count > 0 && cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() != "Efectivo") || (dtventa.Rows.Count > 0 && cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() == "Efectivo"  && tbpaga.Text != ""))
            {
                btnventa.Enabled = true;
            }
            else
            {
                btnventa.Enabled = false;
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
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

            ActualizarEstadoBotonVenta(); // Verifica el estado del botón al cargar
        }

        private void dtventa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            cbpago.Visible = dtventa.Rows.Count > 0;
            ActualizarTotales();
            ActualizarEstadoBotonVenta(); // Llama para verificar el estado del botón al agregar filas
        }

        private void dtventa_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            cbpago.Visible = dtventa.Rows.Count > 0;
            cbpago.SelectedItem = (dtventa.Rows.Count > 0) ? cbpago.SelectedItem : null;

            tbpaga.Visible = dtventa.Rows.Count > 0;
            ActualizarTotales();
            ActualizarEstadoBotonVenta(); // Llama para verificar el estado del botón al quitar filas
        }

        private void cbpago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonVenta(); // Llama para verificar el estado del botón al cambiar la selección del ComboBox

            if (cbpago.SelectedItem != null && cbpago.SelectedItem.ToString() == "Efectivo")
            {
                btnventa.Visible = false;

                tbpaga.Visible = true;
                tbpaga.Text = "Ingrese la cantidad";
            }
            else
            {
                btnventa.Visible = true;
                ActualizarEstadoBotonVenta();
            }
        }

        private void tbpaga_TextChanged_1(object sender, EventArgs e)
        {
            tbpaga.Visible = true;
            tbpaga.Text = "Ingrese la cantidad";
            ActualizarEstadoBotonVenta();
        }

        private void dtventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblcajero_Click(object sender, EventArgs e)
        {

        }
    }
}
