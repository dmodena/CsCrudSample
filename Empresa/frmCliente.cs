using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empresa
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                Model.Cliente cliente = new Model.Cliente();
                cliente.Nome = txtNome.Text;

                DataAccess.Cliente daCliente = new DataAccess.Cliente();
                daCliente.inserir(cliente);

                MessageBox.Show("Cliente incluído com sucesso!");
                txtNome.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("O nome é obrigatório!");
                txtNome.Focus();
            }
        }
    }
}
