using BibliotecaApp.Negocio;
using BibliotecaApp.Datos;
using BibliotecaApp.Presentacion;

namespace BibliotecaApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Titulolbl_Click(object sender, EventArgs e)
        {

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos formulario = new FormPrestamos();
            formulario.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes formulario = new FormReportes();
            formulario.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FormAutores formulario = new FormAutores();
            formulario.ShowDialog();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibros Formulario = new FormLibros();
            Formulario.ShowDialog();

        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            FormEditoriales formulario = new FormEditoriales();
            formulario.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formulario = new FormUsuarios();
            formulario.ShowDialog();

        }
    }
}

