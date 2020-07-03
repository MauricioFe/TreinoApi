using System;
using System.Collections.Generic;
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

        //[HttpGet] /*Quando eu crio o método com o nome do verbo rest eu não preciso indicar qual verbo vai ser utilizado*/
        public List<Usuario> Get()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Treinamento\Android\3º Etapa\Api com XML\Api\TreinoApi\TreinoApi\App_Data\ApiXml.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Selec * from Usuario", conn);
            return usuarios;
        }

        public void Post(int id, string nome, int idade)
        {
            if (!string.IsNullOrEmpty(nome) && id != 0 && idade != 0)
                usuarios.Add(new Usuario(id, nome, idade));
        }
    }
}
