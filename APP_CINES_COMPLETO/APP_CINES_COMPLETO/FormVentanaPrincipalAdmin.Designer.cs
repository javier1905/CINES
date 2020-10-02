namespace APP_CINES_COMPLETO
{
    partial class FormVentanaPrincipalAdmin
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
            this.btn_user = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_user
            // 
            this.btn_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_user.Location = new System.Drawing.Point(720, 4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(75, 23);
            this.btn_user.TabIndex = 0;
            this.btn_user.Text = "Admin User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // panel_user
            // 
            this.panel_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_user.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_user.Location = new System.Drawing.Point(424, 31);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(371, 419);
            this.panel_user.TabIndex = 1;
            // 
            // FormVentanaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_user);
            this.Controls.Add(this.btn_user);
            this.Name = "FormVentanaPrincipalAdmin";
            this.Text = "FormVentanaPrincipalAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVentanaPrincipalAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Panel panel_user;
    }
}