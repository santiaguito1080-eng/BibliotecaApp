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
            ((System.ComponentModel.ISupportInitialize)dtvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // lblTituloEditoriales
            // 
            lblTituloEditoriales.AutoSize = true;
            lblTituloEditoriales.Location = new Point(411, 24);
            lblTituloEditoriales.Name = "lblTituloEditoriales";
            lblTituloEditoriales.Size = new Size(143, 15);
            lblTituloEditoriales.TabIndex = 0;
            lblTituloEditoriales.Text = "GESTION DE EDITORIALES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(132, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(209, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(132, 126);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(36, 15);
            lblPais.TabIndex = 3;
            lblPais.Text = "PAIS :";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(209, 118);
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
            btnRegistrar.Location = new Point(479, 79);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(85, 30);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(479, 126);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(85, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(620, 83);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(620, 126);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 30);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(479, 184);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 30);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 561);
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
            Controls.Add(lblTituloEditoriales);
            Name = "FormEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro de gestion editoriales";
            ((System.ComponentModel.ISupportInitialize)dtvEditoriales).EndInit();
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
    }
}