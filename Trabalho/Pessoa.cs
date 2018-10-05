using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Pessoa : SerHumano
    {
        private string nome,
            telefone,
            celular,
            sexo,
            cidade,
            estado,
            bairro,
            logradouro,
            numero,
            complemento;

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void SetCelular(string celular)
        {
            this.celular = celular;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public void SetLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        public void SetComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetTelefone()
        {
            return this.telefone;
        }

        public string GetCelular()
        {
            return this.celular;
        }

        public string GetSexo()
        {
            return this.sexo;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public string GetEstado()
        {
            return this.estado;
        }

        public string GetBairro()
        {
            return this.bairro;
        }

        public string GetLogradouro()
        {
            return this.logradouro;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public string GetComplemento()
        {
            return this.complemento;
        }

        public override string ToString()
        {
            return this.nome.ToUpper();
        }
    }
}
