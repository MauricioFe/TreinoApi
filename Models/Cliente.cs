using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoApi.Models
{
    [DataContractAtribute]
    public class Usuario
    {
        [DataMember]
        public int Id{ get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public int Idade { get; set; }



        public Usuario(int id, string nome, int idade)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}