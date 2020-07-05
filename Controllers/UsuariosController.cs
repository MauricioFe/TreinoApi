using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TreinoApi.Models;

namespace TreinoApi.Controllers
{
    public class UsuariosController : ApiController
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Treinamento\Android\3º Etapa\Api com XML\Api\TreinoApi\TreinoApi\App_Data\ApiXml.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        //[HttpGet] /*Quando eu crio o método com o nome do verbo rest eu não preciso indicar qual verbo vai ser utilizado*/
        public List<Usuario> Get()
        {
            usuarios.Clear();
            cmd = new SqlCommand("Select * from Usuario", conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                Usuario usuario = new Usuario(Convert.ToInt32(item[0]), item[1].ToString(), Convert.ToInt32(item[2]));
                usuarios.Add(usuario);
            }
            conn.Close();

           
            return usuarios;
        }

        public void Post(string nome, int idade)
        {
            if (!string.IsNullOrEmpty(nome) && idade != 0)
            {
                cmd = new SqlCommand("Insert into Usuario values('" + nome + "', " + idade + ")", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
    }
}
