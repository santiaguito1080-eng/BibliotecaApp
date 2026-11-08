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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            lblTituloAutores = new Label();
            panel1 = new Panel();
            pnldecoracion = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtvAutores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(200, 123);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE : ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(281, 122);
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
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(197, 154);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 17);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "APELLIDO :";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(281, 151);
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
            lblNacionalidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNacionalidad.Location = new Point(159, 188);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(116, 17);
            lblNacionalidad.TabIndex = 7;
            lblNacionalidad.Text = "NACIONALIDAD :";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(281, 182);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(100, 23);
            txtNacionalidad.TabIndex = 8;
            // 
            // dtvAutores
            // 
            dtvAutores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue;
            dtvAutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvAutores.BackgroundColor = Color.White;
            dtvAutores.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtvAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtvAutores.DefaultCellStyle = dataGridViewCellStyle3;
            dtvAutores.GridColor = Color.Gainsboro;
            dtvAutores.Location = new Point(12, 299);
            dtvAutores.MultiSelect = false;
            dtvAutores.Name = "dtvAutores";
            dtvAutores.ReadOnly = true;
            dtvAutores.RowHeadersVisible = false;
            dtvAutores.RowTemplate.Height = 30;
            dtvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvAutores.Size = new Size(837, 250);
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
            btnRegistrar.BackColor = Color.SkyBlue;
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(281, 263);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 30);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.YellowGreen;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(402, 263);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // ELIMINAR
            // 
            ELIMINAR.BackColor = Color.Salmon;
            ELIMINAR.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            ELIMINAR.FlatAppearance.BorderSize = 0;
            ELIMINAR.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ELIMINAR.FlatStyle = FlatStyle.Flat;
            ELIMINAR.ForeColor = Color.White;
            ELIMINAR.Location = new Point(661, 263);
            ELIMINAR.Name = "ELIMINAR";
            ELIMINAR.Size = new Size(100, 30);
            ELIMINAR.TabIndex = 13;
            ELIMINAR.Text = "ELIMINAR";
            ELIMINAR.UseVisualStyleBackColor = false;
            ELIMINAR.Click += ELIMINAR_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Orange;
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(530, 263);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 30);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblTituloAutores
            // 
            lblTituloAutores.AutoSize = true;
            lblTituloAutores.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAutores.ForeColor = Color.White;
            lblTituloAutores.Location = new Point(303, 24);
            lblTituloAutores.Name = "lblTituloAutores";
            lblTituloAutores.Size = new Size(268, 32);
            lblTituloAutores.TabIndex = 0;
            lblTituloAutores.Text = "GESTION DE AUTORES";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblTituloAutores);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 82);
            panel1.TabIndex = 15;
            // 
            // pnldecoracion
            // 
            pnldecoracion.BackColor = Color.MidnightBlue;
            pnldecoracion.Location = new Point(0, 82);
            pnldecoracion.Name = "pnldecoracion";
            pnldecoracion.Size = new Size(151, 211);
            pnldecoracion.TabIndex = 16;
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 561);
            Controls.Add(pnldecoracion);
            Controls.Add(panel1);
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
            Name = "FormAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTION DE AUTORES";
            ((System.ComponentModel.ISupportInitialize)dtvAutores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
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
        private Label lblTituloAutores;
        private Panel panel1;
        private Panel pnldecoracion;
    }
}