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
    public partial class FormLogin : Form
    {
        ConexionDB conector = new ConexionDB();
        Usuario usuariointentando = new Usuario();
        Usuario usuarioAccedio = new Usuario();
        List<Usuario> vecUsuario = new List<Usuario>();
        bool acceso = false;
        public FormLogin()
        {
            InitializeComponent();
            txt_pass.PasswordChar = '●';
        }
        public void CargarVecUsuario(string consultaSQL)
        {
            vecUsuario.RemoveRange(0, vecUsuario.Count);
            vecUsuario.Clear();
            conector.CargarTabla(consultaSQL);
            for (int i=0;i< conector.PmiTabla.Rows.Count; i++)
            {
                vecUsuario.Add(new Usuario {
                    Pusuario = conector.PmiTabla.Rows[i]["usuario"].ToString(),
                    Ppass = conector.PmiTabla.Rows[i]["pass"].ToString(),
                    Ptipo = conector.PmiTabla.Rows[i]["tipo"].ToString()
                });                
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            usuariointentando.Pusuario = txt_usuario.Text;
            usuariointentando.Ppass = txt_pass.Text;
            CargarVecUsuario("select * from Usuarios");
         
            for (int i = 0; i < conector.PmiTabla.Rows.Count; i++)
            {             
                if (usuariointentando.Pusuario==vecUsuario[i].Pusuario && usuariointentando.Ppass==vecUsuario[i].Ppass )
                {
                    acceso = true;
                    usuarioAccedio = vecUsuario[i];
                }               
            }
            if(acceso)
            {
                if (usuarioAccedio.Ptipo == "admin")
                {
                    FormVentanaPrincipalAdmin ventanaAdmin = new FormVentanaPrincipalAdmin();
                    ventanaAdmin.Visible = true;
                    ventanaAdmin.Show();
                    Visible = false;                  
                }               
            }
            else
            {
                MessageBox.Show("DatosIncorrectos");
            }
        }
    }
}
