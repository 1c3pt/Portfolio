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


    public partial class Form3 : Form
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static DirectoryInfo folder = new DirectoryInfo(path + @"\Sumários by 1C3\");



        public Form3()
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
            if (comboBox1.Text != "")
            {
                Form4 f4 = new Form4(comboBox1.Text);
                f4.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Tem que escolher uma disciplina", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }




    }

}



