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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblBuscador = new Label();
            lbldescripcion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloLibros
            // 
            lblTituloLibros.AutoSize = true;
            lblTituloLibros.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloLibros.ForeColor = SystemColors.ButtonFace;
            lblTituloLibros.Location = new Point(456, 18);
            lblTituloLibros.Name = "lblTituloLibros";
            lblTituloLibros.Size = new Size(252, 32);
            lblTituloLibros.TabIndex = 0;
            lblTituloLibros.Text = "GESTION DE LIBROS";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.SelectionBackColor = Color.AliceBlue;
            dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle12;
            dgvLibros.GridColor = Color.Gainsboro;
            dgvLibros.Location = new Point(12, 358);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.RowTemplate.Height = 30;
            dgvLibros.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(1129, 191);
            dgvLibros.TabIndex = 1;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.SkyBlue;
            BtnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            BtnRegistrar.FlatAppearance.BorderSize = 0;
            BtnRegistrar.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            BtnRegistrar.FlatStyle = FlatStyle.Flat;
            BtnRegistrar.ForeColor = Color.White;
            BtnRegistrar.Location = new Point(624, 317);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(120, 35);
            BtnRegistrar.TabIndex = 2;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.YellowGreen;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(750, 317);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Salmon;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1002, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightSeaGreen;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(876, 317);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 35);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(217, 80);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(119, 17);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Codigo del Libro :";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(342, 79);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 23);
            txtCodigo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(283, 111);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(53, 17);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Titulo :";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(342, 108);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(250, 23);
            txtTitulo.TabIndex = 9;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(291, 140);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(45, 17);
            lblISBN.TabIndex = 10;
            lblISBN.Text = "ISBN :";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(342, 137);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(180, 23);
            txtISBN.TabIndex = 11;
            // 
            // lblFechaDePublicacion
            // 
            lblFechaDePublicacion.AutoSize = true;
            lblFechaDePublicacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDePublicacion.Location = new Point(191, 170);
            lblFechaDePublicacion.Name = "lblFechaDePublicacion";
            lblFechaDePublicacion.Size = new Size(145, 17);
            lblFechaDePublicacion.TabIndex = 12;
            lblFechaDePublicacion.Text = "Fecha de publicacion :";
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.Format = DateTimePickerFormat.Short;
            dtpFechaPublicacion.Location = new Point(342, 166);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.Size = new Size(200, 23);
            dtpFechaPublicacion.TabIndex = 13;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(261, 198);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(75, 17);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoria :";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(342, 195);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(180, 23);
            cmbCategoria.TabIndex = 16;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(268, 225);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(68, 17);
            lblEditorial.TabIndex = 17;
            lblEditorial.Text = "Editorial :";
            // 
            // cmbEditorial
            // 
            cmbEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(342, 224);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(180, 23);
            cmbEditorial.TabIndex = 18;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(230, 253);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(106, 17);
            lblCantidad.TabIndex = 19;
            lblCantidad.Text = "Cantidad Total :";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(342, 253);
            nudCantidad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 20;
            // 
            // clbAutores
            // 
            clbAutores.CheckOnClick = true;
            clbAutores.FormattingEnabled = true;
            clbAutores.Location = new Point(740, 79);
            clbAutores.Name = "clbAutores";
            clbAutores.Size = new Size(206, 112);
            clbAutores.TabIndex = 21;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutores.Location = new Point(670, 82);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(64, 17);
            lblAutores.TabIndex = 22;
            lblAutores.Text = "Autores :";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(342, 329);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 23;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(740, 217);
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
            lblDisponibilidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisponibilidad.Location = new Point(230, 280);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(107, 17);
            lblDisponibilidad.TabIndex = 25;
            lblDisponibilidad.Text = "Disponibilidad :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(lblTituloLibros);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 65);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbldescripcion);
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 291);
            panel2.TabIndex = 27;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(264, 330);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(72, 17);
            lblBuscador.TabIndex = 28;
            lblBuscador.Text = "Buscador :";
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.BackColor = Color.Transparent;
            lbldescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescripcion.ForeColor = Color.White;
            lbldescripcion.Location = new Point(12, 28);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(179, 15);
            lbldescripcion.TabIndex = 29;
            lbldescripcion.Text = "Desde aqui puedes registrar un";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 29;
            label1.Text = "nuevo libro completando los ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 29;
            label2.Text = "campos solicitados.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 29;
            label3.Text = "Tambien puedes editar sus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(173, 15);
            label4.TabIndex = 29;
            label4.Text = "datos, seleccionando la fila del";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(141, 15);
            label5.TabIndex = 29;
            label5.Text = "libro y asi mismo puedes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 190);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 29;
            label6.Text = "eliminarlo.";
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1153, 561);
            Controls.Add(btnEditar);
            Controls.Add(lblBuscador);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            Controls.Add(BtnRegistrar);
            Controls.Add(dgvLibros);
            Name = "FormLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTION DE LIBROS";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private Label lblBuscador;
        private Label label1;
        private Label lbldescripcion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}