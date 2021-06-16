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

namespace Aula7PO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StreamWriter swLeia = new StreamWriter("Livros.txt");
            swLeia.WriteLine(txtISBN.Text.Trim());
            swLeia.WriteLine(txtTitulo.Text);
            swLeia.WriteLine(txtAutor.Text);
            swLeia.WriteLine(txtAnoPublicacao.Text);
            swLeia.Close();
            MessageBox.Show("Salvo!");

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            StreamReader srLeia = new StreamReader("Livros.txt");
            string Livrolido = srLeia.ReadToEnd();
            MessageBox.Show(Livrolido);

        }
    }
}
