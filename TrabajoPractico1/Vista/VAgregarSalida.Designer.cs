﻿namespace TrabajoPractico1.Vista
{
    partial class VAgregarSalida
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPaquetes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCupos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBase = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tbTarifa = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Paquete: ";
            // 
            // cbPaquetes
            // 
            this.cbPaquetes.FormattingEnabled = true;
            this.cbPaquetes.Location = new System.Drawing.Point(141, 53);
            this.cbPaquetes.Name = "cbPaquetes";
            this.cbPaquetes.Size = new System.Drawing.Size(121, 21);
            this.cbPaquetes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "fecha", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.dtFecha.Location = new System.Drawing.Point(83, 105);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 3;
            this.dtFecha.Value = new System.DateTime(2017, 9, 10, 16, 7, 58, 0);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(TrabajoPractico1.Modelo.Salida);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agregar una Nueva Salisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cupos";
            // 
            // tbCupos
            // 
            this.tbCupos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cupoSalida", true));
            this.tbCupos.Location = new System.Drawing.Point(83, 156);
            this.tbCupos.Name = "tbCupos";
            this.tbCupos.Size = new System.Drawing.Size(100, 20);
            this.tbCupos.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccionar Base: ";
            // 
            // cbBase
            // 
            this.cbBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "vase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbBase.FormattingEnabled = true;
            this.cbBase.Location = new System.Drawing.Point(150, 199);
            this.cbBase.Name = "cbBase";
            this.cbBase.Size = new System.Drawing.Size(121, 21);
            this.cbBase.TabIndex = 8;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(TrabajoPractico1.Modelo.Tarifa);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio";
            // 
            // tbTarifa
            // 
            this.tbTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "precio", true));
            this.tbTarifa.Location = new System.Drawing.Point(83, 249);
            this.tbTarifa.Name = "tbTarifa";
            this.tbTarifa.Size = new System.Drawing.Size(100, 20);
            this.tbTarifa.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(196, 292);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VAgregarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 327);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbTarifa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCupos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPaquetes);
            this.Controls.Add(this.label1);
            this.Name = "VAgregarSalida";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Salida";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPaquetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCupos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTarifa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}