namespace WinVideo.Forms
{
    partial class MainMenuFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEditarFormat = new System.Windows.Forms.Button();
            this.BtnEditarGenero = new System.Windows.Forms.Button();
            this.btnBuscarPeli = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListaFormatos = new System.Windows.Forms.Button();
            this.btnListaPeliculas = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnRenta = new System.Windows.Forms.Button();
            this.GridPeliculas = new System.Windows.Forms.DataGridView();
            this.labelNombreP = new System.Windows.Forms.Label();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.labelFormato = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.QtyTxtBx = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTxtBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEditarFormat);
            this.panel1.Controls.Add(this.BtnEditarGenero);
            this.panel1.Controls.Add(this.btnBuscarPeli);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnListaFormatos);
            this.panel1.Controls.Add(this.btnListaPeliculas);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 523);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnEditarFormat
            // 
            this.BtnEditarFormat.Location = new System.Drawing.Point(18, 396);
            this.BtnEditarFormat.Name = "BtnEditarFormat";
            this.BtnEditarFormat.Size = new System.Drawing.Size(186, 50);
            this.BtnEditarFormat.TabIndex = 19;
            this.BtnEditarFormat.Text = "Editar Cantidad";
            this.BtnEditarFormat.UseVisualStyleBackColor = true;
            this.BtnEditarFormat.Click += new System.EventHandler(this.BtnEditarFormat_Click);
            // 
            // BtnEditarGenero
            // 
            this.BtnEditarGenero.Location = new System.Drawing.Point(18, 340);
            this.BtnEditarGenero.Name = "BtnEditarGenero";
            this.BtnEditarGenero.Size = new System.Drawing.Size(186, 50);
            this.BtnEditarGenero.TabIndex = 18;
            this.BtnEditarGenero.Text = "Editar Genero";
            this.BtnEditarGenero.UseVisualStyleBackColor = true;
            this.BtnEditarGenero.Click += new System.EventHandler(this.BtnEditarGenero_Click);
            // 
            // btnBuscarPeli
            // 
            this.btnBuscarPeli.Location = new System.Drawing.Point(18, 190);
            this.btnBuscarPeli.Name = "btnBuscarPeli";
            this.btnBuscarPeli.Size = new System.Drawing.Size(186, 32);
            this.btnBuscarPeli.TabIndex = 17;
            this.btnBuscarPeli.Text = "Buscar";
            this.btnBuscarPeli.UseVisualStyleBackColor = true;
            this.btnBuscarPeli.Click += new System.EventHandler(this.btnBuscarPeli_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 452);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 50);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(18, 284);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 50);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar Pelicula";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 50);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Pelicula";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListaFormatos
            // 
            this.btnListaFormatos.Location = new System.Drawing.Point(18, 94);
            this.btnListaFormatos.Name = "btnListaFormatos";
            this.btnListaFormatos.Size = new System.Drawing.Size(230, 50);
            this.btnListaFormatos.TabIndex = 1;
            this.btnListaFormatos.Text = "Lista Formatos";
            this.btnListaFormatos.UseVisualStyleBackColor = true;
            this.btnListaFormatos.Click += new System.EventHandler(this.btnListaFormatos_Click);
            // 
            // btnListaPeliculas
            // 
            this.btnListaPeliculas.Location = new System.Drawing.Point(18, 36);
            this.btnListaPeliculas.Name = "btnListaPeliculas";
            this.btnListaPeliculas.Size = new System.Drawing.Size(230, 50);
            this.btnListaPeliculas.TabIndex = 0;
            this.btnListaPeliculas.Text = "Lista Peliculas";
            this.btnListaPeliculas.UseVisualStyleBackColor = true;
            this.btnListaPeliculas.Click += new System.EventHandler(this.btnListaPeliculas_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(289, 1);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(124, 35);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "Admin Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Location = new System.Drawing.Point(419, 1);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(118, 35);
            this.btnDevoluciones.TabIndex = 9;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnRenta
            // 
            this.btnRenta.Location = new System.Drawing.Point(543, 1);
            this.btnRenta.Name = "btnRenta";
            this.btnRenta.Size = new System.Drawing.Size(129, 35);
            this.btnRenta.TabIndex = 10;
            this.btnRenta.Text = "Rentas";
            this.btnRenta.UseVisualStyleBackColor = true;
            this.btnRenta.Click += new System.EventHandler(this.btnRenta_Click);
            // 
            // GridPeliculas
            // 
            this.GridPeliculas.AllowUserToAddRows = false;
            this.GridPeliculas.AllowUserToDeleteRows = false;
            this.GridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPeliculas.Location = new System.Drawing.Point(305, 191);
            this.GridPeliculas.Name = "GridPeliculas";
            this.GridPeliculas.ReadOnly = true;
            this.GridPeliculas.RowHeadersWidth = 62;
            this.GridPeliculas.Size = new System.Drawing.Size(633, 315);
            this.GridPeliculas.TabIndex = 5;
            // 
            // labelNombreP
            // 
            this.labelNombreP.AutoSize = true;
            this.labelNombreP.Location = new System.Drawing.Point(418, 95);
            this.labelNombreP.Name = "labelNombreP";
            this.labelNombreP.Size = new System.Drawing.Size(33, 13);
            this.labelNombreP.TabIndex = 6;
            this.labelNombreP.Text = "Titulo";
            this.labelNombreP.Visible = false;
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(305, 117);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(66, 13);
            this.labelClasificacion.TabIndex = 8;
            this.labelClasificacion.Text = "Clasificacion";
            this.labelClasificacion.Visible = false;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(457, 88);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(215, 20);
            this.txtNombreP.TabIndex = 0;
            this.txtNombreP.Visible = false;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Items.AddRange(new object[] {
            "TP",
            "TPA",
            "TP7",
            "M12",
            "M15",
            "M18",
            "MX"});
            this.cbClasificacion.Location = new System.Drawing.Point(377, 114);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cbClasificacion.TabIndex = 1;
            this.cbClasificacion.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(726, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 26);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(840, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 25);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(352, 95);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(900, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(377, 146);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(121, 21);
            this.cbFormat.TabIndex = 2;
            this.cbFormat.Visible = false;
            // 
            // labelFormato
            // 
            this.labelFormato.AutoSize = true;
            this.labelFormato.Location = new System.Drawing.Point(326, 149);
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(45, 13);
            this.labelFormato.TabIndex = 17;
            this.labelFormato.Text = "Formato";
            this.labelFormato.Visible = false;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(551, 114);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 3;
            this.cbGenero.Visible = false;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(506, 117);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 19;
            this.labelGenero.Text = "Genero";
            this.labelGenero.Visible = false;
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Location = new System.Drawing.Point(516, 146);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(29, 13);
            this.QtyLabel.TabIndex = 22;
            this.QtyLabel.Text = "Cant";
            this.QtyLabel.Visible = false;
            // 
            // QtyTxtBx
            // 
            this.QtyTxtBx.Location = new System.Drawing.Point(551, 144);
            this.QtyTxtBx.Name = "QtyTxtBx";
            this.QtyTxtBx.Size = new System.Drawing.Size(92, 20);
            this.QtyTxtBx.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(376, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 23;
            // 
            // MainMenuFrm
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 525);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.QtyTxtBx);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.labelFormato);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbClasificacion);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.labelClasificacion);
            this.Controls.Add(this.labelNombreP);
            this.Controls.Add(this.GridPeliculas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRenta);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.btnCliente);
            this.Name = "MainMenuFrm";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainMenuFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTxtBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnRenta;
        private System.Windows.Forms.Button btnListaFormatos;
        private System.Windows.Forms.Button btnListaPeliculas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView GridPeliculas;
        private System.Windows.Forms.Label labelNombreP;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarPeli;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label labelFormato;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.NumericUpDown QtyTxtBx;
        private System.Windows.Forms.NumericUpDown txtID;
        private System.Windows.Forms.Button BtnEditarFormat;
        private System.Windows.Forms.Button BtnEditarGenero;
    }
}