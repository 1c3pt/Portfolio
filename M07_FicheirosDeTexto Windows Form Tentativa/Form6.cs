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
    public partial class Form6 : Form
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static DirectoryInfo folder = new DirectoryInfo(path + @"\Sumários by 1C3\");
        public Form6()
        {
            InitializeComponent();


            foreach (var disciplina_item in folder.GetFiles())
            {
                string disc = disciplina_item.Name;
                comboBox1.Items.Add(disc.Substring(0, disc.Length - 4));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var Disciplina = comboBox1;
            string Data = dateTimePicker1.Text;
            if (Disciplina.Text != "")
            {
                StreamReader ficheiro = new StreamReader(new FileStream(folder + Disciplina.Text + ".txt", FileMode.Open, FileAccess.Read));


                bool data_escolhida = false;
                List<string> Sumário = new List<string>();
                


                    while (ficheiro.Peek() != -1)
                    {

                        string linha = ficheiro.ReadLine();


                        if (linha.Contains(Data))
                        {


                            data_escolhida = true;
                            while (!linha.Contains("======================================"))
                            {
                                linha = ficheiro.ReadLine();
                                Sumário.Add(linha);
                            }
                            var message = string.Join(Environment.NewLine, Sumário);
                            MessageBox.Show("======================================\n" + message);
                        }

                    }
                    if (!data_escolhida) MessageBox.Show("Não existe nenhuns apontamentos registados na data indicada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);




                    ficheiro.Close();
                
            }
            else MessageBox.Show("Tem que escolher uma disciplina", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
