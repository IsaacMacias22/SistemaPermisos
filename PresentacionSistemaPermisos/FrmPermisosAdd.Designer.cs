
namespace PresentacionSistemaPermisos
{
    partial class FrmPermisosAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAcceso = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkEscritura = new System.Windows.Forms.CheckBox();
            this.chkEliminacion = new System.Windows.Forms.CheckBox();
            this.chkActualizacion = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.lblPermisos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 65);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::PresentacionSistemaPermisos.Properties.Resources.alumno;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PresentacionSistemaPermisos.Properties.Resources.eliminar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(553, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPermisos
            // 
            this.lblPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.ForeColor = System.Drawing.Color.White;
            this.lblPermisos.Location = new System.Drawing.Point(53, 20);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(494, 25);
            this.lblPermisos.TabIndex = 0;
            this.lblPermisos.Text = "Agregar Permisos";
            this.lblPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Módulo";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(16, 112);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(277, 28);
            this.cmbUsuarios.TabIndex = 20;
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Items.AddRange(new object[] {
            "Refacciones",
            "Taller"});
            this.cmbModulo.Location = new System.Drawing.Point(311, 112);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(277, 28);
            this.cmbModulo.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkActualizacion);
            this.groupBox1.Controls.Add(this.chkEliminacion);
            this.groupBox1.Controls.Add(this.chkEscritura);
            this.groupBox1.Controls.Add(this.chkLectura);
            this.groupBox1.Controls.Add(this.chkAcceso);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 183);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // chkAcceso
            // 
            this.chkAcceso.AutoSize = true;
            this.chkAcceso.Location = new System.Drawing.Point(16, 39);
            this.chkAcceso.Name = "chkAcceso";
            this.chkAcceso.Size = new System.Drawing.Size(81, 24);
            this.chkAcceso.TabIndex = 0;
            this.chkAcceso.Text = "Acceso";
            this.chkAcceso.UseVisualStyleBackColor = true;
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(16, 79);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(82, 24);
            this.chkLectura.TabIndex = 1;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkEscritura
            // 
            this.chkEscritura.AutoSize = true;
            this.chkEscritura.Location = new System.Drawing.Point(16, 118);
            this.chkEscritura.Name = "chkEscritura";
            this.chkEscritura.Size = new System.Drawing.Size(91, 24);
            this.chkEscritura.TabIndex = 2;
            this.chkEscritura.Text = "Escritura";
            this.chkEscritura.UseVisualStyleBackColor = true;
            // 
            // chkEliminacion
            // 
            this.chkEliminacion.AutoSize = true;
            this.chkEliminacion.Location = new System.Drawing.Point(161, 39);
            this.chkEliminacion.Name = "chkEliminacion";
            this.chkEliminacion.Size = new System.Drawing.Size(108, 24);
            this.chkEliminacion.TabIndex = 3;
            this.chkEliminacion.Text = "Eliminación";
            this.chkEliminacion.UseVisualStyleBackColor = true;
            // 
            // chkActualizacion
            // 
            this.chkActualizacion.AutoSize = true;
            this.chkActualizacion.Location = new System.Drawing.Point(161, 79);
            this.chkActualizacion.Name = "chkActualizacion";
            this.chkActualizacion.Size = new System.Drawing.Size(122, 24);
            this.chkActualizacion.TabIndex = 4;
            this.chkActualizacion.Text = "Actualización";
            this.chkActualizacion.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::PresentacionSistemaPermisos.Properties.Resources.guardar0_5;
            this.btnGuardar.Location = new System.Drawing.Point(467, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 42);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmPermisosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisosAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisosAdd";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActualizacion;
        private System.Windows.Forms.CheckBox chkEliminacion;
        private System.Windows.Forms.CheckBox chkEscritura;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkAcceso;
        private System.Windows.Forms.Button btnGuardar;
    }
}