using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace M07_FicheirosDeTexto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DirectoryInfo ficheiro = new DirectoryInfo(path + @"\Sumários by 1C3\");
            if (ficheiro.Exists == true)
            {
                Directory.Delete(path + @"\Sumários by 1C3\", true);
            }
            else MessageBox.Show("O ficheiro já não existia", "ERRO",MessageBoxButtons.OK , MessageBoxIcon.Error);

            this.Close();

        }
    }
}
