namespace BibliotecaApp.Presentacion
{
    partial class FormAutores
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
            lblTituloAutores = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            lblNacionalidad = new Label();
            txtNacionalidad = new TextBox();
            dtvAutores = new DataGridView();
            button1 = new Button();
            btnRegistrar = new Button();
            btnEditar = new Button();
            ELIMINAR = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvAutores).BeginInit();
            SuspendLayout();
            // 
            // lblTituloAutores
            // 
            lblTituloAutores.AutoSize = true;
            lblTituloAutores.Location = new Point(61, 38);
            lblTituloAutores.Name = "lblTituloAutores";
            lblTituloAutores.Size = new Size(125, 15);
            lblTituloAutores.TabIndex = 0;
            lblTituloAutores.Text = "GESTION DE AUTORES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(61, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE : ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(60, 132);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "APELLIDO :";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(132, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(60, 173);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(100, 15);
            lblNacionalidad.TabIndex = 7;
            lblNacionalidad.Text = "NACIONALIDAD :";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(166, 170);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(100, 23);
            txtNacionalidad.TabIndex = 8;
            // 
            // dtvAutores
            // 
            dtvAutores.AllowUserToAddRows = false;
            dtvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvAutores.Location = new Point(36, 227);
            dtvAutores.MultiSelect = false;
            dtvAutores.Name = "dtvAutores";
            dtvAutores.ReadOnly = true;
            dtvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvAutores.Size = new Size(919, 250);
            dtvAutores.TabIndex = 9;
            dtvAutores.CellClick += dtvAutores_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(588, 70);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 30);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(588, 124);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.Location = new Point(754, 70);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(100, 30);
            ELIMINAR.TabIndex = 13;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = true;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(754, 124);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 30);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(btnActualizar);
            Controls.Add(ELIMINAR);
            Controls.Add(btnEditar);
            Controls.Add(btnRegistrar);
            Controls.Add(button1);
            Controls.Add(dtvAutores);
            Controls.Add(txtNacionalidad);
            Controls.Add(lblNacionalidad);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloAutores);
            Name = "FormAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTION DE AUTORES";
            ((System.ComponentModel.ISupportInitialize)dtvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTituloAutores;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label1;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label label2;
        private Label lblNacionalidad;
        private TextBox txtNacionalidad;
        private DataGridView dtvAutores;
        private Button button1;
        private Button btnRegistrar;
        private Button btnEditar;
        private Button ELIMINAR;
        private Button btnActualizar;
    }
}