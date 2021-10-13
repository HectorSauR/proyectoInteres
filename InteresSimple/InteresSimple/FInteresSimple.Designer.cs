
namespace InteresSimple
{
    partial class FInteresSimple
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ValorFinal = new System.Windows.Forms.RadioButton();
            this.rb_Interes = new System.Windows.Forms.RadioButton();
            this.rb_TasaInteres = new System.Windows.Forms.RadioButton();
            this.rb_NumPeriodos = new System.Windows.Forms.RadioButton();
            this.rb_CapitalInicial = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_capInicial = new System.Windows.Forms.TextBox();
            this.txt_numeroPeriodos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tasaInteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_interes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ValorFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_perdida = new System.Windows.Forms.RadioButton();
            this.rb_ganancia = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_tipoPeriodo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(406, 330);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(86, 44);
            this.btn_borrar.TabIndex = 1;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rb_ValorFinal);
            this.groupBox1.Controls.Add(this.rb_Interes);
            this.groupBox1.Controls.Add(this.rb_TasaInteres);
            this.groupBox1.Controls.Add(this.rb_NumPeriodos);
            this.groupBox1.Controls.Add(this.rb_CapitalInicial);
            this.groupBox1.Location = new System.Drawing.Point(28, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcion a calcular";
            // 
            // rb_ValorFinal
            // 
            this.rb_ValorFinal.AutoSize = true;
            this.rb_ValorFinal.Location = new System.Drawing.Point(22, 217);
            this.rb_ValorFinal.Name = "rb_ValorFinal";
            this.rb_ValorFinal.Size = new System.Drawing.Size(88, 22);
            this.rb_ValorFinal.TabIndex = 4;
            this.rb_ValorFinal.TabStop = true;
            this.rb_ValorFinal.Text = "Valor Final";
            this.rb_ValorFinal.UseVisualStyleBackColor = true;
            this.rb_ValorFinal.CheckedChanged += new System.EventHandler(this.rb_ValorFinal_CheckedChanged);
            // 
            // rb_Interes
            // 
            this.rb_Interes.AutoSize = true;
            this.rb_Interes.Location = new System.Drawing.Point(22, 180);
            this.rb_Interes.Name = "rb_Interes";
            this.rb_Interes.Size = new System.Drawing.Size(68, 22);
            this.rb_Interes.TabIndex = 3;
            this.rb_Interes.TabStop = true;
            this.rb_Interes.Text = "Interes";
            this.rb_Interes.UseVisualStyleBackColor = true;
            this.rb_Interes.CheckedChanged += new System.EventHandler(this.rb_Interes_CheckedChanged_1);
            // 
            // rb_TasaInteres
            // 
            this.rb_TasaInteres.AutoSize = true;
            this.rb_TasaInteres.Location = new System.Drawing.Point(22, 139);
            this.rb_TasaInteres.Name = "rb_TasaInteres";
            this.rb_TasaInteres.Size = new System.Drawing.Size(98, 22);
            this.rb_TasaInteres.TabIndex = 2;
            this.rb_TasaInteres.TabStop = true;
            this.rb_TasaInteres.Text = "Tasa Interes";
            this.rb_TasaInteres.UseVisualStyleBackColor = true;
            this.rb_TasaInteres.CheckedChanged += new System.EventHandler(this.rb_TasaInteres_CheckedChanged_1);
            // 
            // rb_NumPeriodos
            // 
            this.rb_NumPeriodos.AutoSize = true;
            this.rb_NumPeriodos.Location = new System.Drawing.Point(22, 98);
            this.rb_NumPeriodos.Name = "rb_NumPeriodos";
            this.rb_NumPeriodos.Size = new System.Drawing.Size(132, 22);
            this.rb_NumPeriodos.TabIndex = 1;
            this.rb_NumPeriodos.TabStop = true;
            this.rb_NumPeriodos.Text = "Numero Periodos";
            this.rb_NumPeriodos.UseVisualStyleBackColor = true;
            this.rb_NumPeriodos.CheckedChanged += new System.EventHandler(this.rb_NumPeriodos_CheckedChanged_1);
            // 
            // rb_CapitalInicial
            // 
            this.rb_CapitalInicial.AutoSize = true;
            this.rb_CapitalInicial.Location = new System.Drawing.Point(22, 55);
            this.rb_CapitalInicial.Name = "rb_CapitalInicial";
            this.rb_CapitalInicial.Size = new System.Drawing.Size(103, 22);
            this.rb_CapitalInicial.TabIndex = 0;
            this.rb_CapitalInicial.TabStop = true;
            this.rb_CapitalInicial.Text = "Capital inicial";
            this.rb_CapitalInicial.UseVisualStyleBackColor = true;
            this.rb_CapitalInicial.CheckedChanged += new System.EventHandler(this.rb_CapitalInicial_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Capital inicial:";
            // 
            // txt_capInicial
            // 
            this.txt_capInicial.Location = new System.Drawing.Point(356, 111);
            this.txt_capInicial.Name = "txt_capInicial";
            this.txt_capInicial.Size = new System.Drawing.Size(119, 25);
            this.txt_capInicial.TabIndex = 7;
            this.txt_capInicial.Text = "0";
            this.txt_capInicial.TextChanged += new System.EventHandler(this.txt_capInicial_TextChanged);
            // 
            // txt_numeroPeriodos
            // 
            this.txt_numeroPeriodos.Location = new System.Drawing.Point(355, 154);
            this.txt_numeroPeriodos.Name = "txt_numeroPeriodos";
            this.txt_numeroPeriodos.Size = new System.Drawing.Size(119, 25);
            this.txt_numeroPeriodos.TabIndex = 9;
            this.txt_numeroPeriodos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero Periodos:";
            // 
            // txt_tasaInteres
            // 
            this.txt_tasaInteres.Location = new System.Drawing.Point(355, 198);
            this.txt_tasaInteres.Name = "txt_tasaInteres";
            this.txt_tasaInteres.Size = new System.Drawing.Size(119, 25);
            this.txt_tasaInteres.TabIndex = 11;
            this.txt_tasaInteres.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tasa Interes:";
            // 
            // txt_interes
            // 
            this.txt_interes.Location = new System.Drawing.Point(355, 239);
            this.txt_interes.Name = "txt_interes";
            this.txt_interes.Size = new System.Drawing.Size(119, 25);
            this.txt_interes.TabIndex = 13;
            this.txt_interes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Interes:";
            // 
            // txt_ValorFinal
            // 
            this.txt_ValorFinal.Location = new System.Drawing.Point(355, 280);
            this.txt_ValorFinal.Name = "txt_ValorFinal";
            this.txt_ValorFinal.Size = new System.Drawing.Size(119, 25);
            this.txt_ValorFinal.TabIndex = 15;
            this.txt_ValorFinal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Valor Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interes Simple";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rb_perdida);
            this.groupBox2.Controls.Add(this.rb_ganancia);
            this.groupBox2.Location = new System.Drawing.Point(540, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Interes:";
            // 
            // rb_perdida
            // 
            this.rb_perdida.AutoSize = true;
            this.rb_perdida.Location = new System.Drawing.Point(37, 84);
            this.rb_perdida.Name = "rb_perdida";
            this.rb_perdida.Size = new System.Drawing.Size(72, 22);
            this.rb_perdida.TabIndex = 1;
            this.rb_perdida.TabStop = true;
            this.rb_perdida.Text = "Perdida";
            this.rb_perdida.UseVisualStyleBackColor = true;
            // 
            // rb_ganancia
            // 
            this.rb_ganancia.AutoSize = true;
            this.rb_ganancia.Location = new System.Drawing.Point(37, 41);
            this.rb_ganancia.Name = "rb_ganancia";
            this.rb_ganancia.Size = new System.Drawing.Size(81, 22);
            this.rb_ganancia.TabIndex = 0;
            this.rb_ganancia.TabStop = true;
            this.rb_ganancia.Text = "Ganancia";
            this.rb_ganancia.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo periodo:";
            // 
            // cb_tipoPeriodo
            // 
            this.cb_tipoPeriodo.FormattingEnabled = true;
            this.cb_tipoPeriodo.Items.AddRange(new object[] {
            "Años",
            "Meses",
            "Dias",
            "Semestres"});
            this.cb_tipoPeriodo.Location = new System.Drawing.Point(571, 154);
            this.cb_tipoPeriodo.Name = "cb_tipoPeriodo";
            this.cb_tipoPeriodo.Size = new System.Drawing.Size(121, 26);
            this.cb_tipoPeriodo.TabIndex = 18;
            // 
            // FInteresSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(747, 425);
            this.Controls.Add(this.cb_tipoPeriodo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ValorFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_interes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tasaInteres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_numeroPeriodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_capInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FInteresSimple";
            this.Text = "FInteresSimple";
            this.Load += new System.EventHandler(this.FInteresSimple_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ValorFinal;
        private System.Windows.Forms.RadioButton rb_Interes;
        private System.Windows.Forms.RadioButton rb_TasaInteres;
        private System.Windows.Forms.RadioButton rb_NumPeriodos;
        private System.Windows.Forms.RadioButton rb_CapitalInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_capInicial;
        private System.Windows.Forms.TextBox txt_numeroPeriodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tasaInteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_interes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ValorFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_perdida;
        private System.Windows.Forms.RadioButton rb_ganancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_tipoPeriodo;
    }
}