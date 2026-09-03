namespace practica03_Brian
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.txtfahrenheit = new System.Windows.Forms.TextBox();
            this.txtkelvin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKelvin);
            this.groupBox1.Controls.Add(this.rbFahrenheit);
            this.groupBox1.Controls.Add(this.rbCelsius);
            this.groupBox1.Location = new System.Drawing.Point(66, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "seleccione la unidad a convertir";
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(213, 35);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 2;
            this.rbKelvin.TabStop = true;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(108, 37);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rbFahrenheit.TabIndex = 1;
            this.rbFahrenheit.TabStop = true;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            this.rbFahrenheit.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Location = new System.Drawing.Point(6, 35);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(58, 17);
            this.rbCelsius.TabIndex = 0;
            this.rbCelsius.TabStop = true;
            this.rbCelsius.Text = "Celsius";
            this.rbCelsius.UseVisualStyleBackColor = true;
            this.rbCelsius.CheckedChanged += new System.EventHandler(this.rbcelsius_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kelvin";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(82, 383);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(136, 30);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Lime;
            this.btncancelar.Location = new System.Drawing.Point(253, 385);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(128, 27);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(177, 60);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(138, 20);
            this.txtcelsius.TabIndex = 6;
            // 
            // txtfahrenheit
            // 
            this.txtfahrenheit.Location = new System.Drawing.Point(177, 92);
            this.txtfahrenheit.Name = "txtfahrenheit";
            this.txtfahrenheit.Size = new System.Drawing.Size(138, 20);
            this.txtfahrenheit.TabIndex = 7;
            // 
            // txtkelvin
            // 
            this.txtkelvin.Location = new System.Drawing.Point(176, 126);
            this.txtkelvin.Name = "txtkelvin";
            this.txtkelvin.Size = new System.Drawing.Size(138, 20);
            this.txtkelvin.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::practica03_Brian.Properties.Resources.haryyyyyyyyyyyy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkelvin);
            this.Controls.Add(this.txtfahrenheit);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.TextBox txtfahrenheit;
        private System.Windows.Forms.TextBox txtkelvin;
    }
}

