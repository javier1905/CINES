namespace APP_CINES_COMPLETO
{
    partial class FormABMpeliculas
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
            this.btn_buscarImagen = new System.Windows.Forms.Button();
            this.ofd_buscador = new System.Windows.Forms.OpenFileDialog();
            this.pbx_monitor = new System.Windows.Forms.PictureBox();
            this.lbx_peliculas = new System.Windows.Forms.ListBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nombre = new APP_CINES_COMPLETO.JTextBox();
            this.txt_id = new APP_CINES_COMPLETO.JTextBox();
            this.jTextBox1 = new APP_CINES_COMPLETO.JTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscarImagen
            // 
            this.btn_buscarImagen.Location = new System.Drawing.Point(268, 121);
            this.btn_buscarImagen.Name = "btn_buscarImagen";
            this.btn_buscarImagen.Size = new System.Drawing.Size(29, 23);
            this.btn_buscarImagen.TabIndex = 3;
            this.btn_buscarImagen.Text = "<--";
            this.btn_buscarImagen.UseVisualStyleBackColor = true;
            this.btn_buscarImagen.Click += new System.EventHandler(this.btn_buscarImagen_Click);
            // 
            // ofd_buscador
            // 
            this.ofd_buscador.FileName = "openFileDialog1";
            // 
            // pbx_monitor
            // 
            this.pbx_monitor.Location = new System.Drawing.Point(60, 121);
            this.pbx_monitor.Name = "pbx_monitor";
            this.pbx_monitor.Size = new System.Drawing.Size(202, 199);
            this.pbx_monitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_monitor.TabIndex = 1;
            this.pbx_monitor.TabStop = false;
            // 
            // lbx_peliculas
            // 
            this.lbx_peliculas.FormattingEnabled = true;
            this.lbx_peliculas.Location = new System.Drawing.Point(387, 23);
            this.lbx_peliculas.Name = "lbx_peliculas";
            this.lbx_peliculas.Size = new System.Drawing.Size(196, 290);
            this.lbx_peliculas.TabIndex = 10;
            this.lbx_peliculas.SelectedIndexChanged += new System.EventHandler(this.lbx_peliculas_SelectedIndexChanged);
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(60, 76);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(202, 21);
            this.cbo_tipo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo:";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(5, 347);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(93, 23);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(490, 347);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 23);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(393, 347);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(199, 347);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 23);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(102, 347);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(93, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(296, 347);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(93, 23);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(60, 49);
            this.txt_nombre.MaxLength = 10;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pdecimales = false;
            this.txt_nombre.Penteros = false;
            this.txt_nombre.Phora = false;
            this.txt_nombre.Ptexto = true;
            this.txt_nombre.Size = new System.Drawing.Size(202, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(60, 23);
            this.txt_id.MaxLength = 5;
            this.txt_id.Name = "txt_id";
            this.txt_id.Pdecimales = false;
            this.txt_id.Penteros = true;
            this.txt_id.Phora = false;
            this.txt_id.Ptexto = false;
            this.txt_id.Size = new System.Drawing.Size(202, 20);
            this.txt_id.TabIndex = 0;
            // 
            // jTextBox1
            // 
            this.jTextBox1.Location = new System.Drawing.Point(281, 226);
            this.jTextBox1.MaxLength = 5;
            this.jTextBox1.Name = "jTextBox1";
            this.jTextBox1.Pdecimales = false;
            this.jTextBox1.Penteros = false;
            this.jTextBox1.Phora = true;
            this.jTextBox1.Ptexto = false;
            this.jTextBox1.Size = new System.Drawing.Size(33, 20);
            this.jTextBox1.TabIndex = 14;
            // 
            // FormABMpeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 396);
            this.Controls.Add(this.jTextBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_tipo);
            this.Controls.Add(this.lbx_peliculas);
            this.Controls.Add(this.pbx_monitor);
            this.Controls.Add(this.btn_buscarImagen);
            this.MaximumSize = new System.Drawing.Size(623, 435);
            this.MinimumSize = new System.Drawing.Size(623, 435);
            this.Name = "FormABMpeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.FormABMpeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_monitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarImagen;
        private System.Windows.Forms.OpenFileDialog ofd_buscador;
        private System.Windows.Forms.PictureBox pbx_monitor;
        private System.Windows.Forms.ListBox lbx_peliculas;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_aceptar;
        private JTextBox txt_id;
        private JTextBox txt_nombre;
        private JTextBox jTextBox1;
    }
}