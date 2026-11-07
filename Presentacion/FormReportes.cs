using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Presentacion
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
            ConfigurarReportes();
        }

        private void ConfigurarReportes()
        {
            cmbTipoReporte.Items.Clear();

            cmbTipoReporte.Items.Add("Listado de libros");
            cmbTipoReporte.Items.Add("Listado de autores");
            cmbTipoReporte.Items.Add("Listado de editoriales");
            cmbTipoReporte.Items.Add("Listado de usuarios");
            cmbTipoReporte.Items.Add("Préstamos activos");
            cmbTipoReporte.Items.Add("Préstamos devueltos");
            cmbTipoReporte.Items.Add("Historial de préstamos");

            cmbTipoReporte.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbTipoReporte.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un tipo de reporte.");
                return;
            }

            try
            {
                string tipoReporte = cmbTipoReporte.SelectedItem?.ToString() ?? "";

                dgvReportes.DataSource =
                    ReporteDatos.ConsultarReporte(tipoReporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el reporte: " + ex.Message);
            }
        }
    }
}
