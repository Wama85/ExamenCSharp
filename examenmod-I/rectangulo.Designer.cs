namespace examenmod_I
{
    partial class rectangulo
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
            this.btnfigura = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pxrectangulo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btngenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtladob = new System.Windows.Forms.TextBox();
            this.txtladoa = new System.Windows.Forms.TextBox();
            this.lblperimetro = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtpila = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pxrectangulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfigura
            // 
            this.btnfigura.Image = global::examenmod_I.Properties.Resources.figura1;
            this.btnfigura.Location = new System.Drawing.Point(18, 196);
            this.btnfigura.Name = "btnfigura";
            this.btnfigura.Size = new System.Drawing.Size(159, 119);
            this.btnfigura.TabIndex = 2;
            this.btnfigura.Text = "INICIO";
            this.btnfigura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfigura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnfigura.UseVisualStyleBackColor = true;
            this.btnfigura.Click += new System.EventHandler(this.btnfigura_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::examenmod_I.Properties.Resources.nologin;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(268, 196);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(132, 119);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pxrectangulo
            // 
            this.pxrectangulo.BackColor = System.Drawing.Color.Red;
            this.pxrectangulo.Location = new System.Drawing.Point(454, 23);
            this.pxrectangulo.Name = "pxrectangulo";
            this.pxrectangulo.Size = new System.Drawing.Size(200, 64);
            this.pxrectangulo.TabIndex = 7;
            this.pxrectangulo.TabStop = false;
            this.pxrectangulo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnmostrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btngenerar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtladob);
            this.groupBox1.Controls.Add(this.txtladoa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(271, 83);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(95, 41);
            this.btnmostrar.TabIndex = 10;
            this.btnmostrar.Text = "MOSTRAR PILA";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "DATOS LADO B";
            // 
            // btngenerar
            // 
            this.btngenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btngenerar.Location = new System.Drawing.Point(271, 23);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(95, 47);
            this.btngenerar.TabIndex = 0;
            this.btngenerar.Text = "GENERAR";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "DATOS LADO A";
            // 
            // txtladob
            // 
            this.txtladob.Location = new System.Drawing.Point(6, 118);
            this.txtladob.Name = "txtladob";
            this.txtladob.Size = new System.Drawing.Size(104, 23);
            this.txtladob.TabIndex = 2;
            // 
            // txtladoa
            // 
            this.txtladoa.Location = new System.Drawing.Point(6, 52);
            this.txtladoa.Name = "txtladoa";
            this.txtladoa.Size = new System.Drawing.Size(104, 23);
            this.txtladoa.TabIndex = 1;
            // 
            // lblperimetro
            // 
            this.lblperimetro.AutoSize = true;
            this.lblperimetro.Location = new System.Drawing.Point(517, 108);
            this.lblperimetro.Name = "lblperimetro";
            this.lblperimetro.Size = new System.Drawing.Size(92, 15);
            this.lblperimetro.TabIndex = 9;
            this.lblperimetro.Text = "Datos perímetro";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.ForeColor = System.Drawing.Color.Black;
            this.lblarea.Location = new System.Drawing.Point(504, 51);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(62, 15);
            this.lblarea.TabIndex = 8;
            this.lblarea.Text = "Datos área";
            // 
            // txtpila
            // 
            this.txtpila.AutoSize = true;
            this.txtpila.Location = new System.Drawing.Point(6, 19);
            this.txtpila.Name = "txtpila";
            this.txtpila.Size = new System.Drawing.Size(38, 15);
            this.txtpila.TabIndex = 9;
            this.txtpila.Text = "LISTA ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpila);
            this.groupBox2.Location = new System.Drawing.Point(467, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 241);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE PILA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "PERÍMETRO";
            // 
            // rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pxrectangulo);
            this.Controls.Add(this.lblperimetro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnfigura);
            this.Name = "rectangulo";
            this.Text = "rectangulo";
            ((System.ComponentModel.ISupportInitialize)(this.pxrectangulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnfigura;
        private Button btnsalir;
        private PictureBox pxrectangulo;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtladob;
        private TextBox txtladoa;
        private Button btngenerar;
        private Label lblarea;
        private Label lblperimetro;
        private Button btnmostrar;
        private Label txtpila;
        private GroupBox groupBox2;
        private Label label4;
    }
}