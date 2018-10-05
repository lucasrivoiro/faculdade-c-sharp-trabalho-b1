using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class SerHumano
    {
        private string nascimento;

        public void SetNascimento(string nascimento)
        {
            this.nascimento = nascimento;
        }

        public string GetNascimento()
        {
            return this.nascimento;
        }
    }
}
