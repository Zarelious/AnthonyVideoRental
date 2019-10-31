namespace WinVideo.Forms
{
    partial class LogInFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userTxtBx = new System.Windows.Forms.TextBox();
            this.passwTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // userTxtBx
            // 
            this.userTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBx.Location = new System.Drawing.Point(207, 53);
            this.userTxtBx.Name = "userTxtBx";
            this.userTxtBx.Size = new System.Drawing.Size(227, 29);
            this.userTxtBx.TabIndex = 1;
            // 
            // passwTxtBx
            // 
            this.passwTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwTxtBx.Location = new System.Drawing.Point(207, 97);
            this.passwTxtBx.Name = "passwTxtBx";
            this.passwTxtBx.Size = new System.Drawing.Size(227, 29);
            this.passwTxtBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // EnterBt
            // 
            this.EnterBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBt.Location = new System.Drawing.Point(327, 132);
            this.EnterBt.Name = "EnterBt";
            this.EnterBt.Size = new System.Drawing.Size(107, 35);
            this.EnterBt.TabIndex = 4;
            this.EnterBt.Text = "Ingressar";
            this.EnterBt.UseVisualStyleBackColor = true;
            this.EnterBt.Click += new System.EventHandler(this.EnterBt_Click);
            // 
            // LogInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 217);
            this.Controls.Add(this.EnterBt);
            this.Controls.Add(this.passwTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "LogInFrm";
            this.Text = "LogInFrm";
            this.Load += new System.EventHandler(this.LogInFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userTxtBx;
        private System.Windows.Forms.TextBox passwTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnterBt;
    }
}