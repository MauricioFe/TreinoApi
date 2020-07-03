using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoApi.Models
{
    public class Usuario
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Usuario(int id, string nome, int idade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}