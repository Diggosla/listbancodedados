using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbancodedados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void limpar()
        {
            txtid.Clear();
            txtproduto.Clear() ;
            txtquantidade.Clear() ;
            txtpreco.Clear();
            txtid.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntadd_Click(object sender, EventArgs e)
        { 
            if(txtid.Text == "")
                {
                MessageBox.Show("ID  não pode ser vazio, por favor preencha o ID");
                txtid.Focus();
                return;
                 }
            if (txtproduto.Text == "") 
            {
                MessageBox.Show("PRODUTO não pode ser vazio, porfavor preencha o PRODUTO");
                txtproduto.Focus();
                return;
            }  
            if(txtquantidade.Text == "")
            {
                MessageBox.Show("QUANTIDADE não pode ser vazio, porfavor preencha a QUANTIDADE");
                txtquantidade.Focus();
                return;
            }
            if(txtpreco.Text == "")
            {
                MessageBox.Show("PREÇO não pode ser vazio, porfavor preencha o PREÇO");
                txtpreco.Focus();
                return;

            }


            string[] produtos = new string[4];
            produtos[0] = txtid.Text;
            produtos[1] = txtproduto.Text;
            produtos[2] = txtquantidade.Text;
            produtos[3] = txtpreco.Text;

            ListViewItem L = new ListViewItem(produtos);
            listView1.Items.Add(L);
            limpar();


           
        }

        private void bntremover_Click(object sender, EventArgs e)
        {
           

        }
    }
}
