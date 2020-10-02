using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_CINES_COMPLETO
{
    public partial class FormVentanaPrincipalAdmin : Form
    {
        public FormVentanaPrincipalAdmin()
        {
            InitializeComponent();
        }
        bool botonUser=false;

        private void btn_user_Click(object sender, EventArgs e)
        {
            if(panel_user.Size == new Size(0,0))
            {
                panel_user.Size = new Size(400, this.Height);
            }
            else
            {
                panel_user.Size = new Size(0,0);
            }
        }
        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);

        }

        private void FormVentanaPrincipalAdmin_Load(object sender, EventArgs e)
        {
            panel_user.Size = new Size(0, 0);
        }
    }
}
