namespace Proyecto.Formularios
{
    partial class frmAsignar
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
            label1 = new Label();
            dtgvCurso = new DataGridView();
            label2 = new Label();
            txtNumLegajo = new TextBox();
            btnBuscarAlumno = new Button();
            lblNombreAlumno = new Label();
            btnAsignar = new Button();
            Curso = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            DOCENTE = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            NROEDICION = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 102);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE CURSOS VIGENTES ";
            // 
            // dtgvCurso
            // 
            dtgvCurso.AllowUserToAddRows = false;
            dtgvCurso.AllowUserToDeleteRows = false;
            dtgvCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCurso.Columns.AddRange(new DataGridViewColumn[] { Curso, FECHA, DOCENTE, PRECIO, NROEDICION });
            dtgvCurso.Location = new Point(14, 119);
            dtgvCurso.Margin = new Padding(3, 2, 3, 2);
            dtgvCurso.Name = "dtgvCurso";
            dtgvCurso.ReadOnly = true;
            dtgvCurso.RowHeadersWidth = 51;
            dtgvCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCurso.Size = new Size(636, 284);
            dtgvCurso.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 25);
            label2.Name = "label2";
            label2.Size = new Size(199, 15);
            label2.TabIndex = 2;
            label2.Text = "NUMERO DE LEGAJO DEL ALUMNO:";
            // 
            // txtNumLegajo
            // 
            txtNumLegajo.Location = new Point(234, 22);
            txtNumLegajo.Name = "txtNumLegajo";
            txtNumLegajo.Size = new Size(100, 23);
            txtNumLegajo.TabIndex = 3;
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.Location = new Point(360, 22);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(75, 23);
            btnBuscarAlumno.TabIndex = 4;
            btnBuscarAlumno.Text = "Buscar";
            btnBuscarAlumno.UseVisualStyleBackColor = true;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click;
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(32, 58);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(202, 15);
            lblNombreAlumno.TabIndex = 5;
            lblNombreAlumno.Text = "NOMBRE Y APELLIDO DEL ALUMNO:";
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(275, 424);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(75, 23);
            btnAsignar.TabIndex = 6;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // Curso
            // 
            Curso.HeaderText = "CURSO";
            Curso.Name = "Curso";
            Curso.ReadOnly = true;
            Curso.Width = 70;
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.Name = "FECHA";
            FECHA.ReadOnly = true;
            FECHA.Width = 69;
            // 
            // DOCENTE
            // 
            DOCENTE.HeaderText = "DOCENTE";
            DOCENTE.Name = "DOCENTE";
            DOCENTE.ReadOnly = true;
            DOCENTE.Width = 84;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            PRECIO.Width = 72;
            // 
            // NROEDICION
            // 
            NROEDICION.HeaderText = "NROEDICION";
            NROEDICION.Name = "NROEDICION";
            NROEDICION.ReadOnly = true;
            NROEDICION.Width = 103;
            // 
            // frmAsignar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 477);
            Controls.Add(btnAsignar);
            Controls.Add(lblNombreAlumno);
            Controls.Add(btnBuscarAlumno);
            Controls.Add(txtNumLegajo);
            Controls.Add(label2);
            Controls.Add(dtgvCurso);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAsignar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Cursos";
            Load += frmAsignar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvCurso;
        private Label label2;
        private TextBox txtNumLegajo;
        private Button btnBuscarAlumno;
        private Label lblNombreAlumno;
        private Button btnAsignar;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn DOCENTE;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn NROEDICION;
    }
}