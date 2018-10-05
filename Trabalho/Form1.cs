using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class idade : Form
    {
        public idade()
        {
            InitializeComponent();

            nome.Leave += new EventHandler(EventoFoco);
            nascimento.TextChanged += new EventHandler(MostrarIdade);
        }

        private void EventoFoco(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                Mensagem.Aviso("O campo nome deve ser preenchido!", "Atenção");
            }
        }

        private void MostrarIdade(object sender, EventArgs e)
        {
            int numIdade = DateTime.Now.Year - nascimento.Value.Year - (DateTime.Now.DayOfYear < nascimento.Value.DayOfYear ? 1 : 0);
            textoIdade.Text = "Minha idade é: " + numIdade.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] listaAntiga = lista.Items.Cast<string>().ToArray();

            lista.Items.Clear();

            var novaLista = listaAntiga.OrderBy(a => a);

            foreach (var item in novaLista)

                lista.Items.Add(item.ToString());
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nome.Text) ||
                (string.IsNullOrWhiteSpace(telefone.Text) && string.IsNullOrWhiteSpace(celular.Text)) ||
                string.IsNullOrWhiteSpace(nascimento.Text) ||
                string.IsNullOrWhiteSpace(sexo.Text) ||
                string.IsNullOrWhiteSpace(cidade.Text) ||
                string.IsNullOrWhiteSpace(estado.Text) ||
                string.IsNullOrWhiteSpace(bairro.Text) ||
                string.IsNullOrWhiteSpace(logradouro.Text) ||
                string.IsNullOrWhiteSpace(numero.Text)
            )
            {
                Mensagem.Aviso("Existem campos que precisam ser preenchidos.", "Atenção");
            } else
            {
                Pessoa pessoa = new Pessoa();
                pessoa.SetNome(nome.Text);
                pessoa.SetTelefone(telefone.Text);
                pessoa.SetCelular(celular.Text);
                pessoa.SetNascimento(nascimento.Text);
                pessoa.SetSexo(sexo.Text);
                pessoa.SetCidade(cidade.Text);
                pessoa.SetEstado(estado.Text);
                pessoa.SetBairro(bairro.Text);
                pessoa.SetLogradouro(logradouro.Text);
                pessoa.SetNumero(numero.Text);

                lista.Items.Add(pessoa.GetNome());

                this.LimparForm();
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            this.LimparForm();
        }

        private void remover_Click(object sender, EventArgs e)
        {
            int selecionado = lista.SelectedIndex;

            if (selecionado >= 0)
            {
                lista.Items.RemoveAt(selecionado);
            }
        }

        private void LimparForm()
        {
            nome.Clear();
            telefone.Clear();
            celular.Clear();
            nascimento.ResetText();
            sexo.ResetText();
            cidade.Clear();
            estado.Clear();
            bairro.Clear();
            logradouro.Clear();
            numero.Clear();
            complemento.Clear();
        }

        private void za_Click(object sender, EventArgs e)
        {
            string[] listaAntiga = lista.Items.Cast<string>().ToArray();

            lista.Items.Clear();

            var novaLista = listaAntiga.OrderBy(a => a);

            var listaInversa = novaLista.Reverse();

            foreach (var item in listaInversa)

                lista.Items.Add(item.ToString());
        }
    }
}
