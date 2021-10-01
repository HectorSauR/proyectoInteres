
namespace InteresSimple
{
    partial class FInteresSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInteresSimple));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ganancia = new System.Windows.Forms.RadioButton();
            this.rb_perdida = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ValorFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ValorFinal = new System.Windows.Forms.RadioButton();
            this.rb_NumPeriodos = new System.Windows.Forms.RadioButton();
            this.rb_CapitalInicial = new System.Windows.Forms.RadioButton();
            this.rb_TasaInteres = new System.Windows.Forms.RadioButton();
            this.rb_Interes = new System.Windows.Forms.RadioButton();
            this.txt_numeroPeriodos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tasaInteres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_capInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_interes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btn_borrar);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txt_ValorFinal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txt_numeroPeriodos);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_tasaInteres);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_capInicial);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_interes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 425);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.rb_ganancia);
            this.groupBox2.Controls.Add(this.rb_perdida);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(714, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de interes";
            // 
            // rb_ganancia
            // 
            this.rb_ganancia.AutoSize = true;
            this.rb_ganancia.Location = new System.Drawing.Point(20, 88);
            this.rb_ganancia.Name = "rb_ganancia";
            this.rb_ganancia.Size = new System.Drawing.Size(81, 22);
            this.rb_ganancia.TabIndex = 2;
            this.rb_ganancia.TabStop = true;
            this.rb_ganancia.Text = "Ganancia";
            this.rb_ganancia.UseVisualStyleBackColor = true;
            // 
            // rb_perdida
            // 
            this.rb_perdida.AutoSize = true;
            this.rb_perdida.Location = new System.Drawing.Point(20, 44);
            this.rb_perdida.Name = "rb_perdida";
            this.rb_perdida.Size = new System.Drawing.Size(72, 22);
            this.rb_perdida.TabIndex = 0;
            this.rb_perdida.TabStop = true;
            this.rb_perdida.Text = "Pérdida";
            this.rb_perdida.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(734, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ValorFinal
            // 
            this.txt_ValorFinal.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorFinal.Location = new System.Drawing.Point(483, 289);
            this.txt_ValorFinal.Name = "txt_ValorFinal";
            this.txt_ValorFinal.Size = new System.Drawing.Size(120, 29);
            this.txt_ValorFinal.TabIndex = 5;
            this.txt_ValorFinal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor Futuro:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.rb_ValorFinal);
            this.groupBox1.Controls.Add(this.rb_NumPeriodos);
            this.groupBox1.Controls.Add(this.rb_CapitalInicial);
            this.groupBox1.Controls.Add(this.rb_TasaInteres);
            this.groupBox1.Controls.Add(this.rb_Interes);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 307);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Problema a resolver";
            // 
            // rb_ValorFinal
            // 
            this.rb_ValorFinal.AutoSize = true;
            this.rb_ValorFinal.Location = new System.Drawing.Point(20, 242);
            this.rb_ValorFinal.Name = "rb_ValorFinal";
            this.rb_ValorFinal.Size = new System.Drawing.Size(101, 22);
            this.rb_ValorFinal.TabIndex = 4;
            this.rb_ValorFinal.TabStop = true;
            this.rb_ValorFinal.Text = "Valor Futuro";
            this.rb_ValorFinal.UseVisualStyleBackColor = true;
            this.rb_ValorFinal.CheckedChanged += new System.EventHandler(this.rb_ValorInicial_CheckedChanged);
            // 
            // rb_NumPeriodos
            // 
            this.rb_NumPeriodos.AutoSize = true;
            this.rb_NumPeriodos.Location = new System.Drawing.Point(20, 193);
            this.rb_NumPeriodos.Name = "rb_NumPeriodos";
            this.rb_NumPeriodos.Size = new System.Drawing.Size(132, 22);
            this.rb_NumPeriodos.TabIndex = 3;
            this.rb_NumPeriodos.TabStop = true;
            this.rb_NumPeriodos.Text = "Numero Periodos";
            this.rb_NumPeriodos.UseVisualStyleBackColor = true;
            this.rb_NumPeriodos.CheckedChanged += new System.EventHandler(this.rb_NumPeriodos_CheckedChanged);
            // 
            // rb_CapitalInicial
            // 
            this.rb_CapitalInicial.AutoSize = true;
            this.rb_CapitalInicial.Location = new System.Drawing.Point(20, 93);
            this.rb_CapitalInicial.Name = "rb_CapitalInicial";
            this.rb_CapitalInicial.Size = new System.Drawing.Size(104, 22);
            this.rb_CapitalInicial.TabIndex = 2;
            this.rb_CapitalInicial.TabStop = true;
            this.rb_CapitalInicial.Text = "Capital Inicial";
            this.rb_CapitalInicial.UseVisualStyleBackColor = true;
            this.rb_CapitalInicial.CheckedChanged += new System.EventHandler(this.rb_CapitalInicial_CheckedChanged);
            // 
            // rb_TasaInteres
            // 
            this.rb_TasaInteres.AutoSize = true;
            this.rb_TasaInteres.Location = new System.Drawing.Point(20, 149);
            this.rb_TasaInteres.Name = "rb_TasaInteres";
            this.rb_TasaInteres.Size = new System.Drawing.Size(98, 22);
            this.rb_TasaInteres.TabIndex = 1;
            this.rb_TasaInteres.TabStop = true;
            this.rb_TasaInteres.Text = "Tasa Interes";
            this.rb_TasaInteres.UseVisualStyleBackColor = true;
            this.rb_TasaInteres.CheckedChanged += new System.EventHandler(this.rb_TasaInteres_CheckedChanged);
            // 
            // rb_Interes
            // 
            this.rb_Interes.AutoSize = true;
            this.rb_Interes.Location = new System.Drawing.Point(20, 44);
            this.rb_Interes.Name = "rb_Interes";
            this.rb_Interes.Size = new System.Drawing.Size(68, 22);
            this.rb_Interes.TabIndex = 0;
            this.rb_Interes.TabStop = true;
            this.rb_Interes.Text = "Interés";
            this.rb_Interes.UseVisualStyleBackColor = true;
            this.rb_Interes.CheckedChanged += new System.EventHandler(this.rb_Interes_CheckedChanged);
            // 
            // txt_numeroPeriodos
            // 
            this.txt_numeroPeriodos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPeriodos.Location = new System.Drawing.Point(483, 239);
            this.txt_numeroPeriodos.Name = "txt_numeroPeriodos";
            this.txt_numeroPeriodos.Size = new System.Drawing.Size(120, 29);
            this.txt_numeroPeriodos.TabIndex = 4;
            this.txt_numeroPeriodos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero Periodos:";
            // 
            // txt_tasaInteres
            // 
            this.txt_tasaInteres.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tasaInteres.Location = new System.Drawing.Point(483, 190);
            this.txt_tasaInteres.Name = "txt_tasaInteres";
            this.txt_tasaInteres.Size = new System.Drawing.Size(120, 29);
            this.txt_tasaInteres.TabIndex = 3;
            this.txt_tasaInteres.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tasa de interés:";
            // 
            // txt_capInicial
            // 
            this.txt_capInicial.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capInicial.Location = new System.Drawing.Point(483, 143);
            this.txt_capInicial.Name = "txt_capInicial";
            this.txt_capInicial.Size = new System.Drawing.Size(120, 29);
            this.txt_capInicial.TabIndex = 2;
            this.txt_capInicial.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capital inicial:";
            // 
            // txt_interes
            // 
            this.txt_interes.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interes.Location = new System.Drawing.Point(483, 97);
            this.txt_interes.Name = "txt_interes";
            this.txt_interes.Size = new System.Drawing.Size(120, 29);
            this.txt_interes.TabIndex = 1;
            this.txt_interes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interés:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interes simple";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(734, 361);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 35);
            this.btn_borrar.TabIndex = 12;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // FInteresSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 425);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FInteresSimple";
            this.Text = "Interes Simple";
            this.Load += new System.EventHandler(this.FInteresSimple_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_numeroPeriodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tasaInteres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_capInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_interes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_NumPeriodos;
        private System.Windows.Forms.RadioButton rb_CapitalInicial;
        private System.Windows.Forms.RadioButton rb_TasaInteres;
        private System.Windows.Forms.RadioButton rb_Interes;
        private System.Windows.Forms.TextBox txt_ValorFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_ValorFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_ganancia;
        private System.Windows.Forms.RadioButton rb_perdida;
        private System.Windows.Forms.Button btn_borrar;
    }
}

