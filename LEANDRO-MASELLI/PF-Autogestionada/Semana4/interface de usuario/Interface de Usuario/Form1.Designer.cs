namespace RegistroPostulantesForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_nombre = new TextBox();
            textBox_apellido = new TextBox();
            label_Nombre = new Label();
            label_Apellido = new Label();
            btn_Ingresar = new Button();
            btn_Limpiar = new Button();
            comboBox_tipo = new ComboBox();
            label_Dni = new Label();
            label_Tipo = new Label();
            label_Num = new Label();
            textBox_numeroDocumento = new TextBox();
            dataGridView1 = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            tipoDocumento = new DataGridViewTextBoxColumn();
            numeroDocumento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(114, 66);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(150, 31);
            textBox_nombre.TabIndex = 0;
            // 
            // textBox_apellido
            // 
            textBox_apellido.Location = new Point(114, 124);
            textBox_apellido.Name = "textBox_apellido";
            textBox_apellido.Size = new Size(150, 31);
            textBox_apellido.TabIndex = 1;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Location = new Point(25, 66);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(78, 25);
            label_Nombre.TabIndex = 2;
            label_Nombre.Text = "Nombre";
            // 
            // label_Apellido
            // 
            label_Apellido.AccessibleRole = AccessibleRole.None;
            label_Apellido.AutoSize = true;
            label_Apellido.Location = new Point(25, 124);
            label_Apellido.Name = "label_Apellido";
            label_Apellido.Size = new Size(78, 25);
            label_Apellido.TabIndex = 3;
            label_Apellido.Text = "Apellido";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(138, 199);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(112, 34);
            btn_Ingresar.TabIndex = 4;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(352, 199);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(112, 34);
            btn_Limpiar.TabIndex = 5;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Items.AddRange(new object[] { "Seleccione", "DNI", "PASAPORTE", "EXTRANJERO" });
            comboBox_tipo.Location = new Point(380, 66);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(150, 33);
            comboBox_tipo.TabIndex = 6;
            comboBox_tipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox_tipo.SelectedIndex = 0;
            // 
            // label_Dni
            // 
            label_Dni.AutoSize = true;
            label_Dni.Location = new Point(305, 33);
            label_Dni.Name = "label_Dni";
            label_Dni.Size = new Size(106, 25);
            label_Dni.TabIndex = 7;
            label_Dni.Text = "Documento";
            label_Dni.Click += label_Dni_Click;
            // 
            // label_Tipo
            // 
            label_Tipo.AutoSize = true;
            label_Tipo.Location = new Point(305, 66);
            label_Tipo.Name = "label_Tipo";
            label_Tipo.Size = new Size(47, 25);
            label_Tipo.TabIndex = 8;
            label_Tipo.Text = "Tipo";
            label_Tipo.Click += label_Tipo_Click;
            // 
            // label_Num
            // 
            label_Num.AutoSize = true;
            label_Num.Location = new Point(305, 119);
            label_Num.Name = "label_Num";
            label_Num.Size = new Size(51, 25);
            label_Num.TabIndex = 9;
            label_Num.Text = "Num";
            label_Num.Click += label_Num_Click;
            // 
            // textBox_numeroDocumento
            // 
            textBox_numeroDocumento.Location = new Point(380, 119);
            textBox_numeroDocumento.Name = "textBox_numeroDocumento";
            textBox_numeroDocumento.Size = new Size(154, 31);
            textBox_numeroDocumento.TabIndex = 10;
            textBox_numeroDocumento.TextChanged += textBox_numeroDocumento_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, tipoDocumento, numeroDocumento });
            dataGridView1.Location = new Point(5, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(563, 319);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.DataPropertyName = "Apellido";
            apellido.HeaderText = "apellido";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            // 
            // tipoDocumento
            // 
            tipoDocumento.DataPropertyName = "TipoDocumento";
            tipoDocumento.HeaderText = "Tipo Documento";
            tipoDocumento.MinimumWidth = 8;
            tipoDocumento.Name = "tipoDocumento";
            // 
            // numeroDocumento
            // 
            numeroDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            numeroDocumento.DataPropertyName = "NumeroDocumento";
            numeroDocumento.HeaderText = "Numero de documento";
            numeroDocumento.MinimumWidth = 8;
            numeroDocumento.Name = "numeroDocumento";
            numeroDocumento.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(580, 622);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_numeroDocumento);
            Controls.Add(label_Num);
            Controls.Add(label_Tipo);
            Controls.Add(label_Dni);
            Controls.Add(comboBox_tipo);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Ingresar);
            Controls.Add(label_Apellido);
            Controls.Add(label_Nombre);
            Controls.Add(textBox_apellido);
            Controls.Add(textBox_nombre);
            Name = "Form1";
            Text = "Registro de Postulantes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_nombre;
        private TextBox textBox_apellido;
        private Label label_Nombre;
        private Label label_Apellido;
        private Button btn_Ingresar;
        private Button btn_Limpiar;
        private ComboBox comboBox_tipo;
        private Label label_Dni;
        private Label label_Tipo;
        private Label label_Num;
        private TextBox textBox_numeroDocumento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn tipoDocumento;
        private DataGridViewTextBoxColumn numeroDocumento;
    }
}
