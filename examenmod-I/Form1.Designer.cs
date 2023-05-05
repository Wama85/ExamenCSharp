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
            btntriangulo = new Button();
            btnrectangulo = new Button();
            paralelogramo = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btntriangulo
            // 
            btntriangulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntriangulo.Image = Properties.Resources.triangulo1;
            btntriangulo.Location = new Point(76, 133);
            btntriangulo.Name = "btntriangulo";
            btntriangulo.Size = new Size(174, 112);
            btntriangulo.TabIndex = 0;
            btntriangulo.Text = "TRIÁNGULO";
            btntriangulo.TextAlign = ContentAlignment.TopCenter;
            btntriangulo.TextImageRelation = TextImageRelation.TextAboveImage;
            btntriangulo.UseVisualStyleBackColor = true;
            btntriangulo.Click += btntriangulo_Click;
            // 
            // btnrectangulo
            // 
            btnrectangulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnrectangulo.Image = Properties.Resources.rectangulo1;
            btnrectangulo.Location = new Point(292, 133);
            btnrectangulo.Name = "btnrectangulo";
            btnrectangulo.Size = new Size(174, 112);
            btnrectangulo.TabIndex = 1;
            btnrectangulo.Text = "RECTÁNGULO";
            btnrectangulo.TextAlign = ContentAlignment.TopCenter;
            btnrectangulo.TextImageRelation = TextImageRelation.TextAboveImage;
            btnrectangulo.UseVisualStyleBackColor = true;
            btnrectangulo.Click += btnrectangulo_Click;
            // 
            // paralelogramo
            // 
            paralelogramo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            paralelogramo.Image = Properties.Resources.paralelogramo1;
            paralelogramo.ImageAlign = ContentAlignment.BottomCenter;
            paralelogramo.Location = new Point(492, 133);
            paralelogramo.Name = "paralelogramo";
            paralelogramo.Size = new Size(174, 112);
            paralelogramo.TabIndex = 2;
            paralelogramo.Text = "PARALELOGRAMO";
            paralelogramo.TextAlign = ContentAlignment.TopCenter;
            paralelogramo.TextImageRelation = TextImageRelation.TextAboveImage;
            paralelogramo.UseVisualStyleBackColor = true;
            paralelogramo.Click += paralelogramo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(247, 49);
            label1.Name = "label1";
            label1.Size = new Size(238, 28);
            label1.TabIndex = 3;
            label1.Text = "FIGURAS GEOMÉTRICAS";
            // 
            // button1
            // 
            button1.Location = new Point(283, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 383);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(paralelogramo);
            Controls.Add(btnrectangulo);
            Controls.Add(btntriangulo);
            Name = "inicio";
            Text = "INICIO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btntriangulo;
        private Button btnrectangulo;
        private Button paralelogramo;
        private Label label1;
        private Button button1;
    }
}