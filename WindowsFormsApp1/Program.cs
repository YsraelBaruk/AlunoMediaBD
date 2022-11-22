using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Conexao cx = new Conexao("localhost", "Teste_DS_BD","root");
            if (cx.testarConexao())
            {
                Application.Run(new Form1());
            }
            else 
            {
                MessageBox.Show(cx.getMsgErro());
            }
        }
    }
}
