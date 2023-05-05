namespace examenmod_I
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            triangulo ventanatriangulo = new triangulo();
            ventanatriangulo.Show();
            this.Hide();
        }

        private void btnrectangulo_Click(object sender, EventArgs e)
        {
            rectangulo ventanarectangulo = new rectangulo();
            ventanarectangulo.Show();
            this.Hide();
        }

        private void paralelogramo_Click(object sender, EventArgs e)
        {
            paralelogramo ventanaparalelogramo = new paralelogramo();
            ventanaparalelogramo.Show();
            this.Hide();
        }
    }
}