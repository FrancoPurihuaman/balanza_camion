namespace BPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblTipoPesaje = new System.Windows.Forms.Label();
            this.gbxVehiculo = new System.Windows.Forms.GroupBox();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxPrecios = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxProductos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtPesoEntrada = new System.Windows.Forms.TextBox();
            this.txtPesoSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.userSalida = new System.Windows.Forms.Label();
            this.lblFecheS = new System.Windows.Forms.Label();
            this.userEntrada = new System.Windows.Forms.Label();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTaraS = new System.Windows.Forms.Label();
            this.lblTaraE = new System.Windows.Forms.Label();
            this.lblPesoS = new System.Windows.Forms.Label();
            this.lblPesoE = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chbxImpTicket = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoraExacta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxVehiculo.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoPesaje
            // 
            this.lblTipoPesaje.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTipoPesaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPesaje.ForeColor = System.Drawing.Color.Green;
            this.lblTipoPesaje.Location = new System.Drawing.Point(17, 96);
            this.lblTipoPesaje.Name = "lblTipoPesaje";
            this.lblTipoPesaje.Size = new System.Drawing.Size(375, 54);
            this.lblTipoPesaje.TabIndex = 0;
            this.lblTipoPesaje.Text = "PESAJE DE ENTRADA";
            this.lblTipoPesaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxVehiculo
            // 
            this.gbxVehiculo.Controls.Add(this.btnPendientes);
            this.gbxVehiculo.Controls.Add(this.txtPlaca);
            this.gbxVehiculo.Controls.Add(this.label2);
            this.gbxVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVehiculo.Location = new System.Drawing.Point(15, 166);
            this.gbxVehiculo.Name = "gbxVehiculo";
            this.gbxVehiculo.Size = new System.Drawing.Size(477, 136);
            this.gbxVehiculo.TabIndex = 1;
            this.gbxVehiculo.TabStop = false;
            this.gbxVehiculo.Text = "Vehiculo";
            // 
            // btnPendientes
            // 
            this.btnPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendientes.Image = ((System.Drawing.Image)(resources.GetObject("btnPendientes.Image")));
            this.btnPendientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendientes.Location = new System.Drawing.Point(124, 45);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(110, 28);
            this.btnPendientes.TabIndex = 4;
            this.btnPendientes.Text = "      Pendientes";
            this.btnPendientes.UseVisualStyleBackColor = true;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(14, 46);
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 27);
            this.txtPlaca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa";
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.label9);
            this.gbxCliente.Controls.Add(this.cbxPrecios);
            this.gbxCliente.Controls.Add(this.txtObservacion);
            this.gbxCliente.Controls.Add(this.label8);
            this.gbxCliente.Controls.Add(this.cbxProductos);
            this.gbxCliente.Controls.Add(this.label7);
            this.gbxCliente.Controls.Add(this.cbxClientes);
            this.gbxCliente.Controls.Add(this.txtCodCliente);
            this.gbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCliente.Location = new System.Drawing.Point(16, 308);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(477, 215);
            this.gbxCliente.TabIndex = 2;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio";
            // 
            // cbxPrecios
            // 
            this.cbxPrecios.FormattingEnabled = true;
            this.cbxPrecios.Location = new System.Drawing.Point(328, 87);
            this.cbxPrecios.Name = "cbxPrecios";
            this.cbxPrecios.Size = new System.Drawing.Size(121, 24);
            this.cbxPrecios.TabIndex = 6;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(16, 138);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(433, 53);
            this.txtObservacion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Observación";
            // 
            // cbxProductos
            // 
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(16, 87);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(218, 24);
            this.cbxProductos.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(126, 30);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(323, 24);
            this.cbxClientes.TabIndex = 1;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(16, 30);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(77, 22);
            this.txtCodCliente.TabIndex = 0;
            // 
            // txtPesoEntrada
            // 
            this.txtPesoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesoEntrada.BackColor = System.Drawing.Color.OliveDrab;
            this.txtPesoEntrada.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoEntrada.Location = new System.Drawing.Point(513, 107);
            this.txtPesoEntrada.Multiline = true;
            this.txtPesoEntrada.Name = "txtPesoEntrada";
            this.txtPesoEntrada.Size = new System.Drawing.Size(459, 101);
            this.txtPesoEntrada.TabIndex = 3;
            this.txtPesoEntrada.Text = "00";
            this.txtPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPesoSalida
            // 
            this.txtPesoSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesoSalida.BackColor = System.Drawing.Color.OliveDrab;
            this.txtPesoSalida.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoSalida.Location = new System.Drawing.Point(513, 244);
            this.txtPesoSalida.Multiline = true;
            this.txtPesoSalida.Name = "txtPesoSalida";
            this.txtPesoSalida.Size = new System.Drawing.Size(459, 101);
            this.txtPesoSalida.TabIndex = 4;
            this.txtPesoSalida.Text = "00";
            this.txtPesoSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso Entrada Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Peso Salida Kg";
            // 
            // btnPesar
            // 
            this.btnPesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesar.Image")));
            this.btnPesar.Location = new System.Drawing.Point(549, 533);
            this.btnPesar.Name = "btnPesar";
            this.btnPesar.Size = new System.Drawing.Size(92, 82);
            this.btnPesar.TabIndex = 7;
            this.btnPesar.Text = "PESAR";
            this.btnPesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesar.UseVisualStyleBackColor = true;
            this.btnPesar.Click += new System.EventHandler(this.btnPesar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ticket";
            // 
            // lblTicket
            // 
            this.lblTicket.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(408, 114);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(85, 34);
            this.lblTicket.TabIndex = 9;
            this.lblTicket.Text = "00001";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(650, 533);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 38);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "      Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(650, 577);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 38);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = " Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(760, 577);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(100, 38);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "    Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnTicket.Image")));
            this.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTicket.Location = new System.Drawing.Point(760, 533);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(100, 38);
            this.btnTicket.TabIndex = 12;
            this.btnTicket.Text = "   Tickets";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(869, 577);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 38);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(869, 533);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(100, 38);
            this.btnUsuarios.TabIndex = 14;
            this.btnUsuarios.Text = "    Usuario";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDetalle.Controls.Add(this.userSalida);
            this.gbxDetalle.Controls.Add(this.lblFecheS);
            this.gbxDetalle.Controls.Add(this.userEntrada);
            this.gbxDetalle.Controls.Add(this.lblFechaE);
            this.gbxDetalle.Controls.Add(this.label21);
            this.gbxDetalle.Controls.Add(this.label20);
            this.gbxDetalle.Controls.Add(this.lblTaraS);
            this.gbxDetalle.Controls.Add(this.lblTaraE);
            this.gbxDetalle.Controls.Add(this.lblPesoS);
            this.gbxDetalle.Controls.Add(this.lblPesoE);
            this.gbxDetalle.Controls.Add(this.label15);
            this.gbxDetalle.Controls.Add(this.label14);
            this.gbxDetalle.Controls.Add(this.label13);
            this.gbxDetalle.Controls.Add(this.label12);
            this.gbxDetalle.Controls.Add(this.label11);
            this.gbxDetalle.Controls.Add(this.label10);
            this.gbxDetalle.Controls.Add(this.label6);
            this.gbxDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalle.Location = new System.Drawing.Point(546, 414);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(423, 100);
            this.gbxDetalle.TabIndex = 16;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Complemento";
            // 
            // userSalida
            // 
            this.userSalida.AutoSize = true;
            this.userSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSalida.Location = new System.Drawing.Point(340, 66);
            this.userSalida.Name = "userSalida";
            this.userSalida.Size = new System.Drawing.Size(46, 16);
            this.userSalida.TabIndex = 16;
            this.userSalida.Text = "peso1";
            // 
            // lblFecheS
            // 
            this.lblFecheS.AutoSize = true;
            this.lblFecheS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecheS.Location = new System.Drawing.Point(248, 66);
            this.lblFecheS.Name = "lblFecheS";
            this.lblFecheS.Size = new System.Drawing.Size(46, 16);
            this.lblFecheS.TabIndex = 15;
            this.lblFecheS.Text = "peso1";
            // 
            // userEntrada
            // 
            this.userEntrada.AutoSize = true;
            this.userEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEntrada.Location = new System.Drawing.Point(340, 42);
            this.userEntrada.Name = "userEntrada";
            this.userEntrada.Size = new System.Drawing.Size(46, 16);
            this.userEntrada.TabIndex = 14;
            this.userEntrada.Text = "peso1";
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaE.Location = new System.Drawing.Point(248, 42);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(46, 16);
            this.lblFechaE.TabIndex = 13;
            this.lblFechaE.Text = "peso1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(186, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 16);
            this.label21.TabIndex = 12;
            this.label21.Text = "peso1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(187, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "peso1";
            // 
            // lblTaraS
            // 
            this.lblTaraS.AutoSize = true;
            this.lblTaraS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaraS.Location = new System.Drawing.Point(136, 66);
            this.lblTaraS.Name = "lblTaraS";
            this.lblTaraS.Size = new System.Drawing.Size(46, 16);
            this.lblTaraS.TabIndex = 10;
            this.lblTaraS.Text = "peso1";
            // 
            // lblTaraE
            // 
            this.lblTaraE.AutoSize = true;
            this.lblTaraE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaraE.Location = new System.Drawing.Point(136, 42);
            this.lblTaraE.Name = "lblTaraE";
            this.lblTaraE.Size = new System.Drawing.Size(46, 16);
            this.lblTaraE.TabIndex = 9;
            this.lblTaraE.Text = "peso1";
            // 
            // lblPesoS
            // 
            this.lblPesoS.AutoSize = true;
            this.lblPesoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoS.Location = new System.Drawing.Point(79, 66);
            this.lblPesoS.Name = "lblPesoS";
            this.lblPesoS.Size = new System.Drawing.Size(46, 16);
            this.lblPesoS.TabIndex = 8;
            this.lblPesoS.Text = "peso1";
            // 
            // lblPesoE
            // 
            this.lblPesoE.AutoSize = true;
            this.lblPesoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoE.Location = new System.Drawing.Point(79, 42);
            this.lblPesoE.Name = "lblPesoE";
            this.lblPesoE.Size = new System.Drawing.Size(46, 16);
            this.lblPesoE.TabIndex = 7;
            this.lblPesoE.Text = "peso1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(340, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(248, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Fecha/Hora";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(185, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Liq. (Kg)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(136, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tara";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Br. (kg)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Salida    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Entrada :";
            // 
            // chbxImpTicket
            // 
            this.chbxImpTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxImpTicket.AutoSize = true;
            this.chbxImpTicket.Checked = true;
            this.chbxImpTicket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxImpTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxImpTicket.Location = new System.Drawing.Point(558, 623);
            this.chbxImpTicket.Name = "chbxImpTicket";
            this.chbxImpTicket.Size = new System.Drawing.Size(114, 20);
            this.chbxImpTicket.TabIndex = 17;
            this.chbxImpTicket.Text = "Imprimir Ticket";
            this.chbxImpTicket.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(834, 639);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 18;
            this.txtUsuario.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Version 7.0";
            // 
            // lblHoraExacta
            // 
            this.lblHoraExacta.AutoSize = true;
            this.lblHoraExacta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraExacta.ForeColor = System.Drawing.Color.White;
            this.lblHoraExacta.Location = new System.Drawing.Point(831, 43);
            this.lblHoraExacta.Name = "lblHoraExacta";
            this.lblHoraExacta.Size = new System.Drawing.Size(92, 16);
            this.lblHoraExacta.TabIndex = 20;
            this.lblHoraExacta.Text = "Hora / Fecha  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblHoraExacta);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 69);
            this.panel1.TabIndex = 21;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(991, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxVehiculo);
            this.Controls.Add(this.txtPesoSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesoEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblTipoPesaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chbxImpTicket);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnPesar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE PESAJE COMPUTARIZADO";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gbxVehiculo.ResumeLayout(false);
            this.gbxVehiculo.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoPesaje;
        private System.Windows.Forms.GroupBox gbxVehiculo;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtPesoEntrada;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.TextBox txtPesoSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxPrecios;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.CheckBox chbxImpTicket;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label userSalida;
        private System.Windows.Forms.Label lblFecheS;
        private System.Windows.Forms.Label userEntrada;
        private System.Windows.Forms.Label lblFechaE;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTaraS;
        private System.Windows.Forms.Label lblTaraE;
        private System.Windows.Forms.Label lblPesoS;
        private System.Windows.Forms.Label lblPesoE;
        private System.Windows.Forms.Label lblHoraExacta;
        private System.Windows.Forms.Panel panel1;
    }
}

