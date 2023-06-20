namespace Examen_Final
{
    public partial class Form1 : Form
    {
        Stack<Poligono> pilaPoligonos;
        public Form1()
        {
            InitializeComponent();
            pilaPoligonos = new Stack<Poligono>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double basePoligono = Convert.ToDouble(txtBase.Text);
            double alturaPoligono = Convert.ToDouble(txtAltura.Text);
            Poligono poligono = new Triangulo(nombre, basePoligono, alturaPoligono); ;
            pilaPoligonos.Push(poligono);
        }

        private void btnMostrarPila_Click(object sender, EventArgs e)
        {
            lblPila.Text = "";
            foreach (Poligono poligono in pilaPoligonos)
            {
                lblPila.Text += poligono.ToString() + "\n";
            }
        }

        private void btnIngresarRect_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double basePoligono = Convert.ToDouble(txtBase.Text);
            double alturaPoligono = Convert.ToDouble(txtAltura.Text);
            Poligono poligono = new Rectangulo(nombre, basePoligono, alturaPoligono); ;
            pilaPoligonos.Push(poligono);
        }

        private void btnMostrarPilaRect_Click(object sender, EventArgs e)
        {
            lblPilaRect.Text = "";
            foreach (Poligono poligono in pilaPoligonos)
            {
                lblPila.Text += poligono.ToString() + "\n";
            }
        }

        private void btnIngresarParal_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double basePoligono = Convert.ToDouble(txtBase.Text);
            double alturaPoligono = Convert.ToDouble(txtAltura.Text);
            Poligono poligono = new Paralelogramo(nombre, basePoligono, alturaPoligono); ;
            pilaPoligonos.Push(poligono);
        }

        private void btnMostrarPilaParal_Click(object sender, EventArgs e)
        {
            lblPilaParal.Text = "";
            foreach (Poligono poligono in pilaPoligonos)
            {
                lblPila.Text += poligono.ToString() + "\n";
            }
        }
    }
}