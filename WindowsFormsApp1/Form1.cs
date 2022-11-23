using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregarDt();
        }

        private void carregarDt()
        {
            dtDados.Rows.Clear();
            string cmdSql = "SELECT * FROM filme";
            DataTable ListaFilmes = Program.cx.SELECT(cmdSql);
            if (ListaFilmes != null)
            {
                foreach (DataRow linha in ListaFilmes.Rows)
                {
                    dtDados.Rows.Add(linha[1],linha[2],linha[3],
                        Convert.ToBoolean(linha[4]) ? "Sim" : "Não",
                        linha[5]);
                }
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string ano = txtAno.Text;
            string avaliacao = cbAvaliacao.Text;
            int like = chckLike.Checked ? 1 : 0;
            string comentario = txtComentario.Text;

            string cmdsql = $"CALL filme_cadastrar('{nome}', '{ano}', '{avaliacao}', '{like}', '{comentario}')";
            if (Program.cx.INSERT(cmdsql) > 0)
            {
                MessageBox.Show("Filme inserido com sucesso", "Avaliação de Filmes");
                carregarDt();
            }
            else
            {
                MessageBox.Show("As informações não foram enviadas", "Erro da Avaliação");
            }
        }
    }
}
