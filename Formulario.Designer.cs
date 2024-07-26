namespace GestorDeContraseñas
{
    partial class Formulario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMinusculas = new System.Windows.Forms.CheckBox();
            this.checkBoxMayusculas = new System.Windows.Forms.CheckBox();
            this.checkBoxNumeros = new System.Windows.Forms.CheckBox();
            this.checkBoxSimbolos = new System.Windows.Forms.CheckBox();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContraseñaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.labelGithub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor de contraseñas v1.1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(20, 82);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(417, 20);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(18, 36);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(370, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(395, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBoxMinusculas
            // 
            this.checkBoxMinusculas.AutoSize = true;
            this.checkBoxMinusculas.Location = new System.Drawing.Point(21, 141);
            this.checkBoxMinusculas.Name = "checkBoxMinusculas";
            this.checkBoxMinusculas.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMinusculas.TabIndex = 4;
            this.checkBoxMinusculas.Text = "Minúsculas";
            this.checkBoxMinusculas.UseVisualStyleBackColor = true;
            // 
            // checkBoxMayusculas
            // 
            this.checkBoxMayusculas.AutoSize = true;
            this.checkBoxMayusculas.Location = new System.Drawing.Point(104, 141);
            this.checkBoxMayusculas.Name = "checkBoxMayusculas";
            this.checkBoxMayusculas.Size = new System.Drawing.Size(82, 17);
            this.checkBoxMayusculas.TabIndex = 5;
            this.checkBoxMayusculas.Text = "Mayúsculas";
            this.checkBoxMayusculas.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumeros
            // 
            this.checkBoxNumeros.AutoSize = true;
            this.checkBoxNumeros.Location = new System.Drawing.Point(194, 141);
            this.checkBoxNumeros.Name = "checkBoxNumeros";
            this.checkBoxNumeros.Size = new System.Drawing.Size(68, 17);
            this.checkBoxNumeros.TabIndex = 6;
            this.checkBoxNumeros.Text = "Números";
            this.checkBoxNumeros.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimbolos
            // 
            this.checkBoxSimbolos.AutoSize = true;
            this.checkBoxSimbolos.Location = new System.Drawing.Point(268, 141);
            this.checkBoxSimbolos.Name = "checkBoxSimbolos";
            this.checkBoxSimbolos.Size = new System.Drawing.Size(70, 17);
            this.checkBoxSimbolos.TabIndex = 7;
            this.checkBoxSimbolos.Text = "Símbolos";
            this.checkBoxSimbolos.UseVisualStyleBackColor = true;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(19, 110);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerar.TabIndex = 8;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Location = new System.Drawing.Point(100, 110);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(75, 23);
            this.buttonCopiar.TabIndex = 9;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(181, 110);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAnadir.TabIndex = 10;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContraseñaColumn,
            this.TagColumn});
            this.dataGridView1.Location = new System.Drawing.Point(19, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // ContraseñaColumn
            // 
            this.ContraseñaColumn.HeaderText = "Contraseña";
            this.ContraseñaColumn.Name = "ContraseñaColumn";
            this.ContraseñaColumn.ReadOnly = true;
            // 
            // TagColumn
            // 
            this.TagColumn.HeaderText = "Tag";
            this.TagColumn.Name = "TagColumn";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(366, 173);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(77, 39);
            this.buttonMostrar.TabIndex = 12;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // labelGithub
            // 
            this.labelGithub.AutoSize = true;
            this.labelGithub.Location = new System.Drawing.Point(18, 325);
            this.labelGithub.Name = "labelGithub";
            this.labelGithub.Size = new System.Drawing.Size(90, 13);
            this.labelGithub.TabIndex = 13;
            this.labelGithub.Text = "github.com/acf0x";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(461, 346);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelGithub);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonAnadir);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.checkBoxSimbolos);
            this.Controls.Add(this.checkBoxNumeros);
            this.Controls.Add(this.checkBoxMayusculas);
            this.Controls.Add(this.checkBoxMinusculas);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Gestor de contraseñas v1.1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxMinusculas;
        private System.Windows.Forms.CheckBox checkBoxMayusculas;
        private System.Windows.Forms.CheckBox checkBoxNumeros;
        private System.Windows.Forms.CheckBox checkBoxSimbolos;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Label labelGithub;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContraseñaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagColumn;
    }
}
