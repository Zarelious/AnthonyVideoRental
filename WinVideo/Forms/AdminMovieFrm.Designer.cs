namespace WinVideo.Forms
{
    partial class AdminMovieFrm
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
            this.MovieGrdVw = new System.Windows.Forms.DataGridView();
            this.MovieTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassTxtBx = new System.Windows.Forms.TextBox();
            this.SaveBt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveBt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ClassTxtBx);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MovieTxtBx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 604);
            this.panel1.TabIndex = 0;
            // 
            // MovieGrdVw
            // 
            this.MovieGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieGrdVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieGrdVw.Location = new System.Drawing.Point(295, 0);
            this.MovieGrdVw.Name = "MovieGrdVw";
            this.MovieGrdVw.Size = new System.Drawing.Size(806, 604);
            this.MovieGrdVw.TabIndex = 1;
            // 
            // MovieTxtBx
            // 
            this.MovieTxtBx.Location = new System.Drawing.Point(133, 48);
            this.MovieTxtBx.Name = "MovieTxtBx";
            this.MovieTxtBx.Size = new System.Drawing.Size(100, 20);
            this.MovieTxtBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Classification";
            // 
            // ClassTxtBx
            // 
            this.ClassTxtBx.Location = new System.Drawing.Point(133, 100);
            this.ClassTxtBx.Name = "ClassTxtBx";
            this.ClassTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ClassTxtBx.TabIndex = 2;
            // 
            // SaveBt
            // 
            this.SaveBt.Location = new System.Drawing.Point(157, 143);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 23);
            this.SaveBt.TabIndex = 4;
            this.SaveBt.Text = "Save";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // AdminMovieFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 604);
            this.Controls.Add(this.MovieGrdVw);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMovieFrm";
            this.Text = "AdminMovieFrm";
            this.Load += new System.EventHandler(this.AdminMovieFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGrdVw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieTxtBx;
        private System.Windows.Forms.DataGridView MovieGrdVw;
    }
}