using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BibliotecaApp.Datos;
using Microsoft.Data.SqlClient;

namespace BibliotecaApp.Presentacion
{
    public partial class FormLibros : Form
    {
        public FormLibros()

        {
            InitializeComponent();

            CargarLibros();

            CargarEditoriales();

            CargarAutores();
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = LibroDatos.ListarLibros();

        }

        private void Buscar()
        {

        }

        private void CargarEditoriales()
        {
            cmbEditorial.DataSource = EditorialDatos.ListarEditoriales();
            cmbEditorial.DisplayMember = "nombre";
            cmbEditorial.ValueMember = "id_editorial";

        }



        private void CargarAutores()
        {
            clbAutores.DataSource = LibroDatos.ListarAutores();

            clbAutores.DisplayMember = "nombre";
            clbAutores.ValueMember = "id_autor";
        }










        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))

            {
                CargarLibros();
            }
            else
            {
                dgvLibros.DataSource = LibroDatos.BuscarLibros(txtBuscar.Text);

            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
               string.IsNullOrWhiteSpace(txtTitulo.Text) ||
               cmbEditorial.SelectedIndex == -1)
            {
                MessageBox.Show("Completa el código, el título y selecciona una editorial.");
                return;
            }

            if (clbAutores.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un autor.");
                return;
            }

            string codigo = txtCodigo.Text.Trim();
            string titulo = txtTitulo.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            DateTime fechaPublicacion = dtpFechaPublicacion.Value;
            string categoria = cmbCategoria.Text;
            int cantidad = (int)nudCantidad.Value;
            int idEditorial = Convert.ToInt32(cmbEditorial.SelectedValue);

            List<int> autores = new List<int>();

            foreach (DataRowView autor in clbAutores.CheckedItems)
            {
                autores.Add(Convert.ToInt32(autor["id_autor"]));
            }


            try
            {
                LibroDatos.RegistrarLibro(codigo, titulo, isbn, fechaPublicacion, categoria, idEditorial, cantidad, autores);

                MessageBox.Show("Libro registrado correctamente.");

                CargarLibros();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Ya existe un libro registrado con ese código.");
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idLibroSeleccionado = 0;
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtISBN.Clear();
            txtBuscar.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbEditorial.SelectedIndex = -1;

            nudCantidad.Value = 0;
            dtpFechaPublicacion.Value = DateTime.Today;

            clbAutores.ClearSelected();
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
            idLibroSeleccionado = Convert.ToInt32(fila.Cells["id_libro"].Value);
            txtCodigo.Text = fila.Cells["codigo_libro"].Value?.ToString() ?? "";
            txtTitulo.Text = fila.Cells["titulo"].Value?.ToString() ?? "";
            txtISBN.Text = fila.Cells["ISBN"].Value?.ToString() ?? "";

            if (fila.Cells["fecha_publicacion"].Value != DBNull.Value)
            {
                dtpFechaPublicacion.Value = Convert.ToDateTime(fila.Cells["fecha_publicacion"].Value);
            }
            cmbCategoria.Text = fila.Cells["categoria"].Value?.ToString() ?? "";
            object? valorEditorial = fila.Cells["id_editorial"].Value;

            if (valorEditorial != null && valorEditorial != DBNull.Value)
            {
                cmbEditorial.SelectedValue = Convert.ToInt32(valorEditorial);
            }
            nudCantidad.Value = Convert.ToDecimal(fila.Cells["cantidad"].Value);

            DataTable autoresLibro = LibroDatos.ListarAutoresPorLibro(idLibroSeleccionado);

            for (int i = 0; i < clbAutores.Items.Count; i++)
            {
                DataRowView autor = (DataRowView)clbAutores.Items[i];

                int idAutor = Convert.ToInt32(autor["id_autor"]);

                bool estaRelacionado = autoresLibro.AsEnumerable()
                    .Any(a => Convert.ToInt32(a["id_autor"]) == idAutor);

                clbAutores.SetItemChecked(i, estaRelacionado);
            }




        }

        private int idLibroSeleccionado = 0;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un libro de la tabla para editarlo.");
                return;
            }
            string codigo = txtCodigo.Text.Trim();
            string titulo = txtTitulo.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            DateTime fechaPublicacion = dtpFechaPublicacion.Value;
            string categoria = cmbCategoria.Text;
            int cantidad = (int)nudCantidad.Value;
            int idEditorial = Convert.ToInt32(cmbEditorial.SelectedValue);
            List<int> autores = new List<int>();

            foreach (DataRowView autor in clbAutores.CheckedItems)
            {
                autores.Add(Convert.ToInt32(autor["id_autor"]));
            }

            if (string.IsNullOrWhiteSpace(codigo) ||
            string.IsNullOrWhiteSpace(titulo) ||
            cmbEditorial.SelectedIndex == -1)
            {
                MessageBox.Show("Completa el código, el título y selecciona una editorial.");
                return;
            }
            if (autores.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un autor.");
                return;
            }
            try
            {
                LibroDatos.EditarLibro(idLibroSeleccionado, codigo, titulo, isbn, fechaPublicacion, categoria, idEditorial, cantidad, autores);
                MessageBox.Show("Libro actualizado correctamente.");
                CargarLibros();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    MessageBox.Show("Ya existe un librocon ese codigo ");
                else
                    MessageBox.Show("Error de base de datos: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("OCURRIO UN ERROR:" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idLibroSeleccionado == 0)
            {
                MessageBox.Show("debes seleccionar un libro de la tabla para eliminarlo.");
                return;

            }

            DialogResult respuesta = MessageBox.Show(
            "¿Estás seguro de eliminar este libro?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                LibroDatos.EliminarLibro(idLibroSeleccionado);

                MessageBox.Show("Libro eliminado correctamente.");

                CargarLibros();

                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message);
            }




        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarLibros();

            MessageBox.Show("Lista de libros actualizada correctamente.");
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


