namespace EjemploDepuracionCodigo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lvnumeros = new System.Windows.Forms.ListView();
            this.btnrellenar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lvnumeros2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo con uso del ciclo mientras.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un valor:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(104, 71);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            // 
            // lvnumeros
            // 
            this.lvnumeros.Location = new System.Drawing.Point(12, 144);
            this.lvnumeros.Name = "lvnumeros";
            this.lvnumeros.Size = new System.Drawing.Size(102, 227);
            this.lvnumeros.TabIndex = 3;
            this.lvnumeros.UseCompatibleStateImageBehavior = false;
            // 
            // btnrellenar
            // 
            this.btnrellenar.Location = new System.Drawing.Point(165, 97);
            this.btnrellenar.Name = "btnrellenar";
            this.btnrellenar.Size = new System.Drawing.Size(57, 25);
            this.btnrellenar.TabIndex = 4;
            this.btnrellenar.Text = "Rellenar";
            this.btnrellenar.UseVisualStyleBackColor = true;
            this.btnrellenar.Click += new System.EventHandler(this.btnrellenar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "_______________________________";
            // 
            // lvnumeros2
            // 
            this.lvnumeros2.Location = new System.Drawing.Point(120, 144);
            this.lvnumeros2.Name = "lvnumeros2";
            this.lvnumeros2.Size = new System.Drawing.Size(102, 227);
            this.lvnumeros2.TabIndex = 6;
            this.lvnumeros2.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Fibonacci";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvnumeros2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnrellenar);
            this.Controls.Add(this.lvnumeros);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consecutivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ListView lvnumeros;
        private System.Windows.Forms.Button btnrellenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvnumeros2;
        private System.Windows.Forms.Button button1;
    }
}

