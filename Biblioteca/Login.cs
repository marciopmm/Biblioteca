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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Logar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.database1DataSet1.Usuario);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("O campo Login esta vazio");
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha esta vazio");
                return;
            }

            bool loginOK = VerificarLogin(txtLogin.Text, txtSenha.Text);

            if (loginOK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtLogin.Clear();
                txtSenha.Clear();
                MessageBox.Show("Login e/ou senha inválidos.", "Presta atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool VerificarLogin(string login, string senha)
        {
            /* Aqui você deve ir na tabela de Usuarios e
             * verificar se existe um usuário com este login
             * e senha. Caso exista, este método retorna 'true'.
             * Caso não exista, retorna 'false'.
             */

            // Isto é apenas temporário. Favor executar como descrito acima.
            return login == "aula" && senha == "aula";
        }
    }
}
