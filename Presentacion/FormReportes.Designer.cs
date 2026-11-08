namespace BibliotecaApp.Presentacion
{
    partial class FormReportes
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
            lblTitulo = new Label();
            cmbTipoReporte = new ComboBox();
            btnConsultar = new Button();
            btnCerrar = new Button();
            dgvReportes = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(105, 82);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(150, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REPORTES DE BIBLIOTECA :";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(261, 79);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(121, 23);
            cmbTipoReporte.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(403, 82);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(107, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(403, 122);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(107, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(12, 228);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(613, 346);
            dgvReportes.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 62);
            panel1.TabIndex = 5;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 586);
            Controls.Add(panel1);
            Controls.Add(dgvReportes);
            Controls.Add(btnCerrar);
            Controls.Add(btnConsultar);
            Controls.Add(cmbTipoReporte);
            Controls.Add(lblTitulo);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbTipoReporte;
        private Button btnConsultar;
        private Button btnCerrar;
        private DataGridView dgvReportes;
        private Panel panel1;
    }
}