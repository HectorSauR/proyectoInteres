
namespace InteresSimple
{
    partial class FSeleccionInteres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSeleccionInteres));
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnCompuesto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimple
            // 
            this.btnSimple.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSimple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSimple.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimple.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimple.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSimple.Location = new System.Drawing.Point(30, 39);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(112, 44);
            this.btnSimple.TabIndex = 0;
            this.btnSimple.Text = "Simple";
            this.btnSimple.UseVisualStyleBackColor = false;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnCompuesto
            // 
            this.btnCompuesto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompuesto.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnCompuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompuesto.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompuesto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompuesto.Location = new System.Drawing.Point(214, 39);
            this.btnCompuesto.Name = "btnCompuesto";
            this.btnCompuesto.Size = new System.Drawing.Size(121, 44);
            this.btnCompuesto.TabIndex = 1;
            this.btnCompuesto.Text = "Compuesto";
            this.btnCompuesto.UseVisualStyleBackColor = false;
            this.btnCompuesto.Click += new System.EventHandler(this.btnCompuesto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnCompuesto);
            this.groupBox1.Controls.Add(this.btnSimple);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interes";
            // 
            // FSeleccionInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FSeleccionInteres";
            this.Text = "FSeleccionInteres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FSeleccionInteres_FormClosed);
            this.Load += new System.EventHandler(this.FSeleccionInteres_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnCompuesto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}