using ecuaciones.Clases;

namespace ecuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void resolverEcuacion_Click(object sender, EventArgs e)
		{
			if (double.TryParse(txtA.Text, out double a) &&
				double.TryParse(txtB.Text, out double b) &&
				double.TryParse(txtC.Text, out double c)){

				var ecuacion = new EcuacionCuadratica();
				var calculador = new CalculadorCuadratico(ecuacion);
				var (x1, x2, message) = calculador.Calcular(a, b, c);

				MessageBox.Show(message, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("Por favor ingresa valores v�lidos para a, b y c.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

    }
}
