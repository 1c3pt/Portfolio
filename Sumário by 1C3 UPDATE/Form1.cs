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
    public partial class Form1 : Form
    {
        static Form1 f1 = new Form1();
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static DirectoryInfo folder = new DirectoryInfo(path + @"\Sumários by 1C3");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 AdicionarDisciplinas = new Form2();
            AdicionarDisciplinas.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string pathString = System.IO.Path.Combine(path, "Sumários by 1C3");
                Directory.CreateDirectory(pathString);


                List<string> Disciplinas = new List<string>();
                foreach (var disciplina_item in folder.GetFiles())
                {

                    string disc = disciplina_item.Name;
                    Disciplinas.Add(disc.Substring(0, disc.Length - 4));

                }
                var message = string.Join(Environment.NewLine, Disciplinas);

                MessageBox.Show(message, "Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Não existem disciplinas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                
                Form3 f3 = new Form3();
                f3.Show();
            }
            catch
            {
                MessageBox.Show("Não existem disciplinas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try 
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
            catch
            {
                MessageBox.Show("Não existem disciplinas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            {
                Form6 F6 = new Form6();
                F6.Show();
            }
            catch
            {
                MessageBox.Show("Não existem disciplinas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
               
            }
        }
    }
}
