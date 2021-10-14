namespace WindowsEscuela
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
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnProfesor
            // 
            this.btnProfesor.Location = new System.Drawing.Point(46, 233);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(175, 23);
            this.btnProfesor.TabIndex = 0;
            this.btnProfesor.Text = "Crear Profesor ";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(258, 233);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(175, 23);
            this.btnAlumno.TabIndex = 1;
            this.btnAlumno.Text = "Crear Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // lstProfesores
            // 
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.Location = new System.Drawing.Point(46, 25);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(175, 186);
            this.lstProfesores.TabIndex = 2;
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.Location = new System.Drawing.Point(258, 25);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(175, 186);
            this.lstAlumnos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.lstProfesores);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnProfesor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.ListBox lstAlumnos;
    }
}

