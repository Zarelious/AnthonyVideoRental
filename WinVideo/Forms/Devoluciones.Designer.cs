namespace WinVideo.Forms
{
    partial class Devoluciones
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
            this.GridDevoluciones = new System.Windows.Forms.DataGridView();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataVidDataSet1 = new WinVideo.DataVidDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WinVideo.DataVidDataSet1TableAdapters.ClientTableAdapter();
            this.dataVidDataSet = new WinVideo.DataVidDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new WinVideo.DataVidDataSetTableAdapters.MovieTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDevoluciones
            // 
            this.GridDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDevoluciones.Location = new System.Drawing.Point(73, 118);
            this.GridDevoluciones.Name = "GridDevoluciones";
            this.GridDevoluciones.Size = new System.Drawing.Size(652, 309);
            this.GridDevoluciones.TabIndex = 0;
            // 
            // cbId
            // 
            this.cbId.DataSource = this.clientBindingSource;
            this.cbId.DisplayMember = "IdClient";
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(132, 72);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(171, 21);
            this.cbId.TabIndex = 1;
            // 
            // cbPelicula
            // 
            this.cbPelicula.DataSource = this.movieBindingSource;
            this.cbPelicula.DisplayMember = "IdMovie";
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(347, 72);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(172, 21);
            this.cbPelicula.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pelicula";
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
            // dataVidDataSet
            // 
            this.dataVidDataSet.DataSetName = "DataVidDataSet";
            this.dataVidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(559, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(559, 76);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(144, 30);
            this.Buscar.TabIndex = 8;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(559, 40);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(144, 30);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPelicula);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.GridDevoluciones);
            this.Name = "Devoluciones";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVidDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDevoluciones;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.ComboBox cbPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DataVidDataSet1 dataVidDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataVidDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private DataVidDataSet dataVidDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private DataVidDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button btnEditar;
    }
}