using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M07_FicheirosDeTexto
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }







        private void button1_Click(object sender, EventArgs e)
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathString = Path.Combine(path, "Sumários by 1C3");
            Directory.CreateDirectory(pathString);
            StreamWriter ficheiro = new StreamWriter(new FileStream(path + @"\Sumários by 1C3\"+textBox1.Text.ToUpper() + ".txt", FileMode.Create, FileAccess.Write));
            ficheiro.WriteLine("====================<«o»>===================");
            ficheiro.WriteLine(textBox1.Text + "\nProfessor/a: " + textBox2.Text);
            ficheiro.WriteLine(@"===================./«|»\.==================");
            ficheiro.Close();
            MessageBox.Show("A disciplina "+textBox1.Text+" foi adicionada!");
            this.Close();
            

        }
    }
}
