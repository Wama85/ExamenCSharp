namespace examenmod_I
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntriangulo = new System.Windows.Forms.Button();
            this.btnrectangulo = new System.Windows.Forms.Button();
            this.paralelogramo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntriangulo
            // 
            this.btntriangulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntriangulo.Image = global::examenmod_I.Properties.Resources.triangulo1;
            this.btntriangulo.Location = new System.Drawing.Point(76, 133);
            this.btntriangulo.Name = "btntriangulo";
            this.btntriangulo.Size = new System.Drawing.Size(174, 112);
            this.btntriangulo.TabIndex = 0;
            this.btntriangulo.Text = "TRIÁNGULO";
            this.btntriangulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btntriangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btntriangulo.UseVisualStyleBackColor = true;
            this.btntriangulo.Click += new System.EventHandler(this.btntriangulo_Click);
            // 
            // btnrectangulo
            // 
            this.btnrectangulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnrectangulo.Image = global::examenmod_I.Properties.Resources.rectangulo1;
            this.btnrectangulo.Location = new System.Drawing.Point(292, 133);
            this.btnrectangulo.Name = "btnrectangulo";
            this.btnrectangulo.Size = new System.Drawing.Size(174, 112);
            this.btnrectangulo.TabIndex = 1;
            this.btnrectangulo.Text = "RECTÁNGULO";
            this.btnrectangulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnrectangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnrectangulo.UseVisualStyleBackColor = true;
            this.btnrectangulo.Click += new System.EventHandler(this.btnrectangulo_Click);
            // 
            // paralelogramo
            // 
            this.paralelogramo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paralelogramo.Image = global::examenmod_I.Properties.Resources.paralelogramo1;
            this.paralelogramo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.paralelogramo.Location = new System.Drawing.Point(492, 133);
            this.paralelogramo.Name = "paralelogramo";
            this.paralelogramo.Size = new System.Drawing.Size(174, 112);
            this.paralelogramo.TabIndex = 2;
            this.paralelogramo.Text = "PARALELOGRAMO";
            this.paralelogramo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.paralelogramo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.paralelogramo.UseVisualStyleBackColor = true;
            this.paralelogramo.Click += new System.EventHandler(this.paralelogramo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(247, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "FIGURAS GEOMÉTRICAS";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paralelogramo);
            this.Controls.Add(this.btnrectangulo);
            this.Controls.Add(this.btntriangulo);
            this.Name = "inicio";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btntriangulo;
        private Button btnrectangulo;
        private Button paralelogramo;
        private Label label1;
    }
}