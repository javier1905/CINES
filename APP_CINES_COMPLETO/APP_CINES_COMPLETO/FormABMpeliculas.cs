using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace APP_CINES_COMPLETO
{
    public partial class FormABMpeliculas : Form
    {
        Pelicula peliculaCargar = new Pelicula();
        ConexionDB conectorPelicula = new ConexionDB();
        List<Pelicula> vecPelicula = new List<Pelicula>();
        bool boton = false;
        public FormABMpeliculas()
        {
            InitializeComponent();            
        }

        private void btn_buscarImagen_Click(object sender, EventArgs e)
        {
            this.ofd_buscador.ShowDialog();
            if(!ofd_buscador.FileName.Equals(""))
            {
                peliculaCargar.Ptapa.Load(ofd_buscador.FileName);
                pbx_monitor.Image = peliculaCargar.Ptapa.Image;
            }
        }

        private void FormABMpeliculas_Load(object sender, EventArgs e)
        {
            CargarLista(lbx_peliculas);
            CargarCombo(cbo_tipo, "Tipos_de_peliculas");
            HabilitaElementos(0,0,0,1,1,0,1,1,1,0,0,1);
            if (lbx_peliculas.Items.Count !=0) { lbx_peliculas.SelectedIndex = 0; }
        }
        public void CargarLista(ListBox lista)
        {
            vecPelicula.RemoveRange(0, vecPelicula.Count);
            vecPelicula.Clear();            
            conectorPelicula.CargarDataSet("select * from Peliculas");
            for (int i = 0; i < conectorPelicula.PmiDataSet.Tables[0].Rows.Count; i++)
            {
                byte[] datos = new byte[0];
                PictureBox miBox = new PictureBox();
                //if (conectorPelicula.PmiDataSet.Tables[0].Rows[i]["tapa"].Equals(null))
                try
                {
                datos = (byte[])conectorPelicula.PmiDataSet.Tables[0].Rows[i]["tapa"];
                MemoryStream ms = new MemoryStream(datos);
                miBox.Image = Bitmap.FromStream(ms);                 
                }catch(Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
                vecPelicula.Add(new Pelicula
                {
                      Pid = Convert.ToInt32(conectorPelicula.PmiDataSet.Tables["Peliculas"].Rows[i]["id_pelicula"]),
                      Pnombre = conectorPelicula.PmiDataSet.Tables[0].Rows[i]["nom_pelicula"].ToString(),
                      Ptipo = Convert.ToInt32(conectorPelicula.PmiDataSet.Tables[0].Rows[i]["id_tipo_pelicula"]),
                      Ptapa=miBox
                });
            }
            lista.Items.Clear();
            for (int i = 0; i < vecPelicula.Count; i++) { lista.Items.Add(vecPelicula[i].TostringPelicula()); }
        }
        public void CargarCombo(ComboBox combo, string nombreTabla)
        {           
            conectorPelicula.CargarDataSet("select * from "+nombreTabla);
            combo.DataSource = conectorPelicula.PmiDataSet.Tables[0];
            combo.ValueMember = conectorPelicula.PmiDataSet.Tables[0].Columns[0].ColumnName;
            combo.DisplayMember = conectorPelicula.PmiDataSet.Tables[0].Columns[1].ColumnName;
            combo.SelectedIndex = -1;
        }
        public void Selector(int index)
        {
            txt_id.Text = vecPelicula[index].Pid.ToString();
            txt_nombre.Text = vecPelicula[index].Pnombre;
            cbo_tipo.SelectedValue = vecPelicula[index].Ptipo;
            pbx_monitor.Image = vecPelicula[index].Ptapa.Image;
        }

        private void lbx_peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selector(lbx_peliculas.SelectedIndex);
        }
        public void HabilitaElementos(int id, int nombre, int tipo, int lista, int monitorImagen, int botonADD, int nuevo, int editar, int eliminar,int aceptar, int cancelar, int salir)
        {
            if (id == 1) { txt_id.Enabled = true; } else { txt_id.Enabled = false;}
            if (nombre == 1) { txt_nombre.Enabled = true; } else { txt_nombre.Enabled = false; }
            if (tipo == 1) { cbo_tipo.Enabled = true; } else { cbo_tipo.Enabled = false; }
            if (lista == 1) { lbx_peliculas.Enabled = true; } else { lbx_peliculas.Enabled = false; }
            if (monitorImagen == 1) { pbx_monitor.Enabled = true; } else { pbx_monitor.Enabled = false; }
            if (botonADD == 1) { btn_buscarImagen.Enabled = true; } else { btn_buscarImagen.Enabled = false; }
            if (nuevo == 1) { btn_nuevo.Enabled = true; } else { btn_nuevo.Enabled = false; }
            if (editar == 1) { btn_editar.Enabled = true; } else { btn_editar.Enabled = false; }
            if (eliminar == 1) { btn_eliminar.Enabled = true; } else { btn_eliminar.Enabled = false; }
            if (cancelar == 1) { btn_cancelar.Enabled = true; } else { btn_cancelar.Enabled = false; }
            if (salir == 1) { btn_salir.Enabled = true; } else { btn_salir.Enabled = false; }
            if (aceptar == 1) { btn_aceptar.Enabled = true; } else { btn_aceptar.Enabled = false; }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            boton = true;
            HabilitaElementos(1,1,1,0,1,1,0,0,0,1,1,0);
            txt_id.Clear();
            txt_nombre.Clear();
            cbo_tipo.SelectedIndex = -1;           
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            HabilitaElementos(0,1,1,0,1,1,0,0,0,1,1,0);
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            HabilitaElementos(0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1);
            boton = false;
            if(lbx_peliculas.Items.Count!=0){lbx_peliculas.SelectedIndex = 0;}
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            peliculaCargar.Pid = Convert.ToInt32(txt_id.Text);
            peliculaCargar.Pnombre = txt_nombre.Text;
            peliculaCargar.Ptipo = Convert.ToInt32(cbo_tipo.SelectedValue);
            MemoryStream memo = new MemoryStream();
            peliculaCargar.Ptapa.Image.Save(memo, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] dat = new byte[memo.Length];
            dat = memo.GetBuffer();
            conectorPelicula.Conectar();
            conectorPelicula.PmiComando.Connection = conectorPelicula.PmiConexion;
            conectorPelicula.PmiComando.CommandType = CommandType.Text;
            if (boton)//INSERTAR PELICULA
            {                        
                conectorPelicula.PmiComando.CommandText ="exec pa_InsertaPelicula @id,@nombre,@tipo,@tap";
                conectorPelicula.PmiComando.Parameters.Add("@id", SqlDbType.Int);
                conectorPelicula.PmiComando.Parameters.Add("@nombre", SqlDbType.VarChar);
                conectorPelicula.PmiComando.Parameters.Add("@tipo", SqlDbType.Int);
                conectorPelicula.PmiComando.Parameters.Add("@tap", SqlDbType.Image);
                conectorPelicula.PmiComando.Parameters["@id"].Value = peliculaCargar.Pid;
                conectorPelicula.PmiComando.Parameters["@nombre"].Value = peliculaCargar.Pnombre;
                conectorPelicula.PmiComando.Parameters["@tipo"].Value = peliculaCargar.Ptipo;
                conectorPelicula.PmiComando.Parameters["@tap"].Value = dat;                                           
            }
            else// EDITAR PELICULA
            {                    
                conectorPelicula.PmiComando.CommandText = "exec pa_UpdatePelicula @id,@nombre,@tipo,@tapa";
                conectorPelicula.PmiComando.Parameters.Add("@id", SqlDbType.Int);
                conectorPelicula.PmiComando.Parameters.Add("@nombre", SqlDbType.VarChar);
                conectorPelicula.PmiComando.Parameters.Add("@tipo", SqlDbType.Int);
                conectorPelicula.PmiComando.Parameters.Add("@tapa", SqlDbType.Image);
                conectorPelicula.PmiComando.Parameters["@id"].Value= vecPelicula[lbx_peliculas.SelectedIndex].Pid;
                conectorPelicula.PmiComando.Parameters["@nombre"].Value = peliculaCargar.Pnombre;
                conectorPelicula.PmiComando.Parameters["@tipo"].Value = peliculaCargar.Ptipo;
                conectorPelicula.PmiComando.Parameters["@tapa"].Value = dat;                                                     
            }
            conectorPelicula.PmiComando.ExecuteNonQuery();
            conectorPelicula.Desconectar();
            boton = false;
            HabilitaElementos(0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1);
            CargarLista(lbx_peliculas);
            if (lbx_peliculas.Items.Count != 0){lbx_peliculas.SelectedIndex = 0;}
        }
    }       
}
