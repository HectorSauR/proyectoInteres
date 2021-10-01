
namespace InteresSimple
{
    partial class FResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FResultado));
            this.btn_calcularOtro = new System.Windows.Forms.Button();
            this.lbl_inversion = new System.Windows.Forms.Label();
            this.lbl_ganada = new System.Windows.Forms.Label();
            this.lbl_periodoFinal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nombreCalculo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calcularOtro
            // 
            this.btn_calcularOtro.Location = new System.Drawing.Point(466, 576);
            this.btn_calcularOtro.Name = "btn_calcularOtro";
            this.btn_calcularOtro.Size = new System.Drawing.Size(106, 33);
            this.btn_calcularOtro.TabIndex = 0;
            this.btn_calcularOtro.Text = "Calcular otro";
            this.btn_calcularOtro.UseVisualStyleBackColor = true;
            // 
            // lbl_inversion
            // 
            this.lbl_inversion.AutoSize = true;
            this.lbl_inversion.BackColor = System.Drawing.Color.White;
            this.lbl_inversion.Location = new System.Drawing.Point(103, 521);
            this.lbl_inversion.Name = "lbl_inversion";
            this.lbl_inversion.Size = new System.Drawing.Size(15, 18);
            this.lbl_inversion.TabIndex = 2;
            this.lbl_inversion.Text = "0";
            // 
            // lbl_ganada
            // 
            this.lbl_ganada.AutoSize = true;
            this.lbl_ganada.BackColor = System.Drawing.Color.White;
            this.lbl_ganada.Location = new System.Drawing.Point(505, 367);
            this.lbl_ganada.Name = "lbl_ganada";
            this.lbl_ganada.Size = new System.Drawing.Size(15, 18);
            this.lbl_ganada.TabIndex = 3;
            this.lbl_ganada.Text = "0";
            this.lbl_ganada.Click += new System.EventHandler(this.lbl_ganada_Click);
            // 
            // lbl_periodoFinal
            // 
            this.lbl_periodoFinal.AutoSize = true;
            this.lbl_periodoFinal.BackColor = System.Drawing.Color.White;
            this.lbl_periodoFinal.Location = new System.Drawing.Point(505, 444);
            this.lbl_periodoFinal.Name = "lbl_periodoFinal";
            this.lbl_periodoFinal.Size = new System.Drawing.Size(15, 18);
            this.lbl_periodoFinal.TabIndex = 4;
            this.lbl_periodoFinal.Text = "0";
            this.lbl_periodoFinal.Click += new System.EventHandler(this.lbl_periodoFinal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resultado";
            // 
            // lbl_nombreCalculo
            // 
            this.lbl_nombreCalculo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombreCalculo.AutoSize = true;
            this.lbl_nombreCalculo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreCalculo.Location = new System.Drawing.Point(54, 56);
            this.lbl_nombreCalculo.Name = "lbl_nombreCalculo";
            this.lbl_nombreCalculo.Size = new System.Drawing.Size(249, 26);
            this.lbl_nombreCalculo.TabIndex = 0;
            this.lbl_nombreCalculo.Text = "Metodo de calcular: $1500";
            this.lbl_nombreCalculo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_nombreCalculo);
            this.groupBox1.Location = new System.Drawing.Point(119, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 128);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // FResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_periodoFinal);
            this.Controls.Add(this.lbl_ganada);
            this.Controls.Add(this.lbl_inversion);
            this.Controls.Add(this.btn_calcularOtro);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FResultado";
            this.Text = "FResultado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcularOtro;
        private System.Windows.Forms.Label lbl_inversion;
        private System.Windows.Forms.Label lbl_ganada;
        private System.Windows.Forms.Label lbl_periodoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nombreCalculo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}