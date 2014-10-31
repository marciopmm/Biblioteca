using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void livroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Livro' table. You can move, or remove it, as needed.
            this.livroTableAdapter.Fill(this.database1DataSet.Livro);

        }

        private void editoraTextBox_TextChanged(object sender, EventArgs e)
        {

        }
             
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void livroBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livroBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet1);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Livro' table. You can move, or remove it, as needed.
            this.livroTableAdapter1.Fill(this.database1DataSet1.Livro);

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            emprestadoCheckBox1.Checked = false;
        }

        private void editoraTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
