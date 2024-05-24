namespace proyectosql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Prueba = new System.Windows.Forms.Button();
            this.personajes = new System.Windows.Forms.DataGridView();
            this.botoncargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxid = new System.Windows.Forms.TextBox();
            this.Crear = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxraza = new System.Windows.Forms.ComboBox();
            this.Botonbuscar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelHistoria = new System.Windows.Forms.Label();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(540, 340);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(149, 48);
            this.Prueba.TabIndex = 0;
            this.Prueba.Text = "Prueba connexion";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // personajes
            // 
            this.personajes.AllowUserToOrderColumns = true;
            this.personajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personajes.Location = new System.Drawing.Point(394, 9);
            this.personajes.Name = "personajes";
            this.personajes.Size = new System.Drawing.Size(317, 207);
            this.personajes.TabIndex = 1;
            // 
            // botoncargar
            // 
            this.botoncargar.Location = new System.Drawing.Point(540, 249);
            this.botoncargar.Name = "botoncargar";
            this.botoncargar.Size = new System.Drawing.Size(149, 54);
            this.botoncargar.TabIndex = 2;
            this.botoncargar.Text = "cargar_datos";
            this.botoncargar.UseVisualStyleBackColor = true;
            this.botoncargar.Click += new System.EventHandler(this.botoncargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fuerza";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(103, 39);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(103, 6);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(100, 20);
            this.textboxid.TabIndex = 10;
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(15, 280);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 11;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(102, 118);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxraza
            // 
            this.comboBoxraza.FormattingEnabled = true;
            this.comboBoxraza.Location = new System.Drawing.Point(102, 77);
            this.comboBoxraza.Name = "comboBoxraza";
            this.comboBoxraza.Size = new System.Drawing.Size(164, 21);
            this.comboBoxraza.TabIndex = 13;
            this.comboBoxraza.SelectedIndexChanged += new System.EventHandler(this.comboBoxraza_SelectedIndexChanged);
            // 
            // Botonbuscar
            // 
            this.Botonbuscar.Location = new System.Drawing.Point(234, 4);
            this.Botonbuscar.Name = "Botonbuscar";
            this.Botonbuscar.Size = new System.Drawing.Size(101, 23);
            this.Botonbuscar.TabIndex = 14;
            this.Botonbuscar.Text = "Buscar por id";
            this.Botonbuscar.UseVisualStyleBackColor = true;
            this.Botonbuscar.Click += new System.EventHandler(this.Botonbuscar_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(12, 152);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(128, 13);
            this.Fecha.TabIndex = 15;
            this.Fecha.Text = "Fecha y hora de creacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 23, 16, 7, 34, 0);
            // 
            // labelHistoria
            // 
            this.labelHistoria.AutoSize = true;
            this.labelHistoria.Location = new System.Drawing.Point(12, 203);
            this.labelHistoria.Name = "labelHistoria";
            this.labelHistoria.Size = new System.Drawing.Size(63, 13);
            this.labelHistoria.TabIndex = 18;
            this.labelHistoria.Text = "Descripcion";
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.Location = new System.Drawing.Point(85, 218);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(126, 20);
            this.textBoxHistoria.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar por nombre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(147, 280);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 21;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.labelHistoria);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Botonbuscar);
            this.Controls.Add(this.comboBoxraza);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.textboxid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botoncargar);
            this.Controls.Add(this.personajes);
            this.Controls.Add(this.Prueba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.DataGridView personajes;
        private System.Windows.Forms.Button botoncargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBoxraza;
        private System.Windows.Forms.Button Botonbuscar;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelHistoria;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

