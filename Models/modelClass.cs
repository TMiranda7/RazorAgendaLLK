using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WEB_agendaLanlink.Models.Enum;

namespace WEB_agendaLanlink.Models
{
        [DataContract]
        public class BaseModel
        {
            public int Id { get; protected set; }
        }
        public class Pessoa : BaseModel
        {
            public string nome { get; protected set; }
            public int cpf { get; protected set; }
            public int telefone { get; protected set; }
            public int celular { get; protected set; }
            public string email { get; protected set; }
            public string site { get; protected set; }
            public tipoContato tipoContato { get; protected set; }
            public int enderecoId { get; protected set; }
            public virtual Endereco Endereco { get; protected set; }
            public Pessoa()
            {
            }
            public Pessoa(int id, string nome, int cpf, string email, int celular, int telefone)
            {
                this.Id = id;
                this.nome = nome;
                this.cpf = cpf;
                this.email = email;
                this.celular = celular;
                this.telefone = telefone;
            }
        }

        public class Endereco : BaseModel
        {
            public int numero { get; protected set; }
            public int cep { get; protected set; }
            public string bairro { get; protected set; }
            public string cidade { get; protected set; }
            public string estado { get; protected set; }
            public string logradouro { get; protected set; }
            public string complemento { get; protected set; }
            public tipoEndereco tipoEndereco { get; protected set; }          
            public Endereco()
            {
            }
            public Endereco( int id, int numero, int cep, string logradouro, string estado, string municipio)
            {
                this.Id = id;
                this.numero = numero;
                this.cep = cep;
                this.logradouro = logradouro;
                this.estado = estado;
                this.cidade = municipio;
            }
        }
}
