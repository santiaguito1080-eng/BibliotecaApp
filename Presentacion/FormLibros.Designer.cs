namespace BibliotecaApp.Presentacion
{
    partial class FormLibros
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
            lblTituloLibros = new Label();
            dgvLibros = new DataGridView();
            BtnRegistrar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblFechaDePublicacion = new Label();
            dtpFechaPublicacion = new DateTimePicker();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblEditorial = new Label();
            cmbEditorial = new ComboBox();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            clbAutores = new CheckedListBox();
            lblAutores = new Label();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            lblDisponibilidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTituloLibros
            // 
            lblTituloLibros.AutoSize = true;
            lblTituloLibros.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTituloLibros.Location = new Point(438, 26);
            lblTituloLibros.Name = "lblTituloLibros";
            lblTituloLibros.Size = new Size(115, 13);
            lblTituloLibros.TabIndex = 0;
            lblTituloLibros.Text = "GESTION DE LIBROS";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(12, 358);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.Size = new Size(1031, 150);
            dgvLibros.TabIndex = 1;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(72, 514);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(120, 35);
            BtnRegistrar.TabIndex = 2;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(228, 514);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(529, 514);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(384, 514);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 35);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(61, 60);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(101, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Codigo del Libro :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(168, 57);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 23);
            txtCodigo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(118, 88);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(44, 15);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Titulo :";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(168, 88);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(250, 23);
            txtTitulo.TabIndex = 9;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(124, 121);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(38, 15);
            lblISBN.TabIndex = 10;
            lblISBN.Text = "ISBN :";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(168, 121);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(180, 23);
            txtISBN.TabIndex = 11;
            // 
            // lblFechaDePublicacion
            // 
            lblFechaDePublicacion.AutoSize = true;
            lblFechaDePublicacion.Location = new Point(37, 153);
            lblFechaDePublicacion.Name = "lblFechaDePublicacion";
            lblFechaDePublicacion.Size = new Size(125, 15);
            lblFechaDePublicacion.TabIndex = 12;
            lblFechaDePublicacion.Text = "Fecha de publicacion :";
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.Format = DateTimePickerFormat.Short;
            dtpFechaPublicacion.Location = new Point(168, 153);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.Size = new Size(200, 23);
            dtpFechaPublicacion.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(98, 181);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(168, 182);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(180, 23);
            cmbCategoria.TabIndex = 16;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(106, 210);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(56, 15);
            lblEditorial.TabIndex = 17;
            lblEditorial.Text = "Editorial :";
            // 
            // cmbEditorial
            // 
            cmbEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(168, 211);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(180, 23);
            cmbEditorial.TabIndex = 18;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(72, 239);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 15);
            lblCantidad.TabIndex = 19;
            lblCantidad.Text = "Cantidad Total :";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(168, 240);
            nudCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 20;
            // 
            // clbAutores
            // 
            clbAutores.CheckOnClick = true;
            clbAutores.FormattingEnabled = true;
            clbAutores.Location = new Point(756, 88);
            clbAutores.Name = "clbAutores";
            clbAutores.Size = new Size(200, 76);
            clbAutores.TabIndex = 21;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.Location = new Point(756, 57);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(54, 15);
            lblAutores.TabIndex = 22;
            lblAutores.Text = "Autores :";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(72, 329);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 23;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(674, 514);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(72, 270);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(89, 15);
            lblDisponibilidad.TabIndex = 25;
            lblDisponibilidad.Text = "Disponibilidad :";
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1055, 561);
            Controls.Add(lblDisponibilidad);
            Controls.Add(btnLimpiar);
            Controls.Add(txtBuscar);
            Controls.Add(lblAutores);
            Controls.Add(clbAutores);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(cmbEditorial);
            Controls.Add(lblEditorial);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(dtpFechaPublicacion);
            Controls.Add(lblFechaDePublicacion);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(BtnRegistrar);
            Controls.Add(dgvLibros);
            Controls.Add(lblTituloLibros);
            Name = "FormLibros";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLibros;
        private DataGridView dgvLibros;
        private Button BtnRegistrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblFechaDePublicacion;
        private DateTimePicker dtpFechaPublicacion;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblEditorial;
        private ComboBox cmbEditorial;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private CheckedListBox clbAutores;
        private Label lblAutores;
        private TextBox txtBuscar;
        private Button btnLimpiar;
        private Label lblDisponibilidad;
    }
}