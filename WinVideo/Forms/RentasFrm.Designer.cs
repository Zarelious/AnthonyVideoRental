namespace WinVideo.Forms
{
    partial class RentasFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.labelIDCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbIdSucursal = new System.Windows.Forms.ComboBox();
            this.cbIdPelicula = new System.Windows.Forms.ComboBox();
            this.dataVidDataSet = new WinVideo.DataVidDataSet();
            this.cbIdCliente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.GridRentas = new System.Windows.Forms.DataGridView();
            this.idRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeliculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataVidDataSet2 = new WinVideo.DataVidDataSet2();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new WinVideo.DataVidDataSetTableAdapters.MovieTableAdapter();
            this.dataVidDataSet1 = new WinVideo.DataVidDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WinVideo.DataVidDataSet1TableAdapters.ClientTableAdapter();
            this.rentalTableAdapter = new WinVideo.DataVidDataSet2TableAdapters.RentalTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(12, 12);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(194, 44);
            this.btnLista.TabIndex = 0;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(233, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(194, 44);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Realizar Renta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbBuscar);
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 67);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(902, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 31);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(802, 25);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(94, 21);
            this.cbBuscar.TabIndex = 2;
            // 
            // labelIDCliente
            // 
            this.labelIDCliente.AutoSize = true;
            this.labelIDCliente.Location = new System.Drawing.Point(100, 127);
            this.labelIDCliente.Name = "labelIDCliente";
            this.labelIDCliente.Size = new System.Drawing.Size(53, 13);
            this.labelIDCliente.TabIndex = 3;
            this.labelIDCliente.Text = "ID Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(165, 198);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(214, 20);
            this.dtFecha.TabIndex = 10;
            // 
            // cbIdSucursal
            // 
            this.cbIdSucursal.Enabled = false;
            this.cbIdSucursal.FormattingEnabled = true;
            this.cbIdSucursal.Items.AddRange(new object[] {
            "1"});
            this.cbIdSucursal.Location = new System.Drawing.Point(165, 271);
            this.cbIdSucursal.Name = "cbIdSucursal";
            this.cbIdSucursal.Size = new System.Drawing.Size(214, 21);
            this.cbIdSucursal.TabIndex = 11;
            // 
            // cbIdPelicula
            // 
            this.cbIdPelicula.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataVidDataSet, "Movie.IdMovie", true));
            this.cbIdPelicula.DataSource = this.movieBindingSource;
            this.cbIdPelicula.DisplayMember = "IdMovie";
            this.cbIdPelicula.Enabled = false;
            this.cbIdPelicula.FormattingEnabled = true;
            this.cbIdPelicula.Location = new System.Drawing.Point(165, 344);
            this.cbIdPelicula.Name = "cbIdPelicula";
            this.cbIdPelicula.Size = new System.Drawing.Size(214, 21);
            this.cbIdPelicula.TabIndex = 12;
            // 
            // dataVidDataSet
            // 
            this.dataVidDataSet.DataSetName = "DataVidDataSet";
            this.dataVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbIdCliente
            // 
            this.cbIdCliente.DataSource = this.clientBindingSource;
            this.cbIdCliente.DisplayMember = "IdClient";
            this.cbIdCliente.Enabled = false;
            this.cbIdCliente.FormattingEnabled = true;
            this.cbIdCliente.Location = new System.Drawing.Point(165, 124);
            this.cbIdCliente.Name = "cbIdCliente";
            this.cbIdCliente.Size = new System.Drawing.Size(214, 21);
            this.cbIdCliente.TabIndex = 13;
            this.cbIdCliente.SelectedValueChanged += new System.EventHandler(this.cbIdCliente_SelectedValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(283, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(175, 471);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 31);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GridRentas
            // 
            this.GridRentas.AutoGenerateColumns = false;
            this.GridRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRentaDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.idPeliculaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateRentDataGridViewTextBoxColumn,
            this.dateVencimientoDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn});
            this.GridRentas.DataSource = this.rentalBindingSource;
            this.GridRentas.Location = new System.Drawing.Point(440, 124);
            this.GridRentas.Name = "GridRentas";
            this.GridRentas.Size = new System.Drawing.Size(585, 378);
            this.GridRentas.TabIndex = 16;
            // 
            // idRentaDataGridViewTextBoxColumn
            // 
            this.idRentaDataGridViewTextBoxColumn.DataPropertyName = "IdRenta";
            this.idRentaDataGridViewTextBoxColumn.HeaderText = "IdRenta";
            this.idRentaDataGridViewTextBoxColumn.Name = "idRentaDataGridViewTextBoxColumn";
            this.idRentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            // 
            // idPeliculaDataGridViewTextBoxColumn
            // 
            this.idPeliculaDataGridViewTextBoxColumn.DataPropertyName = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.HeaderText = "IdPelicula";
            this.idPeliculaDataGridViewTextBoxColumn.Name = "idPeliculaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // dateRentDataGridViewTextBoxColumn
            // 
            this.dateRentDataGridViewTextBoxColumn.DataPropertyName = "DateRent";
            this.dateRentDataGridViewTextBoxColumn.HeaderText = "DateRent";
            this.dateRentDataGridViewTextBoxColumn.Name = "dateRentDataGridViewTextBoxColumn";
            // 
            // dateVencimientoDataGridViewTextBoxColumn
            // 
            this.dateVencimientoDataGridViewTextBoxColumn.DataPropertyName = "DateVencimiento";
            this.dateVencimientoDataGridViewTextBoxColumn.HeaderText = "DateVencimiento";
            this.dateVencimientoDataGridViewTextBoxColumn.Name = "dateVencimientoDataGridViewTextBoxColumn";
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            // 
            // rentalBindingSource
            // 
            this.rentalBindingSource.DataMember = "Rental";
            this.rentalBindingSource.DataSource = this.dataVidDataSet2;
            // 
            // dataVidDataSet2
            // 
            this.dataVidDataSet2.DataSetName = "DataVidDataSet2";
            this.dataVidDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.dataVidDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // dataVidDataSet1
            // 
            this.dataVidDataSet1.DataSetName = "DataVidDataSet1";
            this.dataVidDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataVidDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // rentalTableAdapter
            // 
            this.rentalTableAdapter.ClearBeforeFill = true;
            // 
            // RentasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 538);
            this.Controls.Add(this.GridRentas);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbIdCliente);
            this.Controls.Add(this.cbIdPelicula);
            this.Controls.Add(this.cbIdSucursal);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIDCliente);
            this.Controls.Add(this.panel1);
            this.Name = "RentasFrm";
            this.Text = "VentasRentFrm";
            this.Load += new System.EventHandler(this.VentasRentFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbIdSucursal;
        private System.Windows.Forms.ComboBox cbIdPelicula;
        private System.Windows.Forms.ComboBox cbIdCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView GridRentas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private DataVidDataSet dataVidDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private DataVidDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private DataVidDataSet1 dataVidDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataVidDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private DataVidDataSet2 dataVidDataSet2;
        private System.Windows.Forms.BindingSource rentalBindingSource;
        private DataVidDataSet2TableAdapters.RentalTableAdapter rentalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeliculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
    }
}