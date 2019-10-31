namespace WinVideo.Forms
{
    partial class Factura
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
            this.panelListas = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListaCom = new System.Windows.Forms.Button();
            this.GridHistorial = new System.Windows.Forms.DataGridView();
            this.panelListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // panelListas
            // 
            this.panelListas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelListas.Controls.Add(this.txtID);
            this.panelListas.Controls.Add(this.btnBuscar);
            this.panelListas.Controls.Add(this.btnListaCom);
            this.panelListas.Location = new System.Drawing.Point(33, 23);
            this.panelListas.Name = "panelListas";
            this.panelListas.Size = new System.Drawing.Size(253, 480);
            this.panelListas.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(55, 273);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(65, 314);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnListaCom
            // 
            this.btnListaCom.Location = new System.Drawing.Point(55, 70);
            this.btnListaCom.Name = "btnListaCom";
            this.btnListaCom.Size = new System.Drawing.Size(147, 39);
            this.btnListaCom.TabIndex = 2;
            this.btnListaCom.Text = "Historial";
            this.btnListaCom.UseVisualStyleBackColor = true;
            // 
            // GridHistorial
            // 
            this.GridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistorial.Location = new System.Drawing.Point(341, 64);
            this.GridHistorial.Name = "GridHistorial";
            this.GridHistorial.Size = new System.Drawing.Size(645, 391);
            this.GridHistorial.TabIndex = 1;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 532);
            this.Controls.Add(this.GridHistorial);
            this.Controls.Add(this.panelListas);
            this.Name = "Factura";
            this.Text = "Factura";
            this.panelListas.ResumeLayout(false);
            this.panelListas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelListas;
        private System.Windows.Forms.DataGridView GridHistorial;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListaCom;
    }
}