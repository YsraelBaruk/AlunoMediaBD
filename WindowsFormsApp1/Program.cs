using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static Conexao cx;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cx = new Conexao("localhost", "testedsbd", "root");
            if (cx.testarConexao())
            {
                Application.Run(new Form1());
            }
            else 
            {
                MessageBox.Show($"Erro: {cx.getMsgErro()}");
            }
        }
    }
}
