namespace BibliotecaApp.Presentacion
{
    partial class FormEditoriales
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
            lblTituloEditoriales = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPais = new Label();
            txtPais = new TextBox();
            dtvEditoriales = new DataGridView();
            btnRegistrar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtvEditoriales).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloEditoriales
            // 
            lblTituloEditoriales.AutoSize = true;
            lblTituloEditoriales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEditoriales.ForeColor = Color.White;
            lblTituloEditoriales.Location = new Point(324, 9);
            lblTituloEditoriales.Name = "lblTituloEditoriales";
            lblTituloEditoriales.Size = new Size(310, 32);
            lblTituloEditoriales.TabIndex = 0;
            lblTituloEditoriales.Text = "GESTION DE EDITORIALES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(267, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(344, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPais.Location = new Point(295, 124);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(43, 17);
            lblPais.TabIndex = 3;
            lblPais.Text = "PAIS :";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(344, 118);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(100, 23);
            txtPais.TabIndex = 4;
            // 
            // dtvEditoriales
            // 
            dtvEditoriales.AllowUserToAddRows = false;
            dtvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvEditoriales.Location = new Point(12, 299);
            dtvEditoriales.MultiSelect = false;
            dtvEditoriales.Name = "dtvEditoriales";
            dtvEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvEditoriales.Size = new Size(858, 250);
            dtvEditoriales.TabIndex = 5;
            dtvEditoriales.CellClick += dtvEditoriales_CellClick;
            dtvEditoriales.CellContentClick += dtvEditoriales_CellContentClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.SkyBlue;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(388, 263);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(85, 30);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.YellowGreen;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(479, 263);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "EDITAR";
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
            btnEliminar.Location = new Point(661, 263);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.DarkOrange;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.White;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(570, 263);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 30);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(479, 77);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 30);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 293);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(lblTituloEditoriales);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 60);
            panel2.TabIndex = 12;
            // 
            // FormEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtvEditoriales);
            Controls.Add(txtPais);
            Controls.Add(lblPais);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FormEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro de gestion editoriales";
            ((System.ComponentModel.ISupportInitialize)dtvEditoriales).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloEditoriales;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPais;
        private TextBox txtPais;
        private DataGridView dtvEditoriales;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private Panel panel1;
        private Panel panel2;
    }
}