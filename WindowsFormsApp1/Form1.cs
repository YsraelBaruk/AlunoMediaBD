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
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string cmdsql = "INSERT INTO filme VALUES (0,'Teste', 2010,5,1,'Teste Comentario')";
            if (Program.cx.INSERT(cmdsql) > 0)
            {
                MessageBox.Show("Aluno inserido com sucesso", "Cadastro de Aluno");
            }
            else
            {
                MessageBox.Show("Cadastro errado", "Cadastro Erro");
            }
        }
    }
}
