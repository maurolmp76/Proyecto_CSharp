namespace AplicacioesMatematicas
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
            this.lblcalculadora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcalculadora
            // 
            this.lblcalculadora.AutoSize = true;
            this.lblcalculadora.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculadora.Location = new System.Drawing.Point(470, 67);
            this.lblcalculadora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcalculadora.Name = "lblcalculadora";
            this.lblcalculadora.Size = new System.Drawing.Size(285, 32);
            this.lblcalculadora.TabIndex = 1;
            this.lblcalculadora.Text = "Calculadora Sencilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa otro número";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero1.Location = new System.Drawing.Point(442, 169);
            this.txtnumero1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(313, 29);
            this.txtnumero1.TabIndex = 4;
            this.txtnumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero2.Location = new System.Drawing.Point(442, 223);
            this.txtnumero2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(313, 29);
            this.txtnumero2.TabIndex = 5;
            this.txtnumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsumar
            // 
            this.btnsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsumar.Location = new System.Drawing.Point(241, 317);
            this.btnsumar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(140, 66);
            this.btnsumar.TabIndex = 6;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.Location = new System.Drawing.Point(615, 317);
            this.btnmultiplicar.Margin = new System.Windows.Forms.Padding(5);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(140, 66);
            this.btnmultiplicar.TabIndex = 7;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestar.Location = new System.Drawing.Point(442, 317);
            this.btnrestar.Margin = new System.Windows.Forms.Padding(5);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(140, 66);
            this.btnrestar.TabIndex = 8;
            this.btnrestar.Text = "Restar";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(807, 317);
            this.btndividir.Margin = new System.Windows.Forms.Padding(5);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(140, 66);
            this.btndividir.TabIndex = 9;
            this.btndividir.Text = "Dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(807, 169);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(140, 97);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar campos";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(351, 433);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(36, 37);
            this.lblresultado.TabIndex = 11;
            this.lblresultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 533);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcalculadora);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalculadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lblresultado;
    }
}

