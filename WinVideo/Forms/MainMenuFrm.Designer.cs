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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListaGeneros = new System.Windows.Forms.Button();
            this.btnListaFormatos = new System.Windows.Forms.Button();
            this.btnListaPeliculas = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnRenta = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.GridPeliculas = new System.Windows.Forms.DataGridView();
            this.labelNombreP = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnListaGeneros);
            this.panel1.Controls.Add(this.btnListaFormatos);
            this.panel1.Controls.Add(this.btnListaPeliculas);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 523);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 50);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(36, 377);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 50);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 321);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 50);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Pelicula";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnListaGeneros
            // 
            this.btnListaGeneros.Location = new System.Drawing.Point(18, 190);
            this.btnListaGeneros.Name = "btnListaGeneros";
            this.btnListaGeneros.Size = new System.Drawing.Size(230, 50);
            this.btnListaGeneros.TabIndex = 5;
            this.btnListaGeneros.Text = "Lista Generos";
            this.btnListaGeneros.UseVisualStyleBackColor = true;
            // 
            // btnListaFormatos
            // 
            this.btnListaFormatos.Location = new System.Drawing.Point(18, 113);
            this.btnListaFormatos.Name = "btnListaFormatos";
            this.btnListaFormatos.Size = new System.Drawing.Size(230, 50);
            this.btnListaFormatos.TabIndex = 6;
            this.btnListaFormatos.Text = "Lista Formatos";
            this.btnListaFormatos.UseVisualStyleBackColor = true;
            // 
            // btnListaPeliculas
            // 
            this.btnListaPeliculas.Location = new System.Drawing.Point(18, 36);
            this.btnListaPeliculas.Name = "btnListaPeliculas";
            this.btnListaPeliculas.Size = new System.Drawing.Size(230, 50);
            this.btnListaPeliculas.TabIndex = 7;
            this.btnListaPeliculas.Text = "Lista Peliculas";
            this.btnListaPeliculas.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(289, 1);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(124, 35);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Admin Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(419, 1);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(118, 35);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Facturacion";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // btnRenta
            // 
            this.btnRenta.Location = new System.Drawing.Point(543, 1);
            this.btnRenta.Name = "btnRenta";
            this.btnRenta.Size = new System.Drawing.Size(129, 35);
            this.btnRenta.TabIndex = 3;
            this.btnRenta.Text = "Rentas";
            this.btnRenta.UseVisualStyleBackColor = true;
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.Location = new System.Drawing.Point(678, 1);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(124, 35);
            this.btnPeliculas.TabIndex = 4;
            this.btnPeliculas.Text = "Admin Peliculas";
            this.btnPeliculas.UseVisualStyleBackColor = true;
            // 
            // GridPeliculas
            // 
            this.GridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPeliculas.Location = new System.Drawing.Point(334, 191);
            this.GridPeliculas.Name = "GridPeliculas";
            this.GridPeliculas.Size = new System.Drawing.Size(604, 315);
            this.GridPeliculas.TabIndex = 5;
            // 
            // labelNombreP
            // 
            this.labelNombreP.AutoSize = true;
            this.labelNombreP.Location = new System.Drawing.Point(344, 74);
            this.labelNombreP.Name = "labelNombreP";
            this.labelNombreP.Size = new System.Drawing.Size(33, 13);
            this.labelNombreP.TabIndex = 6;
            this.labelNombreP.Text = "Titulo";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Location = new System.Drawing.Point(344, 152);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(48, 13);
            this.labelSucursal.TabIndex = 7;
            this.labelSucursal.Text = "Sucursal";
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(344, 115);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(66, 13);
            this.labelClasificacion.TabIndex = 8;
            this.labelClasificacion.Text = "Clasificacion";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(419, 71);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(121, 20);
            this.txtNombreP.TabIndex = 9;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(419, 112);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cbClasificacion.TabIndex = 10;
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(419, 149);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cbSucursal.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(618, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 26);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Gurdar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(732, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 25);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // MainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 525);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.cbClasificacion);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.labelClasificacion);
            this.Controls.Add(this.labelSucursal);
            this.Controls.Add(this.labelNombreP);
            this.Controls.Add(this.GridPeliculas);
            this.Controls.Add(this.btnPeliculas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRenta);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnCliente);
            this.Name = "MainMenuFrm";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenuFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnRenta;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnListaGeneros;
        private System.Windows.Forms.Button btnListaFormatos;
        private System.Windows.Forms.Button btnListaPeliculas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView GridPeliculas;
        private System.Windows.Forms.Label labelNombreP;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}