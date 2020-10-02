using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace APP_CINES_COMPLETO
{
    class ConexionDB
    {
       private SqlConnection miConexion = new SqlConnection();
       private SqlCommand miComando = new SqlCommand();
       private  SqlDataReader miLector;
       private DataTable miTabla;
       private string cadenaConexion;
       private SqlDataAdapter miDataAdapter;
       private DataSet miDataSet;

        public ConexionDB()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=Complejo_de_salas;Integrated Security=True";
        }
        public void Conectar()
        {
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public void Desconectar()
        {
            miConexion.Close();
            miConexion.Dispose();
        }
        public void CargarLector (string consultaSQL)
        {
            this.Conectar();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = consultaSQL;
            miLector = miComando.ExecuteReader();
        }
        public void CargarTabla(string consultaSQL)
        {
            this.Conectar();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = consultaSQL;
            miTabla = new DataTable();
            miTabla.Load(miComando.ExecuteReader());
            this.Desconectar();
        }
        public void EjecutaConsulta(string consultaSQL)
        {
            this.Conectar();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = consultaSQL;
            miComando.Parameters.Add("@tapa",SqlDbType.Image);
            miComando.ExecuteNonQuery();
            this.Desconectar();
        }
        public void CargarLectorNombre(string nombreTabla)
        {
            this.Conectar();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
            miComando.CommandText = "select * from "+ nombreTabla;
            miLector = miComando.ExecuteReader();
        }
        public void CargarDataSet(string consultaSQL)
        {
            this.Conectar();
            miDataAdapter = new SqlDataAdapter(consultaSQL, miConexion);
            miDataSet = new DataSet();
            miDataAdapter.Fill(miDataSet, "Peliculas");
            this.Desconectar();
        }          

        public SqlDataReader PmiLector { get => miLector; set => miLector = value; }
        public DataTable PmiTabla { get => miTabla; set => miTabla = value; }
        public string PcadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public SqlDataAdapter PmiDataAdapter { get => miDataAdapter; set => miDataAdapter = value; }
        public DataSet PmiDataSet { get => miDataSet; set => miDataSet = value; }
        public SqlCommand PmiComando { get => miComando; set => miComando = value; }
        public SqlConnection PmiConexion { get => miConexion; set => miConexion = value; }
    }
}
