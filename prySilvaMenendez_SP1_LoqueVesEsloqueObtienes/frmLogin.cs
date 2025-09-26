using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP1_LoqueVesEsloqueObtienes
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if ((usuario == "Administrador" && contraseña == "adm135$") ||
                (usuario == "Operador" && contraseña == "ope246$"))
            {
                frmInicio Principal = new frmInicio();
                Principal.Show();
                this.Hide();
                Principal.FormClosed += (s, args) => this.Close();

            }
            else
            {
                intentos++;
                MessageBox.Show("Usuario o Contraseña Incorrectos");

                if (intentos >= 3)
                {
                    MessageBox.Show("Se Han Excedido los Intentos Permitidos", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
