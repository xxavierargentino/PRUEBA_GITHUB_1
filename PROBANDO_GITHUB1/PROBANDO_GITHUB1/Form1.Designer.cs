﻿namespace PROBANDO_GITHUB1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcargar = new System.Windows.Forms.TextBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmblista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(87, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRUEBA GITHUB";
            // 
            // txtcargar
            // 
            this.txtcargar.Location = new System.Drawing.Point(72, 143);
            this.txtcargar.Name = "txtcargar";
            this.txtcargar.Size = new System.Drawing.Size(298, 20);
            this.txtcargar.TabIndex = 1;
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(123, 230);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(237, 126);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "TITULARES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmblista
            // 
            this.cmblista.FormattingEnabled = true;
            this.cmblista.Location = new System.Drawing.Point(115, 172);
            this.cmblista.Name = "cmblista";
            this.cmblista.Size = new System.Drawing.Size(244, 21);
            this.cmblista.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 419);
            this.Controls.Add(this.cmblista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.txtcargar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcargar;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmblista;
    }
}

