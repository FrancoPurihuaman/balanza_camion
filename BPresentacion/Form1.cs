using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BModelo;
using System.IO.Ports;

namespace BPresentacion
{
    public partial class FrmPrincipal : Form
    {

        // Variables para obtener datos de la balanza

        private delegate void DelegateAccess(String oString);

        private String bufferIn;
        private SerialPort serialPort1;

        // Fin - Variables para obtener datos de la balanza

        public FrmPrincipal()
        {
            InitializeComponent();
            //cargarDatos();
            //controlesPesar();

            buscarPuertos();
            conectarPuertos();
        }

        private void controlesPesar()
        {
            btnNuevo.Enabled = false;
            btnUsuarios.Enabled = false;
            btnReporte.Enabled = false;
            txtPesoSalida.Enabled = false;

        }
        private void controlesPesar2()
        {
            txtPesoEntrada.Enabled = false;
            txtPesoSalida.Enabled = true;
        }

        private void btnPesar_Click(object sender, EventArgs e)
        {
            int precio, producto,psoEnt,ticket;
            String codCliente, placa, observacion;

            ticket = Convert.ToInt32(lblTicket.Text);
            placa = txtPlaca.Text;
            codCliente = txtCodCliente.Text;
            producto = cbxProductos.SelectedIndex;
            precio = cbxPrecios.SelectedIndex;
            observacion = txtObservacion.Text;
            
            
            try
            {
                psoEnt = Convert.ToInt32(txtPesoEntrada.Text);
                //Console.WriteLine(psoEnt);
                //MessageBox.Show("Pesaje: " + Convert.ToString(psoEnt));
            }
            catch (Exception Ex)
            {
                MessageBox.Show("El peso debe ser numero entero.");
            }



            // CREACION DEL TICKET IMPORTANTE
            Ticket.CreaTicket Ticket1 = new Ticket.CreaTicket();

            Ticket1.TextoCentro("BALANZA ELECTRONICA"); //imprime una linea de descripcion
            Ticket1.TextoCentro("MINERA MORRUP S.A.C.");
            Ticket1.TextoCentro("SERVICIO LAS 24 HORAS");
            Ticket1.TextoDerecha("TICKET: " + lblTicket.Text);
            Ticket1.TextoCentro("**********************************");

           
            Ticket1.TextoCentro("PESO ENTRADA"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("FECHA/HORA: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("PLACA: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("PESO: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("IMPORTE: ");
            Ticket1.TextoIzquierda("");

            Ticket.CreaTicket.LineasGuion();//-------------------------

            Ticket1.TextoCentro("PESO SALIDA"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("FECHA/HORA: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("PLACA: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("");

            Ticket.CreaTicket.LineasGuion();//-------------------------

            Ticket1.TextoIzquierda("PESO BRUTO: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + " Kg");
            Ticket1.TextoIzquierda("PESO TARA: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + " Kg");
            Ticket1.TextoIzquierda("PESO NETO: " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + " Kg");
            

            Ticket.CreaTicket.EncabezadoVenta();
            Ticket.CreaTicket.LineasGuion();


            //Detalle de la factura
            //foreach (DataGridViewRow r in dataGridView1.Rows)
            //{
            //    // Articulo                     //Precio                                    cantidad                            Subtotal
            //    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            //}


            //ClassFunciones.clsFunciones.CreaTicket.LineasGuion();
            //Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
            //Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
            //Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
            //Ticket1.TextoIzquierda(" ");
            //Ticket1.AgregaTotales("Total", double.Parse(lblCostoApagar.Text)); // imprime linea con total
            //Ticket1.TextoIzquierda(" ");
            //Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(textBox3.Text));
            //Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");

            //Ticket1.ImprimirTiket(cmbInstalledPrinters.Text); //Elegir la Impresora e Imprimir
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.inicializarRecursos(); // -------------- Control de puertos 
            //lblHoraExacta.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "  Hora: " + DateTime.Now.ToShortTimeString();
        }
        private void cargarDatos()
        {
            lblHoraExacta.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "  Hora: " + DateTime.Now.ToShortTimeString();
            Precio oPrecio = new Precio();

            // Ejemplo para insertar datos
            Dictionary<String, Object> oDictionary1 = new Dictionary<String, Object>();
            oDictionary1.Add("MONTO", 6);
            oDictionary1.Add("DESCRIPCION", "Ejemplo Descripción");
            int resolucion2 = oPrecio.insert(oDictionary1).run();
            MessageBox.Show(resolucion2.ToString());
            // Fin Ejemplo para insertar datos


            // Ejemplo para obtener datos
            String[] colum = { "DESCRIPCION" };
            DataTable oDataTable = oPrecio.select(colum).get();

            if (oDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros");
            }
            else
            {
                foreach (DataRow row in oDataTable.Rows)
                {
                    foreach (DataColumn column in oDataTable.Columns)
                    {
                        row[column] = row[column].ToString().Replace('"', ' ').Trim();
                        MessageBox.Show(row[column].ToString());
                    }
                }
            }
            // Fin Ejemplo para haceer peticiones

            // Ejemplo para Actualizar datos
            Dictionary<String, Object> oDictionary = new Dictionary<String, Object>();
            oDictionary.Add("MONTO", 7);
            oDictionary.Add("DESCRIPCION", "Descripción Actualizada");
            int resolucion = oPrecio.update(oDictionary).where("ID_PREC", "=", 6).run();
            MessageBox.Show(resolucion.ToString());
            // Fin Ejemplo para Actualizar datos


            // Ejemplo para borrar registros
            int resolucion1 = oPrecio.delete().where("ID_PREC", "=", 2).run();
            MessageBox.Show(resolucion1.ToString());
            // Fin Ejemplo para borrar registros

        }



        private void btnTicket_Click(object sender, EventArgs e)
        {
            frmTickets vtaTicket = new frmTickets();
            vtaTicket.Show();
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            frmTicketPendiente vtaPendiente = new frmTicketPendiente();
            vtaPendiente.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            desconectarPuertos(); // --------------- Control de puertos
            Application.Exit();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reports vtaReporte = new Reports();
            vtaReporte.Show();
        }

        // Funciones para leer datos de la balanza --------------------------------------------------------

        private void inicializarRecursos()
        {
            this.bufferIn = "";
        }

        private void buscarPuertos()
        {
            String[] puertosDisponibles = SerialPort.GetPortNames();
            
            if (puertosDisponibles.Length == 0)
            {
                MessageBox.Show("No hay puertos conectados");
            }
        }


        private void conectarPuertos()
        {
            try
            {
                this.serialPort1 = new SerialPort();
                this.serialPort1.BaudRate = 9600;
                this.serialPort1.DataBits = 7;
                this.serialPort1.Parity = Parity.Even;
                this.serialPort1.StopBits = StopBits.One;
                this.serialPort1.PortName = "COM1";
                this.serialPort1.Handshake = Handshake.None;
                this.serialPort1.DataReceived += new SerialDataReceivedEventHandler(getDataBascula);


                this.serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void desconectarPuertos()
        {
            try
            {
                if (this.serialPort1.IsOpen)
                {
                    this.serialPort1.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getDataBascula(
                object sender,
                SerialDataReceivedEventArgs e)
        {
            SerialPort oSerialPort = (SerialPort)sender;
            this.handlerAddPesoForm(oSerialPort.ReadExisting());
        }

        private void addPesoForm(String peso)
        {
            this.bufferIn = peso;
            this.txtPesoEntrada.Text = this.bufferIn;
        }

        private void handlerAddPesoForm(String peso)
        {
            DelegateAccess oDelegateAccess = new DelegateAccess(addPesoForm);
            object[] args = { peso };
            base.Invoke(oDelegateAccess, args);
        }

        // Fin - Funciones para leer datos de la balanza --------------------------------------------------
    }
}
