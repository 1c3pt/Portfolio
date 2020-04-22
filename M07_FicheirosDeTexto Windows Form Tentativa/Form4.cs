using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace M07_FicheirosDeTexto
{
    
    public partial class Form4 : Form
    {
        string texto;
        public Form4(string Texto_recebido)
        {
            InitializeComponent();
            texto = Texto_recebido;
            LabelDisciplina.Text = texto;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            



            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathString = Path.Combine(path, "Sumários by 1C3");
            Directory.CreateDirectory(pathString);
            StreamWriter ficheiro = new StreamWriter(new FileStream(path + @"\Sumários by 1C3\" + texto.ToString().ToUpper() + ".txt", FileMode.Append, FileAccess.Write));
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tem que escrever algo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ficheiro.WriteLine(dateTimePicker1.Text);
                ficheiro.WriteLine("Sumário:\n");
                ficheiro.WriteLine(textBox1.Text);
                ficheiro.WriteLine("======================================");
                ficheiro.Close();
                this.Close();
            }
            
            
        }

        
    }
}
